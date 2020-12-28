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

        private void DanhSachMatHang()
        {
            try
            {
                session.DsMatHang.OrderByDescending(kinhdoanh => kinhdoanh.DangKinhDoanh).Load();
                var filter = session.DsMatHang.Local.ToBindingList();
                GridQLHang.DataSource = filter;
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi!!!");
            }
        }

        private void QLHang_Load(object sender, EventArgs e)
        {
            DanhSachMatHang();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                session.SaveChanges();
                MessageBox.Show("Lưu thành công");
                DanhSachMatHang();
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công");
            }
        }
    }
}
