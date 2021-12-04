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
using _3_GUI_PresentationLayer;

namespace _3_GUI
{
    public partial class Frm_Main : Form
    {
        private IBUS_NhanVien_Service _nhanVienService;
        private NhanVien _nhanVien;
        public Frm_Main()
        {
            InitializeComponent();
            load();
            IsMdiContainer = true;
        }
        public Frm_Main(string username)
        {
            _nhanVienService = new BUS_NhanVien_Service();
            _nhanVien = new NhanVien();
            _nhanVien = _nhanVienService.GetlstNhanViens().Where(c => c.Username == username).SingleOrDefault();
            InitializeComponent();
            load();
            IsMdiContainer = true;
        }

        public static void load()
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
            frm_menuDanhMuc frmMenuDanhMuc = new frm_menuDanhMuc(_nhanVien.MaNv);
            frmMenuDanhMuc.TopLevel = false;
            loadform.Controls.Add(frmMenuDanhMuc);
            frmMenuDanhMuc.FormBorderStyle = FormBorderStyle.None;
            frmMenuDanhMuc.Dock = DockStyle.Fill;
            frmMenuDanhMuc.Show();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
            frm_thongke frmThongke = new frm_thongke();
            frmThongke.TopLevel = false;
            loadform.Controls.Add(frmThongke);
            frmThongke.FormBorderStyle = FormBorderStyle.None;
            frmThongke.Dock = DockStyle.Fill;
            frmThongke.Show();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_Login frmlogin = new frm_Login();
            this.Hide();
            frmlogin.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure", "cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public static void loadthanhtoan(int idPhongCapNhapPhong)
        {
            loadform.Controls.Clear();
            Frm_ThanhToan frmThanhToan = new Frm_ThanhToan(idPhongCapNhapPhong);
            frmThanhToan.TopLevel = false;
            loadform.Controls.Add(frmThanhToan);
            frmThanhToan.FormBorderStyle = FormBorderStyle.None;
            frmThanhToan.Dock = DockStyle.Fill;
            frmThanhToan.Show();
        }
    }
}
