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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        private NguoiDung nguoiDung;
        private Quyen quuyenNguoiDung;

        internal NguoiDung NguoiDung { get => nguoiDung; set => nguoiDung = value; }
        internal Quyen QuuyenNguoiDung { get => quuyenNguoiDung; set => quuyenNguoiDung = value; }

        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.BaoCao.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.BaoCao.Instance);
                GroceryStoreManager.BaoCao.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.BaoCao.Instance.BringToFront();
            }
            else
                GroceryStoreManager.BaoCao.Instance.BringToFront();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MetroFramework.MetroMessageBox.Show(this, "Message", "Ahihi", MessageBoxButtons.OK, MessageBoxIcon.Error, 100);
        }

        private void NhapHang_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NhapHang"] != null)
            {
                Application.OpenForms["NhapHang"].BringToFront();
            }
            else
            {
                NhapHang form = new NhapHang();
                form.NguoiDung = nguoiDung;
                form.Quyen = quuyenNguoiDung;
                form.Show();
            }
            
        }

        private void TileNhaCungCap_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.NhaCungCap.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.NhaCungCap.Instance);
                GroceryStoreManager.NhaCungCap.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.NhaCungCap.Instance.BringToFront();
            }
            else
            {
                GroceryStoreManager.NhaCungCap.Instance.BringToFront();
                GroceryStoreManager.NhaCungCap.Instance.LoadData();

            }
        }

        private void TileBanHang_Click(object sender, EventArgs e)
        {
            BanHang form = new BanHang();
            form.Show();
        }

        private void TileBaoCao_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.BaoCao.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.BaoCao.Instance);
                GroceryStoreManager.BaoCao.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.BaoCao.Instance.BringToFront();
            }
            else
            {
                GroceryStoreManager.BaoCao.Instance.BringToFront();
            }
        }

        private void TileNhapHang_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.QLPhieuNhap.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.QLPhieuNhap.Instance);
                GroceryStoreManager.QLPhieuNhap.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.QLPhieuNhap.Instance.BringToFront();
            }
            else
            {
                GroceryStoreManager.QLPhieuNhap.Instance.BringToFront();
                GroceryStoreManager.QLPhieuNhap.Instance.LoadData();
            }
                
        }

        private void TileQLHang_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.QLHang.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.QLHang.Instance);
                GroceryStoreManager.QLHang.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.QLHang.Instance.BringToFront();
            }
            else
            {
                GroceryStoreManager.QLHang.Instance.BringToFront();
                GroceryStoreManager.QLHang.Instance.LayDanhSachMatHang();
            }
               
        }

        private void TileQLHoaDon_Click(object sender, EventArgs e)
        {
            if (!panel.Controls.Contains(GroceryStoreManager.QLHoaDon.Instance))
            {
                panel.Controls.Add(GroceryStoreManager.QLHoaDon.Instance);
                GroceryStoreManager.QLHoaDon.Instance.Dock = DockStyle.Fill;
                GroceryStoreManager.QLHoaDon.Instance.BringToFront();
            }
            else
            {
                GroceryStoreManager.QLHoaDon.Instance.BringToFront();
                GroceryStoreManager.QLHoaDon.Instance.LoadData();
            }
        }
    }
}
