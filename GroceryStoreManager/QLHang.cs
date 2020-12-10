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
    public partial class QLHang : UserControl
    {
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
        }
    }
}
