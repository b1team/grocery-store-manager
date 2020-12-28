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

        private void GiaoDich_Load(object sender, EventArgs e)
        {
            List<Model.GiaoDich> data = new List<Model.GiaoDich>();
            data.Add(new Model.GiaoDich("Hoa don1", "tutung", "thu", "12"));
            data.Add(new Model.GiaoDich("Hoa don2", "tu", "chi", "13"));
            data.Add(new Model.GiaoDich("Hoa don3", "ngoc", "thu", "14"));
            data.Add(new Model.GiaoDich("Hoa don4", "vuong", "chi", "15"));
            GridGiaoDich.DataSource = new List<Model.GiaoDich>();
            GridGiaoDich.DataSource = data;
        }
    }
}
