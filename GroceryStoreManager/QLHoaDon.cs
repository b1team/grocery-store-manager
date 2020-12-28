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
    public partial class QLHoaDon : UserControl
    {
        private static QLHoaDon _instance;
        public static QLHoaDon Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHoaDon();
                return _instance;
            }
        }
        public QLHoaDon()
        {
            InitializeComponent();
        }

        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            List<Model.HoaDon> data = new List<Model.HoaDon>();
            data.Add(new Model.HoaDon("Hoa don1", "Hang 1", "thu", "tungnt", "10", "12000", "120000"));
            data.Add(new Model.HoaDon("Hoa don2", "Hang 2", "chi", "tu", "20", "12000", "240000"));
            data.Add(new Model.HoaDon("Hoa don3", "Hang 3", "thu", "vuong", "30", "12000", "360000"));
            data.Add(new Model.HoaDon("Hoa don4", "Hang 4", "chi", "ngoc", "40", "12000", "480000"));
            GridQLHoaDon.DataSource = new List<Model.HoaDon>();
            GridQLHoaDon.DataSource = data;
        }
    }
}
