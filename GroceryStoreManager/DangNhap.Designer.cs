﻿namespace GroceryStoreManager
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.txtMatKhau = new MetroFramework.Controls.MetroTextBox();
            this.txtTenDangNhap = new MetroFramework.Controls.MetroTextBox();
            this.btnDangNhap = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // txtMatKhau
            // 
            // 
            // 
            // 
            this.txtMatKhau.CustomButton.Image = null;
            this.txtMatKhau.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtMatKhau.CustomButton.Name = "";
            this.txtMatKhau.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtMatKhau.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMatKhau.CustomButton.TabIndex = 1;
            this.txtMatKhau.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMatKhau.CustomButton.UseSelectable = true;
            this.txtMatKhau.CustomButton.Visible = false;
            this.txtMatKhau.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtMatKhau.Lines = new string[0];
            this.txtMatKhau.Location = new System.Drawing.Point(154, 234);
            this.txtMatKhau.MaxLength = 32767;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.SelectionLength = 0;
            this.txtMatKhau.SelectionStart = 0;
            this.txtMatKhau.ShortcutsEnabled = true;
            this.txtMatKhau.Size = new System.Drawing.Size(266, 39);
            this.txtMatKhau.TabIndex = 1;
            this.txtMatKhau.UseSelectable = true;
            this.txtMatKhau.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMatKhau.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pressEnterHandler);
            // 
            // txtTenDangNhap
            // 
            // 
            // 
            // 
            this.txtTenDangNhap.CustomButton.Image = null;
            this.txtTenDangNhap.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtTenDangNhap.CustomButton.Name = "";
            this.txtTenDangNhap.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.txtTenDangNhap.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTenDangNhap.CustomButton.TabIndex = 1;
            this.txtTenDangNhap.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTenDangNhap.CustomButton.UseSelectable = true;
            this.txtTenDangNhap.CustomButton.Visible = false;
            this.txtTenDangNhap.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtTenDangNhap.Lines = new string[0];
            this.txtTenDangNhap.Location = new System.Drawing.Point(154, 150);
            this.txtTenDangNhap.MaxLength = 32767;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.PasswordChar = '\0';
            this.txtTenDangNhap.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTenDangNhap.SelectedText = "";
            this.txtTenDangNhap.SelectionLength = 0;
            this.txtTenDangNhap.SelectionStart = 0;
            this.txtTenDangNhap.ShortcutsEnabled = true;
            this.txtTenDangNhap.Size = new System.Drawing.Size(266, 39);
            this.txtTenDangNhap.TabIndex = 0;
            this.txtTenDangNhap.UseSelectable = true;
            this.txtTenDangNhap.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTenDangNhap.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTenDangNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pressEnterHandler);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(189, 317);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(166, 40);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseCustomBackColor = true;
            this.btnDangNhap.UseCustomForeColor = true;
            this.btnDangNhap.UseSelectable = true;
            this.btnDangNhap.UseStyleColors = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyUp += new System.Windows.Forms.KeyEventHandler(this.pressEnterHandler);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(140, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 39);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Tên người dùng";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroLabel2
            // 
            this.metroLabel2.Location = new System.Drawing.Point(121, 192);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(126, 39);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Mật Khẩu";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 470);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(590, 470);
            this.MinimumSize = new System.Drawing.Size(590, 470);
            this.Name = "DangNhap";
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangNhap_FormClosing);
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtMatKhau;
        private MetroFramework.Controls.MetroTextBox txtTenDangNhap;
        private MetroFramework.Controls.MetroButton btnDangNhap;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}