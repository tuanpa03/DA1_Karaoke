using _2_BUS.BUS_Service;
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
    public partial class frm_ThongKeThietBi : Form
    {
        public frm_ThongKeThietBi()
        {
            InitializeComponent();           
            _ThietBi_Service = new BUS_ThietBi_Service();
            _LoaiThietBi_Service = new BUS_LoaiThietBi_Service();
            LoadData();
        }
        private IBUS_LoaiThietBi_Service _LoaiThietBi_Service;
        private IBUS_ThietBi_Service _ThietBi_Service;
        private void LoadData()
        {
            try
            {
                var data =
                (from a in _ThietBi_Service.GetlstThietBis()
                 join b in _LoaiThietBi_Service.GetlstLoaiThietBis() on a.IdmaLoaiTb equals b.MaLoaiTb
                 select new
                 {
                     a.MaTb,
                     a.TenTb,
                     b.TenLoai,
                     b.XuatXu,
                     a.SoLuong
                 }).ToList();
                dataGridView1.DataSource = data;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void TimKiem()
        {
            var data = (from a in _ThietBi_Service.GetlstThietBis()
                        from b in _LoaiThietBi_Service.GetlstLoaiThietBis()
                        where a.IdmaLoaiTb.Equals(b.MaLoaiTb)
                        && a.TenTb.Equals(txt_timkiem.Text)
                        select new
                        {
                            a.MaTb,
                            a.TenTb,
                            b.TenLoai,
                            b.XuatXu,
                            a.SoLuong
                        }).ToList();
            dataGridView1.DataSource = data;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
