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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.NhapHang = new MetroFramework.Controls.MetroTile();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.TileNhaCungCap = new MetroFramework.Controls.MetroTile();
            this.TileBaoCao = new MetroFramework.Controls.MetroTile();
            this.TileQLPhieuNhap = new MetroFramework.Controls.MetroTile();
            this.TileQLHang = new MetroFramework.Controls.MetroTile();
            this.TileQLHoaDon = new MetroFramework.Controls.MetroTile();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileQuanLyNhanVien = new MetroFramework.Controls.MetroTile();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NhapHang
            // 
            this.NhapHang.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.NhapHang.ActiveControl = null;
            this.NhapHang.ForeColor = System.Drawing.Color.White;
            this.NhapHang.Location = new System.Drawing.Point(219, 20);
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
            this.NhapHang.Click += new System.EventHandler(this.NhapHang_Click);
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
            this.TileNhaCungCap.Location = new System.Drawing.Point(1019, 20);
            this.TileNhaCungCap.Name = "TileNhaCungCap";
            this.TileNhaCungCap.Size = new System.Drawing.Size(176, 90);
            this.TileNhaCungCap.Style = MetroFramework.MetroColorStyle.Purple;
            this.TileNhaCungCap.TabIndex = 4;
            this.TileNhaCungCap.Text = "Quản lý nhà cung cấp";
            this.TileNhaCungCap.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileNhaCungCap.UseSelectable = true;
            this.TileNhaCungCap.Click += new System.EventHandler(this.TileNhaCungCap_Click);
            // 
            // TileBaoCao
            // 
            this.TileBaoCao.ActiveControl = null;
            this.TileBaoCao.Location = new System.Drawing.Point(25, 20);
            this.TileBaoCao.Name = "TileBaoCao";
            this.TileBaoCao.Size = new System.Drawing.Size(176, 90);
            this.TileBaoCao.Style = MetroFramework.MetroColorStyle.Lime;
            this.TileBaoCao.TabIndex = 6;
            this.TileBaoCao.Text = "Báo cáo";
            this.TileBaoCao.TileImage = global::GroceryStoreManager.Properties.Resources.icons8_report_file_80;
            this.TileBaoCao.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.TileBaoCao.UseSelectable = true;
            this.TileBaoCao.Click += new System.EventHandler(this.TileBaoCao_Click);
            // 
            // TileQLPhieuNhap
            // 
            this.TileQLPhieuNhap.ActiveControl = null;
            this.TileQLPhieuNhap.Location = new System.Drawing.Point(616, 20);
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
            this.TileQLHang.Location = new System.Drawing.Point(418, 20);
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
            this.TileQLHoaDon.Location = new System.Drawing.Point(818, 20);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.TileQLHoaDon);
            this.panel1.Controls.Add(this.TileQLHang);
            this.panel1.Controls.Add(this.NhapHang);
            this.panel1.Controls.Add(this.TileQLPhieuNhap);
            this.panel1.Controls.Add(this.TileBaoCao);
            this.panel1.Controls.Add(this.tileQuanLyNhanVien);
            this.panel1.Controls.Add(this.TileNhaCungCap);
            this.panel1.Location = new System.Drawing.Point(-2, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1602, 130);
            this.panel1.TabIndex = 10;
            // 
            // tileQuanLyNhanVien
            // 
            this.tileQuanLyNhanVien.ActiveControl = null;
            this.tileQuanLyNhanVien.Location = new System.Drawing.Point(1223, 20);
            this.tileQuanLyNhanVien.Name = "tileQuanLyNhanVien";
            this.tileQuanLyNhanVien.Size = new System.Drawing.Size(176, 90);
            this.tileQuanLyNhanVien.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileQuanLyNhanVien.TabIndex = 4;
            this.tileQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.tileQuanLyNhanVien.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileQuanLyNhanVien.UseSelectable = true;
            this.tileQuanLyNhanVien.Click += new System.EventHandler(this.quanLyNhanVienHandle);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile NhapHang;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroTile TileNhaCungCap;
        private MetroFramework.Controls.MetroTile TileBaoCao;
        private MetroFramework.Controls.MetroTile TileQLPhieuNhap;
        private MetroFramework.Controls.MetroTile TileQLHang;
        private MetroFramework.Controls.MetroTile TileQLHoaDon;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileQuanLyNhanVien;
    }
}

