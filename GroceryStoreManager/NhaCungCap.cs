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

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            List<Model.NhaCungCap> data = new List<Model.NhaCungCap>();
            data.Add(new Model.NhaCungCap("1", "Nha cung cap1", "09384756", "hanoi"));
            data.Add(new Model.NhaCungCap("2", "Nha cung cap2", "123456", "hochiminh"));
            data.Add(new Model.NhaCungCap("3", "Nha cung cap3", "24523345", "danang"));
            data.Add(new Model.NhaCungCap("4", "Nha cung cap4", "63463454", "hochiminh"));
            GridNhaCC.DataSource = new List<Model.NhaCungCap>();
            GridNhaCC.DataSource = data;
        }
    }
}
