using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СУБД_Домашний_питомец
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection(@"Data Source=213.155.192.79,3002;Initial Catalog=PetShopBAU;Persist Security Info=True;User ID=u21baranov;Password=au5p;Encrypt=False");
        void GetCapcha()
        {
            Captcha = Guid.NewGuid().ToString().Substring(0,4);
            LblC1.Text = Captcha[0].ToString();
            LblC2.Text = Captcha[1].ToString();
            LblC3.Text = Captcha[2].ToString();
            LblC4.Text = Captcha[3].ToString();
            TbxCaptcha.Clear();
        }

        string Captcha = "";
        string FileName = Application.StartupPath + "\\auto.txt";

        private void BtnVhod_Click(object sender, EventArgs e)
        {
            if (TbxLogin.Text.Trim() == "" || TbxPassw.Text.Trim() == "")
            {
                MessageBox.Show("Не все поля заполнены.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetCapcha();
                return;
            }
            if (PanelCaptcha.Visible == true && TbxCaptcha.Text != Captcha)
            {
                MessageBox.Show("Капча введена неверно.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                GetCapcha();
                return;
            }
            BSUser.Filter = $"UserLogin = '{TbxLogin.Text}' and UserPassword = '{TbxPassw.Text}'";
            if (BSUser.Count > 0)
            {
                if (File.Exists(FileName))
                    File.Delete(FileName);
                FormUser Frm = new FormUser();
                Frm.BSUser.Filter = BSUser.Filter;
                this.Hide();
                PanelCaptcha.Visible = false;
                Frm.ShowDialog();
                this.Show();
            }
            else
            {
                if (!File.Exists(FileName))
                    File.Create(FileName);
                PanelCaptcha.Visible = true;
                GetCapcha();
                MessageBox.Show("Пользователя с таким логином и паролем нет.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "petShopBAUDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.petShopBAUDataSet.Users);
            if (File.Exists(FileName))
            {
                GetCapcha();
                PanelCaptcha.Visible = true;
            }
        }

        private void PCaptcha_Paint(object sender, PaintEventArgs e)
        {
            Random Rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                e.Graphics.DrawLine(new Pen(Color.Black, 2), 0, Rnd.Next(PCaptcha.Height), PCaptcha.Width, Rnd.Next(PCaptcha.Height));
            }
        }

        private void CbxShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            TbxPassw.UseSystemPasswordChar = !TbxPassw.UseSystemPasswordChar;
        }
    }
}
