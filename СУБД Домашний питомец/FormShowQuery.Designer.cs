﻿namespace СУБД_Домашний_питомец
{
    partial class FormShowQuery
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
            this.LblQuery = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblQuery
            // 
            this.LblQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblQuery.Location = new System.Drawing.Point(0, 0);
            this.LblQuery.Name = "LblQuery";
            this.LblQuery.Size = new System.Drawing.Size(800, 450);
            this.LblQuery.TabIndex = 0;
            this.LblQuery.Text = "label1";
            // 
            // FormShowQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblQuery);
            this.Name = "FormShowQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Запрос";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LblQuery;
    }
}