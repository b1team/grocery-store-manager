using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using GroceryStoreManager.Domains;

namespace GroceryStoreManager
{
    public partial class BaoCao : UserControl
    {
        private static BaoCao _instance;
        private DatabaseContext db;
        private List<HoaDon> dsDoanhThu;
        private List<PhieuNhap> dsChiPhi;
        public static BaoCao Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BaoCao();
                return _instance;
            }
        }
        public BaoCao()
        {
            InitializeComponent();
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            db = new DatabaseContext();
            DateTime now = DateTime.Now;
            var defaultStartDate = new DateTime(now.Year, now.Month, 1);
            var defaultEndDate = defaultStartDate.AddMonths(1);
            this.dtBatDau.Value = defaultStartDate;
            this.dtKetThuc.Value = defaultEndDate.AddDays(-1);
            taoBaoCao(defaultStartDate, defaultEndDate);
            tabControlBaoCao.SelectedIndex = 0;
        }

        private void taoBaoCao(DateTime from, DateTime to, string query = null)
        {
            var danhSachDoanhThu = db.DsHoaDon.Where(hd => hd.DaThanhToan == true).Where(hd => hd.NgayTao >= from).Where(hd => hd.NgayTao < to).ToList();
            var danhSachChiPhi = db.DsPhieuNhap.Where(pn => pn.NgayTao >= from).Where(pn => pn.NgayTao < to).ToList();
            dsDoanhThu = danhSachDoanhThu;
            dsChiPhi = danhSachChiPhi;
            gridDoanhThu.DataSource = danhSachDoanhThu;
            gridChiPhi.DataSource = danhSachChiPhi;
            var tongThu = dsDoanhThu.Sum(s => s.ThanhTien);
            var tongChi = dsChiPhi.Sum(s => s.ThanhTien);
            lbTongthu.Text = tongThu.ToString();
            lbTongChi.Text = tongChi.ToString();
            lbLoiNhuan.Text = (tongThu - tongChi).ToString();
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            var from = dtBatDau.Value.Date;
            var to = dtKetThuc.Value.Date.AddDays(1);
            taoBaoCao(from, to);
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = txtMaHoaDon.Text.Trim().ToLower();
                gridDoanhThu.DataSource = dsDoanhThu.Where(hd => hd.MaHD.ToString().Contains(query)).ToList();
            }
            catch
            {
                gridDoanhThu.DataSource = dsDoanhThu;
                return;
            }
            
        }

        private void txtMaPhieuNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var query = txtMaPhieuNhap.Text.Trim().ToLower();
                gridChiPhi.DataSource = dsChiPhi.Where(pn => pn.MaPhieuNhap.ToString().Contains(query)).ToList();
            }
            catch
            {
                gridChiPhi.DataSource = dsChiPhi;
                return;
            }
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {
            tabControlBaoCao.SelectedIndex = 0;
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {
            tabControlBaoCao.SelectedIndex = 1;
        }
    }
}
