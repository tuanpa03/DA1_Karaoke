using _1_DAL.DBContext;
using _1_DAL.Entities;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_MatHang_Service;
using _2_BUS.IBUS_Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class frm_ThongKeMatHang : Form
    {
        public frm_ThongKeMatHang()
        {
            InitializeComponent();
            _ChiTietHoaDonBan_Service = new BUS_ChiTietHoaDonBan_Service();
            _MatHang_Service = new BUS_MatHang_Service();           
            LoadData();
        }
        private IBUS_ChiTietHoaDonBan_Service _ChiTietHoaDonBan_Service;
        private IBUS_MatHang_Service _MatHang_Service;
        private void LoadData()
        {
            try
            {
                var data =
                (from a in _MatHang_Service.GetlstMatHangs()
                 join b in _ChiTietHoaDonBan_Service.sendlstChiTietHoaDonBan() on a.Id equals b.IdmatHang
                 select new
                 {
                     a.Id,
                     a.TenMatHang,
                     b.DonGia,
                     b.SoLuong
                 }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }           
        }      
        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
        private void TimKiem()
        {
            var data = (from a in _MatHang_Service.GetlstMatHangs()
                        from b in _ChiTietHoaDonBan_Service.sendlstChiTietHoaDonBan()
                        where a.Id.Equals(b.IdmatHang)
                        && a.TenMatHang.Equals(txt_timkiem.Text)
                        select new
                        {
                            a.Id,
                            a.TenMatHang,
                            b.DonGia,
                            b.SoLuong
                        }).ToList();
            dataGridView1.DataSource = data;
        }
    }
}