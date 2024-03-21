namespace СУБД_Домашний_питомец
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label userSurnameLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label userPatronymicLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.userSurnameLabel1 = new System.Windows.Forms.Label();
            this.BSUser = new System.Windows.Forms.BindingSource(this.components);
            this.petShopBAUDataSet = new СУБД_Домашний_питомец.PetShopBAUDataSet();
            this.userNameLabel1 = new System.Windows.Forms.Label();
            this.userPatronymicLabel1 = new System.Windows.Forms.Label();
            this.LblWorkText = new System.Windows.Forms.Label();
            this.LblRole = new System.Windows.Forms.Label();
            this.usersTableAdapter = new СУБД_Домашний_питомец.PetShopBAUDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new СУБД_Домашний_питомец.PetShopBAUDataSetTableAdapters.TableAdapterManager();
            this.DgvOrder = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TimerWork = new System.Windows.Forms.Timer(this.components);
            this.LblTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxFind = new System.Windows.Forms.TextBox();
            this.CmbCost = new System.Windows.Forms.ComboBox();
            this.BtnDel = new System.Windows.Forms.Button();
            this.LblId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TimerActive = new System.Windows.Forms.Timer(this.components);
            this.PList = new System.Windows.Forms.Panel();
            this.BtnShow = new System.Windows.Forms.Button();
            userSurnameLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            userPatronymicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopBAUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // userSurnameLabel
            // 
            userSurnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userSurnameLabel.AutoSize = true;
            userSurnameLabel.Location = new System.Drawing.Point(568, 9);
            userSurnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userSurnameLabel.Name = "userSurnameLabel";
            userSurnameLabel.Size = new System.Drawing.Size(105, 28);
            userSurnameLabel.TabIndex = 0;
            userSurnameLabel.Text = "Фамилия:";
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(615, 37);
            userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(58, 28);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Имя:";
            // 
            // userPatronymicLabel
            // 
            userPatronymicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            userPatronymicLabel.AutoSize = true;
            userPatronymicLabel.Location = new System.Drawing.Point(567, 65);
            userPatronymicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            userPatronymicLabel.Name = "userPatronymicLabel";
            userPatronymicLabel.Size = new System.Drawing.Size(106, 28);
            userPatronymicLabel.TabIndex = 4;
            userPatronymicLabel.Text = "Отчество:";
            // 
            // userSurnameLabel1
            // 
            this.userSurnameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userSurnameLabel1.AutoSize = true;
            this.userSurnameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserSurname", true));
            this.userSurnameLabel1.Location = new System.Drawing.Point(681, 9);
            this.userSurnameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userSurnameLabel1.Name = "userSurnameLabel1";
            this.userSurnameLabel1.Size = new System.Drawing.Size(64, 28);
            this.userSurnameLabel1.TabIndex = 1;
            this.userSurnameLabel1.Text = "label1";
            // 
            // BSUser
            // 
            this.BSUser.DataMember = "Users";
            this.BSUser.DataSource = this.petShopBAUDataSet;
            // 
            // petShopBAUDataSet
            // 
            this.petShopBAUDataSet.DataSetName = "PetShopBAUDataSet";
            this.petShopBAUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userNameLabel1
            // 
            this.userNameLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userNameLabel1.AutoSize = true;
            this.userNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserName", true));
            this.userNameLabel1.Location = new System.Drawing.Point(681, 37);
            this.userNameLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel1.Name = "userNameLabel1";
            this.userNameLabel1.Size = new System.Drawing.Size(64, 28);
            this.userNameLabel1.TabIndex = 3;
            this.userNameLabel1.Text = "label1";
            // 
            // userPatronymicLabel1
            // 
            this.userPatronymicLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPatronymicLabel1.AutoSize = true;
            this.userPatronymicLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserPatronymic", true));
            this.userPatronymicLabel1.Location = new System.Drawing.Point(681, 65);
            this.userPatronymicLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPatronymicLabel1.Name = "userPatronymicLabel1";
            this.userPatronymicLabel1.Size = new System.Drawing.Size(64, 28);
            this.userPatronymicLabel1.TabIndex = 5;
            this.userPatronymicLabel1.Text = "label1";
            // 
            // LblWorkText
            // 
            this.LblWorkText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblWorkText.AutoSize = true;
            this.LblWorkText.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblWorkText.Location = new System.Drawing.Point(48, 26);
            this.LblWorkText.Name = "LblWorkText";
            this.LblWorkText.Size = new System.Drawing.Size(225, 42);
            this.LblWorkText.TabIndex = 6;
            this.LblWorkText.Text = "Рабочее место";
            // 
            // LblRole
            // 
            this.LblRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRole.AutoSize = true;
            this.LblRole.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserRole", true));
            this.LblRole.Location = new System.Drawing.Point(421, 9);
            this.LblRole.Name = "LblRole";
            this.LblRole.Size = new System.Drawing.Size(52, 28);
            this.LblRole.TabIndex = 8;
            this.LblRole.Text = "Role";
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
            // DgvOrder
            // 
            this.DgvOrder.AllowUserToAddRows = false;
            this.DgvOrder.AllowUserToDeleteRows = false;
            this.DgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvOrder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvOrder.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOrder.ColumnHeadersVisible = false;
            this.DgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.DgvOrder.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvOrder.Location = new System.Drawing.Point(12, 194);
            this.DgvOrder.Name = "DgvOrder";
            this.DgvOrder.ReadOnly = true;
            this.DgvOrder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DgvOrder.RowHeadersVisible = false;
            this.DgvOrder.RowHeadersWidth = 51;
            this.DgvOrder.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.DgvOrder.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOrder.RowTemplate.DividerHeight = 20;
            this.DgvOrder.RowTemplate.Height = 125;
            this.DgvOrder.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOrder.Size = new System.Drawing.Size(858, 261);
            this.DgvOrder.TabIndex = 9;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ид заказа";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            this.Column4.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "фото";
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "описание";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Стоимость";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 200;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Время работы:";
            // 
            // TimerWork
            // 
            this.TimerWork.Enabled = true;
            this.TimerWork.Interval = 1000;
            this.TimerWork.Tick += new System.EventHandler(this.TimerWork_Tick);
            // 
            // LblTime
            // 
            this.LblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTime.AutoSize = true;
            this.LblTime.Location = new System.Drawing.Point(681, 93);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(96, 28);
            this.LblTime.TabIndex = 11;
            this.LblTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Поиск: ";
            // 
            // TbxFind
            // 
            this.TbxFind.Location = new System.Drawing.Point(103, 137);
            this.TbxFind.Name = "TbxFind";
            this.TbxFind.Size = new System.Drawing.Size(179, 35);
            this.TbxFind.TabIndex = 13;
            this.TbxFind.TextChanged += new System.EventHandler(this.TbxFind_TextChanged);
            // 
            // CmbCost
            // 
            this.CmbCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmbCost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCost.FormattingEnabled = true;
            this.CmbCost.Items.AddRange(new object[] {
            "Без сортировки",
            "Возростанию",
            "Убыванию"});
            this.CmbCost.Location = new System.Drawing.Point(638, 136);
            this.CmbCost.Name = "CmbCost";
            this.CmbCost.Size = new System.Drawing.Size(232, 36);
            this.CmbCost.TabIndex = 14;
            this.CmbCost.SelectedIndexChanged += new System.EventHandler(this.CmbCost_SelectedIndexChanged);
            // 
            // BtnDel
            // 
            this.BtnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDel.Location = new System.Drawing.Point(544, 467);
            this.BtnDel.Name = "BtnDel";
            this.BtnDel.Size = new System.Drawing.Size(326, 36);
            this.BtnDel.TabIndex = 15;
            this.BtnDel.Text = "Удалить выделенные заказы";
            this.BtnDel.UseVisualStyleBackColor = true;
            this.BtnDel.Click += new System.EventHandler(this.BtnDel_Click);
            // 
            // LblId
            // 
            this.LblId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblId.AutoSize = true;
            this.LblId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSUser, "UserID", true));
            this.LblId.Location = new System.Drawing.Point(438, 40);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 28);
            this.LblId.TabIndex = 16;
            this.LblId.Text = "Id";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "Сортировать стоимость по:";
            // 
            // TimerActive
            // 
            this.TimerActive.Enabled = true;
            this.TimerActive.Interval = 1000;
            this.TimerActive.Tick += new System.EventHandler(this.TimerActive_Tick);
            // 
            // PList
            // 
            this.PList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PList.Location = new System.Drawing.Point(12, 461);
            this.PList.Name = "PList";
            this.PList.Size = new System.Drawing.Size(478, 42);
            this.PList.TabIndex = 18;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(12, 93);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(316, 38);
            this.BtnShow.TabIndex = 19;
            this.BtnShow.Text = "Показать запрос фильтрации";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(882, 515);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.PList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.BtnDel);
            this.Controls.Add(this.CmbCost);
            this.Controls.Add(this.TbxFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvOrder);
            this.Controls.Add(this.LblRole);
            this.Controls.Add(this.LblWorkText);
            this.Controls.Add(userPatronymicLabel);
            this.Controls.Add(this.userPatronymicLabel1);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameLabel1);
            this.Controls.Add(userSurnameLabel);
            this.Controls.Add(this.userSurnameLabel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(836, 509);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "СУБД \"Домашний питомец\"";
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.BSUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petShopBAUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userSurnameLabel1;
        private System.Windows.Forms.Label userNameLabel1;
        private System.Windows.Forms.Label userPatronymicLabel1;
        private System.Windows.Forms.Label LblWorkText;
        private System.Windows.Forms.Label LblRole;
        private PetShopBAUDataSet petShopBAUDataSet;
        private PetShopBAUDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private PetShopBAUDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource BSUser;
        private System.Windows.Forms.DataGridView DgvOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerWork;
        private System.Windows.Forms.Label LblTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxFind;
        private System.Windows.Forms.ComboBox CmbCost;
        private System.Windows.Forms.Button BtnDel;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer TimerActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel PList;
        private System.Windows.Forms.Button BtnShow;
    }
}