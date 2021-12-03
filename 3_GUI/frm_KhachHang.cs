using _1_DAL.Entities;
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
    public partial class frm_KhachHang : Form
    {
        private IBUS_KhachHang_Service _ibusKhachHang;
        private KhachHang _tblKhachHang;
        private IBUS_CheckEverything _icheck;
        private string erorr = "CHÚ Ý 🤔🤔🤔";
        int x = 20, y = 9, a = 1;
        Random ran = new Random();
        public frm_KhachHang()
        {
            InitializeComponent();
            _ibusKhachHang = new BUS_KhachHang_Service();
            _tblKhachHang = new KhachHang();
            _icheck = new BUS_CheckEverything();
        }
        void LoadDataKhachHang()
        {
            dgr_KhachHang.ColumnCount = 5;
            dgr_KhachHang.Columns[0].Name = "Mã KH";
            dgr_KhachHang.Columns[1].Name = "Họ tên";
            dgr_KhachHang.Columns[2].Name = "Giới Tính";
            dgr_KhachHang.Columns[3].Name = "Điện thoại";
            dgr_KhachHang.Columns[4].Name = "IDTrangThai";
            dgr_KhachHang.Rows.Clear();
            foreach (var x in _ibusKhachHang.GetlstKhachHangs())
            {
                dgr_KhachHang.Rows.Add(x.MaKh, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh == 1 ? "Nam" : "Nữ",
                    x.DienThoai, x.IdtranngThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        void FindNameKhachHang(string tenkh)
        {
            dgr_KhachHang.ColumnCount = 5;
            dgr_KhachHang.Columns[0].Name = "Mã KH";
            dgr_KhachHang.Columns[1].Name = "Họ tên";
            dgr_KhachHang.Columns[2].Name = "Giới Tính";
            dgr_KhachHang.Columns[3].Name = "Điện thoại";
            dgr_KhachHang.Columns[4].Name = "IDTrangThai";
            dgr_KhachHang.Rows.Clear();
            foreach (var x in _ibusKhachHang.FindNameKhachHang(tenkh))
            {
                dgr_KhachHang.Rows.Add(x.MaKh, x.Ho + " " + x.TenDem + " " + x.Ten, x.GioiTinh == 1 ? "Nam" : "Nữ",
                    x.DienThoai, x.IdtranngThai == 1 ? "Hoạt động" : "Không hoạt động");
            }
        }
        public bool checkLoi()
        {
            DialogResult dn;
            if (_icheck.CheckNull(txt_MaKH.Text) || _icheck.CheckNull(txt_Ho.Text) || _icheck.CheckNull(txt_Ten.Text) ||
                _icheck.CheckNull(txt_TenDem.Text) || _icheck.CheckNull(txt_DienThoai.Text))
            {
                dn = MessageBox.Show("Dữ liệu đang để trống !!! \nVui lòng nhập lại 😉", erorr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_icheck.CheckSo(txt_DienThoai.Text))
            {
                dn = MessageBox.Show("Số điện thoại không được phép có chữ cái !!! \nVui lòng nhập lại 😉", erorr, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_DienThoai.Focus();
                return false;
            }
            return true;
        }

        private void dgr_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rd = e.RowIndex;
            if (rd == _ibusKhachHang.GetlstKhachHangs().Count() || rd == -1) return;
            _tblKhachHang = _ibusKhachHang.GetlstKhachHangs().FirstOrDefault(c => c.MaKh == dgr_KhachHang.Rows[rd].Cells[0].Value.ToString());

            txt_MaKH.Text = dgr_KhachHang.Rows[rd].Cells[0].Value.ToString();
            txt_Ho.Text = _tblKhachHang.Ho;
            txt_TenDem.Text = _tblKhachHang.TenDem;
            txt_Ten.Text = _tblKhachHang.Ten;
            rbtn_Nam.Checked = dgr_KhachHang.Rows[rd].Cells[2].Value.ToString() == "Nam" ? true : false;
            rbtn_Nu.Checked = dgr_KhachHang.Rows[rd].Cells[2].Value.ToString() == "Nữ" ? true : false;
            txt_DienThoai.Text = dgr_KhachHang.Rows[rd].Cells[3].Value.ToString();
            cbx_HĐ.Checked = dgr_KhachHang.Rows[rd].Cells[4].Value.ToString() == "Hoạt động" ? true : false;
            cbx_KHĐ.Checked = dgr_KhachHang.Rows[rd].Cells[4].Value.ToString() == "Không hoạt động" ? true : false;
        }
        private void Clearform()
        {
            txt_MaKH.Text = "";
            txt_Ho.Text = "";
            txt_TenDem.Text = "";
            txt_Ten.Text = "";
            rbtn_Nam.Checked = false;
            rbtn_Nu.Checked = false;
            txt_DienThoai.Text = "";
            cbx_HĐ.Checked = false;
            cbx_KHĐ.Checked = false;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (checkLoi() == false)
            {
                return;
            }
            KhachHang kha = new KhachHang();
            kha.MaKh = txt_MaKH.Text;
            kha.Ho = txt_Ho.Text;
            kha.TenDem = txt_TenDem.Text;
            kha.Ten = txt_Ten.Text;
            kha.GioiTinh = rbtn_Nam.Checked ? 1 : 0;
            kha.DienThoai = txt_DienThoai.Text;
            kha.IdtranngThai = cbx_HĐ.Checked ? 1 : 0;
            if (MessageBox.Show("Bạn có muốn 🤔 Thêm Khách Hàng 🤔 không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ibusKhachHang.Add(kha);
                MessageBox.Show("Thêm thành công 😉😉😉!", "Thông báo 😁😁😁");
            }
            LoadDataKhachHang();
            Clearform();
        }
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (checkLoi() == false)
            {
                return;
            }
            _tblKhachHang.MaKh = txt_MaKH.Text;
            _tblKhachHang.Ho = txt_Ho.Text;
            _tblKhachHang.TenDem = txt_TenDem.Text;
            _tblKhachHang.Ten = txt_Ten.Text;
            _tblKhachHang.GioiTinh = rbtn_Nam.Checked ? 1 : 0;
            _tblKhachHang.GioiTinh = rbtn_Nu.Checked ? 1 : 0;
            _tblKhachHang.DienThoai = txt_DienThoai.Text;
            _tblKhachHang.IdtranngThai = cbx_HĐ.Checked ? 1 : 0;
            _tblKhachHang.IdtranngThai = cbx_KHĐ.Checked ? 1 : 0;
            if (MessageBox.Show("Bạn có muốn 🤔 Sửa Khách Hàng 🤔 này không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ibusKhachHang.Update(_tblKhachHang);
                MessageBox.Show("Sửa thành công 😉😉😉!", "Thông báo 😁😁😁");
            }
            LoadDataKhachHang();
            Clearform();
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn 🤔 Xóa Khách Hàng 🤔 này không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ibusKhachHang.Remove(_tblKhachHang);
                MessageBox.Show("Xóa thành công 😉😉😉!", "Thông báo 😁😁😁");
            }
            LoadDataKhachHang();
            Clearform();
        }
        private void btn_DanhSachKH_Click(object sender, EventArgs e)
        {
            LoadDataKhachHang();
        }
        private void btn_LuuKH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn 🤔 Lưu Khách Hàng 🤔 này không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _ibusKhachHang.Save(_tblKhachHang);
                MessageBox.Show("Lưu thành công 😉😉😉!", "Thông báo 😁😁😁");
            }
            LoadDataKhachHang();
            Clearform();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            FindNameKhachHang(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbl_Timer.Location = new Point(x, y);
                if (x >= 704)
                {
                    a = -1;
                    lbl_Timer.ForeColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                }
                if (x <= 20)
                {
                    a = 1;
                    lbl_Timer.ForeColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
