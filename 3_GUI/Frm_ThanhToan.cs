using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUS_MatHang_Service;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_MatHang_Service;
using _2_BUS.IBUS_Service;
using _3_GUI;

namespace _3_GUI_PresentationLayer
{
    public partial class Frm_ThanhToan : Form
    {
        private IBUS_MatHang_Service _matHangService;
        private IBUS_DonViTinh_Service _donViTinhService;
        public Frm_ThanhToan(string idPhong)
        {
            InitializeComponent();
            tbx_idPhong.Text = idPhong;
            _matHangService = new BUS_MatHang_Service();
            _donViTinhService = new BUS_DonViTinh_Service();
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void showdata()
        {
            var data =
                (from a in _matHangService.GetlstMatHangs()
                    join b in _donViTinhService.GetlstDonViTinhs()
                        on a.IddonViTinh equals b.Id
                    select new
                    {
                        a.Id,
                        a.TenMatHang,
                        a.DonGia,
                        b.TenDvt,
                    }).ToList();
            dgv_MatHang.DataSource = data;
        }

        private DataGridViewRow r;
        private DataGridViewColumn c;
        private void dgv_MatHang_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dgv_MatHang.CurrentCell.Value.ToString();
        }

        

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frm_Main frm_Main = new frm_Main();

                frm_Main.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
