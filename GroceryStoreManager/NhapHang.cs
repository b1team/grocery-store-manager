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
    }
}
