namespace GroceryStoreManager
{
    partial class Home
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
            this.NhapHang = new MetroFramework.Controls.MetroTile();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.TileNhaCungCap = new MetroFramework.Controls.MetroTile();
            this.TileGiaoDich = new MetroFramework.Controls.MetroTile();
            this.TileQLPhieuNhap = new MetroFramework.Controls.MetroTile();
            this.TileQLHang = new MetroFramework.Controls.MetroTile();
            this.TileQLHoaDon = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // NhapHang
            // 
            this.NhapHang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NhapHang.ActiveControl = null;
            this.NhapHang.ForeColor = System.Drawing.Color.White;
            this.NhapHang.Location = new System.Drawing.Point(23, 63);
            this.NhapHang.Name = "NhapHang";
            this.NhapHang.Size = new System.Drawing.Size(176, 90);
            this.NhapHang.Style = MetroFramework.MetroColorStyle.Silver;
            this.NhapHang.TabIndex = 2;
            this.NhapHang.Text = "Nhập hàng";
            this.NhapHang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.NhapHang.UseCustomForeColor = true;
            this.NhapHang.UseSelectable = true;
            this.NhapHang.UseStyleColors = true;
            this.NhapHang.UseTileImage = true;
            this.NhapHang.Click += new System.EventHandler(this.DonHang_Click);
            // 
            // panel
            // 
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(23, 173);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1554, 704);
            this.panel.TabIndex = 3;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // TileNhaCungCap
            // 
            this.TileNhaCungCap.ActiveControl = null;
            this.TileNhaCungCap.Location = new System.Drawing.Point(412, 63);
            this.TileNhaCungCap.Name = "TileNhaCungCap";
            this.TileNhaCungCap.Size = new System.Drawing.Size(176, 90);
            this.TileNhaCungCap.Style = MetroFramework.MetroColorStyle.Green;
            this.TileNhaCungCap.TabIndex = 4;
            this.TileNhaCungCap.Text = "Quản lý nhà cung cấp";
            this.TileNhaCungCap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileNhaCungCap.UseSelectable = true;
            this.TileNhaCungCap.Click += new System.EventHandler(this.TileNhaCungCap_Click);
            // 
            // TileGiaoDich
            // 
            this.TileGiaoDich.ActiveControl = null;
            this.TileGiaoDich.Location = new System.Drawing.Point(214, 63);
            this.TileGiaoDich.Name = "TileGiaoDich";
            this.TileGiaoDich.Size = new System.Drawing.Size(176, 90);
            this.TileGiaoDich.Style = MetroFramework.MetroColorStyle.Black;
            this.TileGiaoDich.TabIndex = 6;
            this.TileGiaoDich.Text = "Báo cáo";
            this.TileGiaoDich.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileGiaoDich.UseSelectable = true;
            this.TileGiaoDich.Click += new System.EventHandler(this.TileGiaoDich_Click);
            // 
            // TileQLPhieuNhap
            // 
            this.TileQLPhieuNhap.ActiveControl = null;
            this.TileQLPhieuNhap.Location = new System.Drawing.Point(614, 63);
            this.TileQLPhieuNhap.Name = "TileQLPhieuNhap";
            this.TileQLPhieuNhap.Size = new System.Drawing.Size(176, 90);
            this.TileQLPhieuNhap.TabIndex = 7;
            this.TileQLPhieuNhap.Text = "Quản lý phiếu nhập";
            this.TileQLPhieuNhap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileQLPhieuNhap.UseSelectable = true;
            this.TileQLPhieuNhap.Click += new System.EventHandler(this.TileNhapHang_Click);
            // 
            // TileQLHang
            // 
            this.TileQLHang.ActiveControl = null;
            this.TileQLHang.Location = new System.Drawing.Point(810, 63);
            this.TileQLHang.Name = "TileQLHang";
            this.TileQLHang.Size = new System.Drawing.Size(176, 90);
            this.TileQLHang.Style = MetroFramework.MetroColorStyle.Orange;
            this.TileQLHang.TabIndex = 8;
            this.TileQLHang.Text = "Quản Lý Hàng";
            this.TileQLHang.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileQLHang.UseSelectable = true;
            this.TileQLHang.Click += new System.EventHandler(this.TileQLHang_Click);
            // 
            // TileQLHoaDon
            // 
            this.TileQLHoaDon.ActiveControl = null;
            this.TileQLHoaDon.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TileQLHoaDon.Location = new System.Drawing.Point(1003, 63);
            this.TileQLHoaDon.Name = "TileQLHoaDon";
            this.TileQLHoaDon.Size = new System.Drawing.Size(176, 90);
            this.TileQLHoaDon.Style = MetroFramework.MetroColorStyle.Green;
            this.TileQLHoaDon.TabIndex = 9;
            this.TileQLHoaDon.Text = "Quản Lý Hóa Đơn";
            this.TileQLHoaDon.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileQLHoaDon.UseCustomForeColor = true;
            this.TileQLHoaDon.UseSelectable = true;
            this.TileQLHoaDon.UseStyleColors = true;
            this.TileQLHoaDon.Click += new System.EventHandler(this.TileQLHoaDon_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.TileQLHoaDon);
            this.Controls.Add(this.TileQLHang);
            this.Controls.Add(this.TileQLPhieuNhap);
            this.Controls.Add(this.TileGiaoDich);
            this.Controls.Add(this.TileNhaCungCap);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.NhapHang);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile NhapHang;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroTile TileNhaCungCap;
        private MetroFramework.Controls.MetroTile TileGiaoDich;
        private MetroFramework.Controls.MetroTile TileQLPhieuNhap;
        private MetroFramework.Controls.MetroTile TileQLHang;
        private MetroFramework.Controls.MetroTile TileQLHoaDon;
    }
}

