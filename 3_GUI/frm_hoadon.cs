using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_DAL.Entities;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_Service;

namespace _3_GUI
{
    public partial class frm_hoadon : Form
    {
        private IBUS_ChiTietHoaDonBan_Service _chiTietHoaDonBanService;
        private IBUS_MatHang_Service _matHangService;
        private IBUS_Phong_Service _phongService;
        private HoaDonBanHang _hoadon;
        private double _tongtien;
        public frm_hoadon(HoaDonBanHang hoaDonBanHang,double tienthanhtoan)
        {
            InitializeComponent();
            _hoadon = hoaDonBanHang;
            _tongtien = tienthanhtoan;
            _chiTietHoaDonBanService = new BUS_ChiTietHoaDonBan_Service();
            _matHangService = new BUS_MatHang_Service();
            _phongService = new BUS_Phong_Service();
            loaddata();
            load();
        }

        void load()
        {
            lb_phong.Text = _phongService.sendlstPhong().SingleOrDefault(c => c.Id == _hoadon.Idphong).TenPhong;
            lb_tienDV.Text = tienDV().ToString()+" VND.";
            lb_tienphong.Text = _hoadon.DonGiaPhong.ToString()+" VND.";
            lb_tong.Text = _tongtien.ToString();
        }

        double tienDV()
        {
            double C = 0;
            foreach (var x in _chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Where(x => x.IdhoaDon == _hoadon.IdhoaDon))
            {
                C += x.DonGia.Value * x.SoLuong.Value;
            }
            return C;
        }
        void loaddata()
        {
            var data = (from a in _chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Where(c => c.IdhoaDon == _hoadon.IdhoaDon)
                join b in _matHangService.GetlstMatHangs() on a.IdmatHang equals b.Id
                select new
                {
                    b.TenMatHang,
                    a.SoLuong,
                    a.DonGia
                }).ToList();
            dataGridView1.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
