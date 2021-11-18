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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            loadform.Controls.Clear();
            frm_datphong frmDatphong = new frm_datphong();
            frmDatphong.TopLevel = false;
            loadform.Controls.Add(frmDatphong);
            frmDatphong.FormBorderStyle = FormBorderStyle.None;
            frmDatphong.Dock = DockStyle.Fill;
            frmDatphong.Show();
        }
        private void btn_Hethong_Click_1(object sender, EventArgs e)
        {
            load();
        }

        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
            frm_menuDanhMuc frmMenuDanhMuc = new frm_menuDanhMuc();
            frmMenuDanhMuc.TopLevel = false;
            loadform.Controls.Add(frmMenuDanhMuc);
            frmMenuDanhMuc.FormBorderStyle = FormBorderStyle.None;
            frmMenuDanhMuc.Dock = DockStyle.Fill;
            frmMenuDanhMuc.Show();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
        }
    }
}
