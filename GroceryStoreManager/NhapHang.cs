using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryStoreManager
{
    public partial class NhapHang : UserControl
    {
        private static NhapHang _instance;
        public static NhapHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NhapHang();
                return _instance;
            }
        }
        public NhapHang()
        {
            InitializeComponent();
        }

        private void NhapHang_Load(object sender, EventArgs e)
        {
            List<Model.NhapHang> data = new List<Model.NhapHang>();
            data.Add(new Model.NhapHang("1", "Hang1", "NCC1", "NSX1", "2", "12", "24"));
            data.Add(new Model.NhapHang("2", "Hang2", "NCC2", "NSX2", "3", "10", "30"));
            data.Add(new Model.NhapHang("3", "Hang3", "NCC3", "NSX3", "4", "10", "40"));
            data.Add(new Model.NhapHang("4", "Hang4", "NCC4", "NSX4", "5", "10", "50"));
            GridNhapHang.DataSource = new List<Model.NhapHang>();
            GridNhapHang.DataSource = data;
        }
    }
}
