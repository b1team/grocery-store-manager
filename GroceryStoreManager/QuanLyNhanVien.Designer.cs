
namespace GroceryStoreManager
{
    partial class QuanLyNhanVien
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtTimNhanVien = new MetroFramework.Controls.MetroTextBox();
            this.btnThemNV = new MetroFramework.Controls.MetroButton();
            this.gridNguoiDung = new MetroFramework.Controls.MetroGrid();
            this.btnCapNhat = new MetroFramework.Controls.MetroButton();
            this.maNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDangNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNguoiDungDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQuyenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.quyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ngayTaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nguoiDungBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 15);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tìm nhân viên:";
            // 
            // txtTimNhanVien
            // 
            // 
            // 
            // 
            this.txtTimNhanVien.CustomButton.Image = null;
            this.txtTimNhanVien.CustomButton.Location = new System.Drawing.Point(413, 1);
            this.txtTimNhanVien.CustomButton.Name = "";
            this.txtTimNhanVien.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtTimNhanVien.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimNhanVien.CustomButton.TabIndex = 1;
            this.txtTimNhanVien.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimNhanVien.CustomButton.UseSelectable = true;
            this.txtTimNhanVien.CustomButton.Visible = false;
            this.txtTimNhanVien.Lines = new string[0];
            this.txtTimNhanVien.Location = new System.Drawing.Point(115, 15);
            this.txtTimNhanVien.MaxLength = 32767;
            this.txtTimNhanVien.Name = "txtTimNhanVien";
            this.txtTimNhanVien.PasswordChar = '\0';
            this.txtTimNhanVien.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimNhanVien.SelectedText = "";
            this.txtTimNhanVien.SelectionLength = 0;
            this.txtTimNhanVien.SelectionStart = 0;
            this.txtTimNhanVien.ShortcutsEnabled = true;
            this.txtTimNhanVien.Size = new System.Drawing.Size(437, 25);
            this.txtTimNhanVien.TabIndex = 1;
            this.txtTimNhanVien.UseSelectable = true;
            this.txtTimNhanVien.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimNhanVien.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimNhanVien.TextChanged += new System.EventHandler(this.searchHandle);
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThemNV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThemNV.Location = new System.Drawing.Point(16, 645);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(187, 40);
            this.btnThemNV.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnThemNV.TabIndex = 2;
            this.btnThemNV.Text = "Thêm Nhân Viên";
            this.btnThemNV.UseCustomBackColor = true;
            this.btnThemNV.UseCustomForeColor = true;
            this.btnThemNV.UseSelectable = true;
            this.btnThemNV.UseStyleColors = true;
            this.btnThemNV.Click += new System.EventHandler(this.btnThemNV_Click);
            // 
            // gridNguoiDung
            // 
            this.gridNguoiDung.AllowUserToAddRows = false;
            this.gridNguoiDung.AllowUserToResizeRows = false;
            this.gridNguoiDung.AutoGenerateColumns = false;
            this.gridNguoiDung.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNguoiDung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNguoiDung.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridNguoiDung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNguoiDung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNguoiDungDataGridViewTextBoxColumn,
            this.tenDangNhapDataGridViewTextBoxColumn,
            this.tenNguoiDungDataGridViewTextBoxColumn,
            this.maQuyenDataGridViewTextBoxColumn,
            this.ngayTaoDataGridViewTextBoxColumn});
            this.gridNguoiDung.DataSource = this.nguoiDungBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNguoiDung.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridNguoiDung.EnableHeadersVisualStyles = false;
            this.gridNguoiDung.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridNguoiDung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridNguoiDung.Location = new System.Drawing.Point(10, 55);
            this.gridNguoiDung.Name = "gridNguoiDung";
            this.gridNguoiDung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridNguoiDung.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridNguoiDung.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridNguoiDung.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNguoiDung.Size = new System.Drawing.Size(1527, 571);
            this.gridNguoiDung.TabIndex = 3;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCapNhat.Location = new System.Drawing.Point(240, 645);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(187, 40);
            this.btnCapNhat.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseCustomBackColor = true;
            this.btnCapNhat.UseCustomForeColor = true;
            this.btnCapNhat.UseSelectable = true;
            this.btnCapNhat.UseStyleColors = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // maNguoiDungDataGridViewTextBoxColumn
            // 
            this.maNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "MaNguoiDung";
            this.maNguoiDungDataGridViewTextBoxColumn.HeaderText = "Mã người dùng";
            this.maNguoiDungDataGridViewTextBoxColumn.Name = "maNguoiDungDataGridViewTextBoxColumn";
            this.maNguoiDungDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenDangNhapDataGridViewTextBoxColumn
            // 
            this.tenDangNhapDataGridViewTextBoxColumn.DataPropertyName = "TenDangNhap";
            this.tenDangNhapDataGridViewTextBoxColumn.HeaderText = "Tên đăng nhập";
            this.tenDangNhapDataGridViewTextBoxColumn.Name = "tenDangNhapDataGridViewTextBoxColumn";
            this.tenDangNhapDataGridViewTextBoxColumn.Width = 150;
            // 
            // tenNguoiDungDataGridViewTextBoxColumn
            // 
            this.tenNguoiDungDataGridViewTextBoxColumn.DataPropertyName = "TenNguoiDung";
            this.tenNguoiDungDataGridViewTextBoxColumn.HeaderText = "Tên người dùng";
            this.tenNguoiDungDataGridViewTextBoxColumn.Name = "tenNguoiDungDataGridViewTextBoxColumn";
            this.tenNguoiDungDataGridViewTextBoxColumn.Width = 150;
            // 
            // maQuyenDataGridViewTextBoxColumn
            // 
            this.maQuyenDataGridViewTextBoxColumn.DataPropertyName = "MaQuyen";
            this.maQuyenDataGridViewTextBoxColumn.DataSource = this.quyenBindingSource;
            this.maQuyenDataGridViewTextBoxColumn.DisplayMember = "TenQuyen";
            this.maQuyenDataGridViewTextBoxColumn.HeaderText = "Quyền";
            this.maQuyenDataGridViewTextBoxColumn.Name = "maQuyenDataGridViewTextBoxColumn";
            this.maQuyenDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maQuyenDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.maQuyenDataGridViewTextBoxColumn.ValueMember = "MaQuyen";
            // 
            // quyenBindingSource
            // 
            this.quyenBindingSource.DataSource = typeof(GroceryStoreManager.Domains.Quyen);
            // 
            // ngayTaoDataGridViewTextBoxColumn
            // 
            this.ngayTaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayTaoDataGridViewTextBoxColumn.DataPropertyName = "NgayTao";
            this.ngayTaoDataGridViewTextBoxColumn.HeaderText = "Ngày tạo";
            this.ngayTaoDataGridViewTextBoxColumn.Name = "ngayTaoDataGridViewTextBoxColumn";
            // 
            // nguoiDungBindingSource
            // 
            this.nguoiDungBindingSource.DataSource = typeof(GroceryStoreManager.Domains.NguoiDung);
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.gridNguoiDung);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.txtTimNhanVien);
            this.Controls.Add(this.metroLabel1);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1554, 704);
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNguoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoiDungBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtTimNhanVien;
        private MetroFramework.Controls.MetroButton btnThemNV;
        private MetroFramework.Controls.MetroGrid gridNguoiDung;
        private System.Windows.Forms.BindingSource nguoiDungBindingSource;
        private MetroFramework.Controls.MetroButton btnCapNhat;
        private System.Windows.Forms.BindingSource quyenBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNguoiDungDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn maQuyenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTaoDataGridViewTextBoxColumn;
    }
}
