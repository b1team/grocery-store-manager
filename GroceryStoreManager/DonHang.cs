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
    public partial class DonHang : UserControl
    {
        private static DonHang _instance;
        public static DonHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DonHang();
                return _instance;
            }
        }
        public DonHang()
        {
            InitializeComponent();
        }


        private void DonHang_Load(object sender, EventArgs e)
        {
            List<Model.DonHang> data = new List<Model.DonHang>();
            data.Add(new Model.DonHang("1", "19/10/20", "tutung", "250000"));
            data.Add(new Model.DonHang("2", "20/11/20", "vuong", "30000"));
            data.Add(new Model.DonHang("3", "21/12/20", "ngoc", "45000"));
            data.Add(new Model.DonHang("4", "22/12/20", "tu", "50000"));

            GridDonHang.DataSource = new List<Model.DonHang>();
            GridDonHang.DataSource = data;
        }
    }
}
