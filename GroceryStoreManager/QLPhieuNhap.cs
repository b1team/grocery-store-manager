using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStoreManager.Domains;
using System.Data.Entity;

namespace GroceryStoreManager
{
    public partial class QLPhieuNhap : UserControl
    {
        private DatabaseContext session;
        private static QLPhieuNhap _instance;
        public static QLPhieuNhap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLPhieuNhap();
                return _instance;
            }
        }
        public QLPhieuNhap()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }

        public void LoadData()
        {
            try
            {
                BindingSource data = new BindingSource();
                data.DataSource = session.DsPhieuNhap.OrderByDescending(phieunhap => phieunhap.NgayTao).ToList();
                GridPhieuNhap.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Hệ thống đang được nâng cấp!!!");
            }
        }

        private void QLPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void GridChiTietPhieuNhap_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var row = GridChiTietPhieuNhap.Rows[e.RowIndex];
            int soluong = int.Parse(row.Cells[2].Value.ToString());
            int dongia = int.Parse(row.Cells[3].Value.ToString());
            row.Cells[4].Value = soluong * dongia;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                session.SaveChanges();
                MessageBox.Show("Lưu thành công");
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công");
            }
        }

        private void GridPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = GridPhieuNhap.Rows[e.RowIndex];
                var maphieunhap = int.Parse(row.Cells[0].Value.ToString());
                session.DsChiTietPN.Load();
                var filter = session.DsChiTietPN.Local.ToBindingList().Where(phieunhap => phieunhap.MaPhieuNhap == maphieunhap);
                GridChiTietPhieuNhap.DataSource = filter.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            session.DsPhieuNhap.Load();
            var data = session.DsPhieuNhap.Local.ToBindingList().Where(phieunhap => phieunhap.MaPhieuNhap.ToString().Contains(txtTimKiem.Text));
            GridPhieuNhap.DataSource = data.ToList();
        }
    }
}
