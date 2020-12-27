namespace GroceryStoreManager
{
    partial class GiaoDich
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTongthu = new MetroFramework.Controls.MetroLabel();
            this.lbTongChi = new MetroFramework.Controls.MetroLabel();
            this.GridGiaoDich = new MetroFramework.Controls.MetroGrid();
            this.HoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridGiaoDich)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTongthu
            // 
            this.lbTongthu.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTongthu.Location = new System.Drawing.Point(41, 65);
            this.lbTongthu.Name = "lbTongthu";
            this.lbTongthu.Size = new System.Drawing.Size(240, 38);
            this.lbTongthu.Style = MetroFramework.MetroColorStyle.Red;
            this.lbTongthu.TabIndex = 2;
            this.lbTongthu.Text = "20000";
            this.lbTongthu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTongthu.UseStyleColors = true;
            this.lbTongthu.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // lbTongChi
            // 
            this.lbTongChi.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbTongChi.Location = new System.Drawing.Point(335, 65);
            this.lbTongChi.Name = "lbTongChi";
            this.lbTongChi.Size = new System.Drawing.Size(244, 38);
            this.lbTongChi.Style = MetroFramework.MetroColorStyle.Red;
            this.lbTongChi.TabIndex = 3;
            this.lbTongChi.Text = "120000";
            this.lbTongChi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTongChi.UseStyleColors = true;
            // 
            // GridGiaoDich
            // 
            this.GridGiaoDich.AllowUserToResizeRows = false;
            this.GridGiaoDich.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridGiaoDich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridGiaoDich.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridGiaoDich.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGiaoDich.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridGiaoDich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridGiaoDich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoaDon,
            this.NguoiTao,
            this.LoaiPhieu,
            this.GiaTri});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridGiaoDich.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridGiaoDich.EnableHeadersVisualStyles = false;
            this.GridGiaoDich.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridGiaoDich.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridGiaoDich.Location = new System.Drawing.Point(0, 149);
            this.GridGiaoDich.Name = "GridGiaoDich";
            this.GridGiaoDich.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridGiaoDich.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridGiaoDich.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridGiaoDich.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridGiaoDich.Size = new System.Drawing.Size(1554, 552);
            this.GridGiaoDich.TabIndex = 2;
            // 
            // HoaDon
            // 
            this.HoaDon.DataPropertyName = "HoaDon";
            this.HoaDon.HeaderText = "Hóa Đơn";
            this.HoaDon.Name = "HoaDon";
            this.HoaDon.Width = 200;
            // 
            // NguoiTao
            // 
            this.NguoiTao.DataPropertyName = "NguoiTao";
            this.NguoiTao.HeaderText = "Người Tạo";
            this.NguoiTao.Name = "NguoiTao";
            this.NguoiTao.Width = 200;
            // 
            // LoaiPhieu
            // 
            this.LoaiPhieu.DataPropertyName = "LoaiPhieu";
            this.LoaiPhieu.HeaderText = "Loại Phiếu";
            this.LoaiPhieu.Name = "LoaiPhieu";
            this.LoaiPhieu.Width = 150;
            // 
            // GiaTri
            // 
            this.GiaTri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GiaTri.DataPropertyName = "GiaTri";
            this.GiaTri.HeaderText = "Giá Trị";
            this.GiaTri.Name = "GiaTri";
            // 
            // metroLabel3
            // 
            this.metroLabel3.BackColor = System.Drawing.Color.Silver;
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(30, 27);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(262, 94);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Tổng Thu";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BackColor = System.Drawing.Color.Silver;
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(326, 27);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(262, 94);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Tổng Chi";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTongChi);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbTongthu);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.GridGiaoDich);
            this.Name = "GiaoDich";
            this.Size = new System.Drawing.Size(1554, 704);
            this.Load += new System.EventHandler(this.GiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridGiaoDich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbTongthu;
        private MetroFramework.Controls.MetroLabel lbTongChi;
        private MetroFramework.Controls.MetroGrid GridGiaoDich;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiTao;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTri;
    }
}
