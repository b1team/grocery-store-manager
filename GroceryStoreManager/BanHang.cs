﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStoreManager.Domains;
using System.Data.Entity;

namespace GroceryStoreManager
{
    public partial class BanHang : MetroFramework.Forms.MetroForm
    {
        private DatabaseContext session;
        private NguoiDung thuNgan;
        private Quyen quyen;
        private List<Model.BanHang> SelectedItems = new List<Model.BanHang>();
        private List<Model.BanHang> Items = new List<Model.BanHang>();

        internal NguoiDung ThuNgan { get => thuNgan; set => thuNgan = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }

        public BanHang()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }

        public void HoaDon()
        {
            lbNhanVienThuNgan.Text = thuNgan.TenNguoiDung;
            int TongTienHang = 140000;
            Double GiamGia = 10;
            int KhachCanTra = (int)(TongTienHang * ((100 - GiamGia) / 100));
            txtKhachThanhToan.Text = "150000";

            int KhachThanhToan = Int32.Parse(txtKhachThanhToan.Text);
            int TienThuaTraKhach = KhachThanhToan - KhachCanTra;

            lbTongTienHang.Text = TongTienHang.ToString();
            lbGiamGia.Text = GiamGia.ToString();
            lbKhachCanTra.Text = KhachCanTra.ToString();
            lbTienThuaTraKhach.Text = TienThuaTraKhach.ToString();

        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            session.DsMatHang.Load();
            HoaDon();
        }

        private void txtKhachThanhToan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void handle_cellclicks(object sender, DataGridViewCellEventArgs e)
        { 
            DataGridViewRow row = GridBanHang2.Rows[e.RowIndex];
            var item = new Model.BanHang(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToInt32(row.Cells[2].Value), 1);
            
            int rows = GridBanHang1.Rows.Count;
            var existed = false;
            for(int i=0; i<rows; i++)
            {
                DataGridViewRow row1 = GridBanHang1.Rows[i];
                if (row1.Cells["MaHang"].Value.ToString() == item.MaHang)
                {
                    row1.Cells["SoLuong"].Value = (int)row1.Cells["SoLuong"].Value + 1;
                    row1.Cells["ThanhTien"].Value = Model.BanHang.ThanhToan((int)row1.Cells["DonGia"].Value, (int)row1.Cells["SoLuong"].Value);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                SelectedItems.Add(item);
                
            }
            GridBanHang1.DataSource = new List<Model.BanHang>();
            GridBanHang1.DataSource = SelectedItems;
        }



        private void GridBanHang1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = GridBanHang1.Rows[e.RowIndex];
            
        }

       
    }
}
