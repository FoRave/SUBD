namespace СУБД_Домашний_питомец
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxLogin = new System.Windows.Forms.TextBox();
            this.TbxPassw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnVhod = new System.Windows.Forms.Button();
            this.PanelCaptcha = new System.Windows.Forms.Panel();
            this.TbxCaptcha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PCaptcha = new System.Windows.Forms.Panel();
            this.LblC4 = new System.Windows.Forms.Label();
            this.LblC3 = new System.Windows.Forms.Label();
            this.LblC2 = new System.Windows.Forms.Label();
            this.LblC1 = new System.Windows.Forms.Label();
            this.CbxShowPassw = new System.Windows.Forms.CheckBox();
            this.petShopBAUDataSet = new СУБД_Домашний_питомец.PetShopBAUDataSet();
            this.BSUser = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new СУБД_Домашний_питомец.PetShopBAUDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Домашний_питомец.PetShopBAUDataSetTableAdapters.TableAdapterManager();
            this.PanelCaptcha.SuspendLayout();
            this.PCaptcha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petShopBAUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // TbxLogin
            // 
            this.TbxLogin.Location = new System.Drawing.Point(146, 97);
            this.TbxLogin.Name = "TbxLogin";
            this.TbxLogin.Size = new System.Drawing.Size(197, 35);
            this.TbxLogin.TabIndex = 2;
            this.TbxLogin.Text = "admin";
            // 
            // TbxPassw
            // 
            this.TbxPassw.Location = new System.Drawing.Point(146, 152);
            this.TbxPassw.Name = "TbxPassw";
            this.TbxPassw.Size = new System.Drawing.Size(197, 35);
            this.TbxPassw.TabIndex = 4;
            this.TbxPassw.Text = "admin";
            this.TbxPassw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = "Пароль:";
            // 
            // BtnVhod
            // 
            this.BtnVhod.Location = new System.Drawing.Point(156, 392);
            this.BtnVhod.Name = "BtnVhod";
            this.BtnVhod.Size = new System.Drawing.Size(149, 38);
            this.BtnVhod.TabIndex = 5;
            this.BtnVhod.Text = "Вход";
            this.BtnVhod.UseVisualStyleBackColor = true;
            this.BtnVhod.Click += new System.EventHandler(this.BtnVhod_Click);
            // 
            // PanelCaptcha
            // 
            this.PanelCaptcha.Controls.Add(this.TbxCaptcha);
            this.PanelCaptcha.Controls.Add(this.label4);
            this.PanelCaptcha.Controls.Add(this.PCaptcha);
            this.PanelCaptcha.Location = new System.Drawing.Point(54, 243);
            this.PanelCaptcha.Name = "PanelCaptcha";
            this.PanelCaptcha.Size = new System.Drawing.Size(353, 143);
            this.PanelCaptcha.TabIndex = 7;
            this.PanelCaptcha.Visible = false;
            // 
            // TbxCaptcha
            // 
            this.TbxCaptcha.Location = new System.Drawing.Point(171, 98);
            this.TbxCaptcha.Name = "TbxCaptcha";
            this.TbxCaptcha.Size = new System.Drawing.Size(170, 35);
            this.TbxCaptcha.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите капчу:";
            // 
            // PCaptcha
            // 
            this.PCaptcha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PCaptcha.BackgroundImage")));
            this.PCaptcha.Controls.Add(this.LblC4);
            this.PCaptcha.Controls.Add(this.LblC3);
            this.PCaptcha.Controls.Add(this.LblC2);
            this.PCaptcha.Controls.Add(this.LblC1);
            this.PCaptcha.Location = new System.Drawing.Point(14, 10);
            this.PCaptcha.Name = "PCaptcha";
            this.PCaptcha.Size = new System.Drawing.Size(327, 82);
            this.PCaptcha.TabIndex = 8;
            this.PCaptcha.Paint += new System.Windows.Forms.PaintEventHandler(this.PCaptcha_Paint);
            // 
            // LblC4
            // 
            this.LblC4.AutoSize = true;
            this.LblC4.BackColor = System.Drawing.Color.Transparent;
            this.LblC4.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblC4.Location = new System.Drawing.Point(277, 15);
            this.LblC4.Name = "LblC4";
            this.LblC4.Size = new System.Drawing.Size(26, 31);
            this.LblC4.TabIndex = 12;
            this.LblC4.Text = "a";
            // 
            // LblC3
            // 
            this.LblC3.AutoSize = true;
            this.LblC3.BackColor = System.Drawing.Color.Transparent;
            this.LblC3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblC3.Location = new System.Drawing.Point(181, 42);
            this.LblC3.Name = "LblC3";
            this.LblC3.Size = new System.Drawing.Size(26, 31);
            this.LblC3.TabIndex = 10;
            this.LblC3.Text = "a";
            // 
            // LblC2
            // 
            this.LblC2.AutoSize = true;
            this.LblC2.BackColor = System.Drawing.Color.Transparent;
            this.LblC2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblC2.Location = new System.Drawing.Point(98, 15);
            this.LblC2.Name = "LblC2";
            this.LblC2.Size = new System.Drawing.Size(26, 31);
            this.LblC2.TabIndex = 11;
            this.LblC2.Text = "a";
            // 
            // LblC1
            // 
            this.LblC1.AutoSize = true;
            this.LblC1.BackColor = System.Drawing.Color.Transparent;
            this.LblC1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblC1.Location = new System.Drawing.Point(26, 29);
            this.LblC1.Name = "LblC1";
            this.LblC1.Size = new System.Drawing.Size(26, 31);
            this.LblC1.TabIndex = 9;
            this.LblC1.Text = "a";
            // 
            // CbxShowPassw
            // 
            this.CbxShowPassw.AutoSize = true;
            this.CbxShowPassw.Location = new System.Drawing.Point(146, 193);
            this.CbxShowPassw.Name = "CbxShowPassw";
            this.CbxShowPassw.Size = new System.Drawing.Size(197, 32);
            this.CbxShowPassw.TabIndex = 8;
            this.CbxShowPassw.Text = "Показать пароль";
            this.CbxShowPassw.UseVisualStyleBackColor = true;
            this.CbxShowPassw.CheckedChanged += new System.EventHandler(this.CbxShowPassw_CheckedChanged);
            // 
            // petShopBAUDataSet
            // 
            this.petShopBAUDataSet.DataSetName = "PetShopBAUDataSet";
            this.petShopBAUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BSUser
            // 
            this.BSUser.DataMember = "Users";
            this.BSUser.DataSource = this.petShopBAUDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.ProductCategoryTableAdapter = null;
            this.tableAdapterManager.ProductManufacturerTableAdapter = null;
            this.tableAdapterManager.ProductProviderTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = СУБД_Домашний_питомец.PetShopBAUDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 450);
            this.Controls.Add(this.CbxShowPassw);
            this.Controls.Add(this.PanelCaptcha);
            this.Controls.Add(this.BtnVhod);
            this.Controls.Add(this.TbxPassw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "СУБД \"Домашний питомец\"";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.PanelCaptcha.ResumeLayout(false);
            this.PanelCaptcha.PerformLayout();
            this.PCaptcha.ResumeLayout(false);
            this.PCaptcha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petShopBAUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxLogin;
        private System.Windows.Forms.TextBox TbxPassw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnVhod;
        private System.Windows.Forms.Panel PanelCaptcha;
        private System.Windows.Forms.TextBox TbxCaptcha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblC4;
        private System.Windows.Forms.Label LblC2;
        private System.Windows.Forms.Label LblC3;
        private System.Windows.Forms.Label LblC1;
        private System.Windows.Forms.Panel PCaptcha;
        private System.Windows.Forms.CheckBox CbxShowPassw;
        private PetShopBAUDataSet petShopBAUDataSet;
        private System.Windows.Forms.BindingSource BSUser;
        private PetShopBAUDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private PetShopBAUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

