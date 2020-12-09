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
    public partial class GiaoDich : UserControl
    {
        private static GiaoDich _instance;
        public static GiaoDich Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GiaoDich();
                return _instance;
            }
        }
        public GiaoDich()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
