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
    public partial class BanHang : UserControl
    {
        private static BanHang _instance;
        public static BanHang Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BanHang();
                return _instance;
            }
        }
        public BanHang()
        {
            InitializeComponent();
        }
    }
}
