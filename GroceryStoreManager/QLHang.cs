using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using GroceryStoreManager.Domains;

namespace GroceryStoreManager
{
    public partial class QLHang : UserControl
    {
        private DatabaseContext session;
        private static QLHang _instance;
        public static QLHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHang();
                return _instance;
            }
        }
        public QLHang()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }

        public void LayDanhSachMatHang()
        {
            try
            {
                BindingSource data = new BindingSource();
                data.DataSource = session.DsMatHang.OrderByDescending(hang => hang.DangKinhDoanh).ToList();
                GridQLHang.DataSource = data;
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void QLHang_Load(object sender, EventArgs e)
        {
            LayDanhSachMatHang();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                session.SaveChanges();
                MessageBox.Show("Lưu thành công");
                LayDanhSachMatHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công");
            }
        }
    }
}
