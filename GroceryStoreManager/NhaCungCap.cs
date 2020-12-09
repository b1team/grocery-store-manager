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
    public partial class NhaCungCap : UserControl
    {
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
        }
    }
}
