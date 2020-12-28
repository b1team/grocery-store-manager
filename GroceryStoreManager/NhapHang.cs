using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroceryStoreManager.Domains;

namespace GroceryStoreManager
{
    public partial class NhapHang : MetroFramework.Forms.MetroForm
    {
        private NguoiDung thuNgan;
        private Quyen quyen;

        internal NguoiDung ThuNgan { get => thuNgan; set => thuNgan = value; }
        internal Quyen Quyen { get => quyen; set => quyen = value; }
        private List<Model.BanHang> SelectedItems = new List<Model.BanHang>();

        public NhapHang()
        {
            InitializeComponent();
        }

        private void GridBanHang2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridTimHang.Rows[e.RowIndex];
            var item = new Model.BanHang(Convert.ToString(row.Cells[0].Value), Convert.ToString(row.Cells[1].Value), Convert.ToInt32(row.Cells[2].Value), 1);

            int rows = gridChiTietPN.Rows.Count;
            var existed = false;
            for (int i = 0; i < rows; i++)
            {
                DataGridViewRow row1 = gridChiTietPN.Rows[i];
                if (row1.Cells["MaHang"].Value.ToString() == item.MaHang)
                {
                    row1.Cells["SoLuong"].Value = (int)row1.Cells["SoLuong"].Value + 1;
                    row1.Cells["ThanhTien"].Value = Model.BanHang.ThanhToan((int)row1.Cells["DonGia"].Value, (int)row1.Cells["SoLuong"].Value);
                    existed = true;
                    break;
                }
            }
            if (!existed)
            {
                SelectedItems.Add(item);

            }
            gridChiTietPN.DataSource = new List<Model.BanHang>();
            gridChiTietPN.DataSource = SelectedItems;
        }
    }
}
