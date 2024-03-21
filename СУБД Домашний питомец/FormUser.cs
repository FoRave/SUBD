using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СУБД_Домашний_питомец
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        struct Product
        {
            public string ID, Photo, FIO, OrderProducts, AllProductCost;
            public DateTime OrderDate;
        }

        List<Product> LstProducts = new List<Product>();
        int CursorOldX = 0, CursorOldY = 0;
        int CountUnActive = 0;
        int Pages = 1;
        string Query = "";
        void GetOrderFromDB()
        {
            LstProducts.Clear();
            Query = $@"SELECT [Order].OrderID, Users.UserPhoto, (Users.UserSurname + ' ' + Users.UserName + ' ' + Users.UserPatronymic) as FIO, [Order].OrderDate,
 (SELECT String_agg(Product.ProductName, ', ')
FROM     OrderProduct INNER JOIN
                  Product ON OrderProduct.ProductArticleNumber = Product.ProductArticleNumber
where OrderProduct.OrderID = [Order].OrderID) as OrderProduct,
 (SELECT Sum(Product.ProductCost * OrderProduct.OrderCount * (1 - Product.ProductDiscount / 100.0))
FROM     OrderProduct INNER JOIN
                  Product ON OrderProduct.ProductArticleNumber = Product.ProductArticleNumber
where OrderProduct.OrderID = [Order].OrderID) as AllProductCost
FROM     [Order] INNER JOIN
                  Users ON [Order].UserID = Users.UserID where 1 = 1 ";
            if (LblRole.Text == "2")
                Query += $" and Users.UserID = {LblId.Text} ";
            if (CmbCost.Text != "Без сортировки")
            {
                if (CmbCost.Text == "Возростанию")
                    Query += $"Order by AllProductCost asc ";
                else if (CmbCost.Text == "Убыванию")
                    Query += $"Order by AllProductCost desc ";
            }
            FormMain.con.Open();
            SqlCommand Cmd = new SqlCommand(Query, FormMain.con);
            SqlDataReader Rez = Cmd.ExecuteReader();
            while (Rez.Read())
            {
                if (!Rez["OrderProduct"].ToString().Contains(TbxFind.Text.Trim()))
                    continue;
                Product Prod = new Product();
                Prod.ID = Rez["OrderID"].ToString();
                Prod.Photo = Rez["UserPhoto"].ToString();
                Prod.FIO = Rez["FIO"].ToString();
                Prod.OrderProducts = Rez["OrderProduct"].ToString();
                Prod.AllProductCost = Rez["AllProductCost"].ToString();
                Prod.OrderDate = Convert.ToDateTime(Rez["OrderDate"]);
                LstProducts.Add(Prod);
            }
            PList.Controls.Clear();
            for (double i = Math.Round((LstProducts.Count + 1) / 4.0, 0); i >= 1; i--)
            {
                Label lbl = new Label();
                PList.Controls.Add(lbl);
                lbl.Text = i.ToString();
                lbl.AutoSize = true;
                lbl.Dock = DockStyle.Left;
                if (i == Pages)
                    lbl.Font = new Font("Comic Sans MS", 12F, FontStyle.Underline, GraphicsUnit.Point, ((byte)(204)));
                lbl.Click += Lbl_Click;
            }
            FormMain.con.Close();
            DgvOrder.Rows.Clear();
            if (LstProducts.Count == 0)
                return;
            for (int i = 4 * (Pages - 1); i <= (4 * Pages) - 1; i++)
            {
                string Txt = $@"{LstProducts[i].FIO}
Заказано: {LstProducts[i].OrderProducts}
Дата заказа: {LstProducts[i].OrderDate.ToString("dd.MM.yyyy")}";
                try
                {
                    DgvOrder.Rows.Add(LstProducts[i].ID, Image.FromFile(Application.StartupPath + LstProducts[i].Photo), Txt, "Стоимость: " + LstProducts[i].AllProductCost);
                }
                catch
                {
                    DgvOrder.Rows.Add(LstProducts[i].ID, Image.FromFile(Application.StartupPath + @"\photo\picture.png"), Txt, "Стоимость: " + LstProducts[i].AllProductCost);
                }
                if (double.Parse(LstProducts[i].AllProductCost.ToString()) > 4000)
                    DgvOrder.Rows[i % 4].DefaultCellStyle.BackColor = Color.Green;
            }
        }
        private void Lbl_Click(object sender, EventArgs e)
        {
            int i = int.Parse(((Label)sender).Text);
            Pages = i;
            GetOrderFromDB();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petShopBAUDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.petShopBAUDataSet.Users);
            CmbCost.SelectedIndex = 0;
            if (LblRole.Text == "1")
            {
                LblWorkText.Text = "Рабочее место администратора";
            }
            else if (LblRole.Text == "2")
            {
                LblWorkText.Text = "Рабочее место пользователя";
                BtnDel.Visible = false;
            }
            LblRole.Hide();
            LblId.Hide();
            GetOrderFromDB();
        }

        int H, M, S = 0;

        private void TbxFind_TextChanged(object sender, EventArgs e)
        {
            GetOrderFromDB();
        }

        private void CmbCost_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOrderFromDB();
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить все выделенные заказы?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
                return;
            string Query = "";
            for (int i = 0; i < DgvOrder.RowCount; i++)
            {
                if (DgvOrder.Rows[i].Selected)
                    Query += $@" Delete from OrderProduct
where OrderID = {DgvOrder.Rows[i].Cells[0].Value}
Delete from [Order]
where [Order].OrderID = {DgvOrder.Rows[i].Cells[0].Value} ";
            }
            FormMain.con.Open();
            SqlCommand Cmd = new SqlCommand(Query, FormMain.con);
            Cmd.ExecuteNonQuery();
            FormMain.con.Close();
            MessageBox.Show("Заказы удалены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetOrderFromDB();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            FormShowQuery Frm = new FormShowQuery();
            Frm.LblQuery.Text = Query;
            Frm.ShowDialog();
        }

        private void TimerActive_Tick(object sender, EventArgs e)
        {
            if (Form.ActiveForm != null && (Cursor.Position.X != CursorOldX || Cursor.Position.Y != CursorOldY))
            {
                CountUnActive = 0;
                CursorOldX = Cursor.Position.X;
                CursorOldY = Cursor.Position.Y;
            }
            else
            {
                CountUnActive++;
            }
            if (CountUnActive == 60)
            {
                TimerActive.Stop();
                Close();
            }
        }

        private void FormUser_KeyDown(object sender, KeyEventArgs e)
        {
            CountUnActive = 0;
        }

        private void TimerWork_Tick(object sender, EventArgs e)
        {
            string Time = "";
            S++;
            if (S == 60)
            {
                M++;
                S = 0;
            }
            if (M == 60)
            {
                H++;
                M = 0;
            }
            if (H < 10)
                Time += $"0{H}:";
            else
                Time += $"{H}:";
            if (M < 10)
                Time += $"0{M}:";
            else
                Time += $"{M}:";
            if (S < 10)
                Time += $"0{S}";
            else
                Time += $"{S}";
            LblTime.Text = Time;
        }
    }
}
