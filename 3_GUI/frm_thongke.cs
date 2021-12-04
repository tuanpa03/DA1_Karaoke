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
    public partial class frm_thongke : Form
    {
        public frm_thongke()
        {
            InitializeComponent();
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            pl_load.Controls.Clear();
            frm_ThongKeMatHang frmThongKeMatHang = new frm_ThongKeMatHang();
            frmThongKeMatHang.TopLevel = false;
            pl_load.Controls.Add(frmThongKeMatHang);
            frmThongKeMatHang.FormBorderStyle = FormBorderStyle.None;
            frmThongKeMatHang.Dock = DockStyle.Fill;
            frmThongKeMatHang.Show();
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            pl_load.Controls.Clear();
            frm_ThongKeThietBi frmThongKeThietBi = new frm_ThongKeThietBi();
            frmThongKeThietBi.TopLevel = false;
            pl_load.Controls.Add(frmThongKeThietBi);
            frmThongKeThietBi.FormBorderStyle = FormBorderStyle.None;
            frmThongKeThietBi.Dock = DockStyle.Fill;
            frmThongKeThietBi.Show();
        }
    }
}
