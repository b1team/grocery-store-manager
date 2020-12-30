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
    public partial class QLHoaDon : UserControl
    {
        private DatabaseContext session;
        private static QLHoaDon _instance;
        public static QLHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHoaDon();
                return _instance;
            }
        }
        public QLHoaDon()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }
        public void LoadData()
        {
            try
            {
                BindingSource data = new BindingSource();
                data.DataSource = session.DsHoaDon.OrderByDescending(hoadon => hoadon.ThoiGianThanhToan).ToList();
                GridHoaDon.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Hệ thống đang được nâng cấp!!!");
            }
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void GridHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = GridHoaDon.Rows[e.RowIndex];
                var maHD = int.Parse(row.Cells[0].Value.ToString());
                session.DsChiTietHD.Load();
                var filter = session.DsChiTietHD.Local.ToBindingList().Where(hoadon => hoadon.MaHD == maHD);
                GridChiTietHoaDon.DataSource = filter.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            session.DsHoaDon.Load();
            var data = session.DsHoaDon.Local.ToBindingList().Where(hoadon => hoadon.MaHD.ToString().Contains(txtTimKiem.Text));
            GridHoaDon.DataSource = data.ToList();
        }
    }
}
