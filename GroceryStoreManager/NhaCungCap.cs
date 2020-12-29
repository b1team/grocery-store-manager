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
    public partial class NhaCungCap : UserControl
    {
        private DatabaseContext session;
        private static NhaCungCap _instance;
        public static NhaCungCap Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhaCungCap();
                return _instance;
            }
        }
        public NhaCungCap()
        {
            InitializeComponent();
            session = new DatabaseContext();
        }
        public void LoadData()
        {
            try
            {
                session.DsNhaCungCap.Load();
                GridNhaCC.DataSource = session.DsNhaCungCap.Local.ToBindingList();
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi");
            }
        }
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                session.SaveChanges();
                MessageBox.Show("Lưu Thành Công");
            }
            catch(Exception){
                MessageBox.Show("Lưu không thành công");
            }
        }
    }
}
