using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_Service;
using _2_BUS.Model;

namespace _3_GUI
{
    public partial class frm_ThongKeDoanhThu : Form
    {
        public frm_ThongKeDoanhThu()
        {
            InitializeComponent();
            _MatHang_Service = new BUS_MatHang_Service();
            _Phong_Service = new BUS_Phong_Service();
            _HoaDonBanHang_Service = new BUS_HoaDonBanHang_Service();
        }
        private IBUS_MatHang_Service _MatHang_Service;
        private IBUS_Phong_Service _Phong_Service;
        private IBUS_HoaDonBanHang_Service _HoaDonBanHang_Service;
        private void rbt_mathang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_mathang.Checked)
            {
                comboBox1.DataSource = _MatHang_Service.GetlstMatHangs();
                comboBox1.DisplayMember = "TenMatHang";
                comboBox1.ValueMember = "ID";
            }          
        }
        private void rbt_phong_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_phong.Checked)
            {
                comboBox1.DataSource = _Phong_Service.sendlstPhong();
                comboBox1.DisplayMember = "TenPhong";
                comboBox1.ValueMember = "ID";
            }
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if (rbt_mathang.Checked)
            {
                TKMatHang();
                return;
            }
            if (rbt_phong.Checked)
            {
                TKPhong();
                return;
            }
        }

        private void TKPhong()
        {
            var data = (from a in _HoaDonBanHang_Service.sendlstHoaDonBanHang()
                        join b in _Phong_Service.sendlstPhong() on a.Idphong equals b.Id
                        select new
                        {
                            Phong = b.TenPhong,
                            DonGia = a.DonGiaPhong,
                            ThoiGian = new GoodPhong(((DateTime)a.ThoiGianKetThuc - (DateTime)a.ThoiGianBatDau).TotalMinutes).ToString(),
                            Tong = ((DateTime)a.ThoiGianKetThuc - (DateTime)a.ThoiGianBatDau).TotalHours * a.DonGiaPhong
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        private void TKMatHang()
        {
            
        }
    }
}
