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

       
    }
}
