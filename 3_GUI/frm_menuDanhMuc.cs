using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _3_GUI_PresentationLayer;

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
            buttomcolor();
            btn_Phong.BackColor = SystemColors.HotTrack;
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
            buttomcolor();
            btn_Nhanvien.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_NhanVien frmNhanVien = new frm_NhanVien();
            frmNhanVien.TopLevel = false;
            loadform.Controls.Add(frmNhanVien);
            frmNhanVien.FormBorderStyle = FormBorderStyle.None;
            frmNhanVien.Dock = DockStyle.Fill;
            frmNhanVien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttomcolor();
            button3.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_QLMatHang frmQlMatHang = new frm_QLMatHang();
            frmQlMatHang.TopLevel = false;
            loadform.Controls.Add(frmQlMatHang);
            frmQlMatHang.FormBorderStyle = FormBorderStyle.None;
            frmQlMatHang.Dock = DockStyle.Fill;
            frmQlMatHang.Show();
        }

        private void btn_thietbi_Click(object sender, EventArgs e)
        {
            buttomcolor();
            btn_thietbi.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_ThietBi frmThietBi = new frm_ThietBi();
            frmThietBi.TopLevel = false;
            loadform.Controls.Add(frmThietBi);
            frmThietBi.FormBorderStyle = FormBorderStyle.None;
            frmThietBi.Dock = DockStyle.Fill;
            frmThietBi.Show();
        }

        private void btn_nhacungcap_Click(object sender, EventArgs e)
        {
            buttomcolor();
            btn_nhacungcap.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_NhaCungCap frmNhaCungCap = new frm_NhaCungCap();
            frmNhaCungCap.TopLevel = false;
            loadform.Controls.Add(frmNhaCungCap);
            frmNhaCungCap.FormBorderStyle = FormBorderStyle.None;
            frmNhaCungCap.Dock = DockStyle.Fill;
            frmNhaCungCap.Show();
        }

        private void btn_loaithietbi_Click(object sender, EventArgs e)
        {
            buttomcolor();
            btn_loaithietbi.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_LoaiThietBi frmLoaiThietBi = new frm_LoaiThietBi();
            frmLoaiThietBi.TopLevel = false;
            loadform.Controls.Add(frmLoaiThietBi);
            frmLoaiThietBi.FormBorderStyle = FormBorderStyle.None;
            frmLoaiThietBi.Dock = DockStyle.Fill;
            frmLoaiThietBi.Show();
        }

        private void btn_dvt_Click(object sender, EventArgs e)
        {
            buttomcolor();
            btn_dvt.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_DonViTinh frmDonViTinh = new frm_DonViTinh();
            frmDonViTinh.TopLevel = false;
            loadform.Controls.Add(frmDonViTinh);
            frmDonViTinh.FormBorderStyle = FormBorderStyle.None;
            frmDonViTinh.Dock = DockStyle.Fill;
            frmDonViTinh.Show();
        }

        private void btn_loaiphong_Click(object sender, EventArgs e)
        {
            buttomcolor();
            btn_loaiphong.BackColor = SystemColors.HotTrack;
            loadform.Controls.Clear();
            frm_LoaiPhong frmLoaiPhong = new frm_LoaiPhong();
            frmLoaiPhong.TopLevel = false;
            loadform.Controls.Add(frmLoaiPhong);
            frmLoaiPhong.FormBorderStyle = FormBorderStyle.None;
            frmLoaiPhong.Dock = DockStyle.Fill;
            frmLoaiPhong.Show();
        }

        void buttomcolor()
        {
            panel1.BackColor = SystemColors.HotTrack;
            btn_Phong.BackColor = SystemColors.MenuHighlight;
            btn_Nhanvien.BackColor = SystemColors.MenuHighlight;
            button3.BackColor = SystemColors.MenuHighlight;
            btn_thietbi.BackColor = SystemColors.MenuHighlight;
            btn_nhacungcap.BackColor = SystemColors.MenuHighlight;
            btn_loaithietbi.BackColor = SystemColors.MenuHighlight;
            btn_dvt.BackColor = SystemColors.MenuHighlight;
            btn_loaiphong.BackColor = SystemColors.MenuHighlight;
        }
    }
}
