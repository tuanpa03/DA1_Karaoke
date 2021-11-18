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
    public partial class frm_menuDanhMuc : Form
    {
        public frm_menuDanhMuc()
        {
            InitializeComponent();
        }

        private void btn_Phong_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
            frm_Phong frmPhong = new frm_Phong();
            frmPhong.TopLevel = false;
            loadform.Controls.Add(frmPhong);
            frmPhong.FormBorderStyle = FormBorderStyle.None;
            frmPhong.Dock = DockStyle.Fill;
            frmPhong.Show();
        }

        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
            frm_NhanVien frmNhanVien = new frm_NhanVien();
            frmNhanVien.TopLevel = false;
            loadform.Controls.Add(frmNhanVien);
            frmNhanVien.FormBorderStyle = FormBorderStyle.None;
            frmNhanVien.Dock = DockStyle.Fill;
            frmNhanVien.Show();
        }
    }
}
