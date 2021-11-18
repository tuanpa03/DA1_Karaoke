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
    public partial class frm_Login : Form
    {
        private IBUS_Login_Service _ibus_Login_Service;
        public frm_Login()
        {
            _ibus_Login_Service = new BUS_Login_Service();
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DialogResult dn;
            string username = txt_DangNhap.Text;
            string passwork = _ibus_Login_Service.MaHoaPass(txt_Passwork.Text);
            if (_ibus_Login_Service.NhanVienLogin(username, passwork))
            {
                frm_Main main = new frm_Main();
                dn = MessageBox.Show("Đăng nhập thành công 🤗🤗🤗", "Thông Báo ❗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                main.Show();
                this.Hide();
            }
            else
            {
                dn = MessageBox.Show("Đăng nhập thất bại 🤨🤨🤨 ! \nVui lòng kiểm tra lại Email hoặc mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn 🤔 Thoát form LOGIN 🤔 ra khỏi chương trình không ?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void lbl_QuenMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
