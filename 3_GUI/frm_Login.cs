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
            InitializeComponent();
            _ibus_Login_Service = new BUS_Login_Service();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            DialogResult dn;
            string username = txt_DangNhap.Text;
            string passwork = _ibus_Login_Service.MaHoaPass(txt_Passwork.Text);
            if (_ibus_Login_Service.NhanVienLogin(username, passwork))
            {
                Frm_Main main = new Frm_Main();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (txt_Passwork.PasswordChar == '*' )
            {
                txt_Passwork.PasswordChar = '\0';
            }
            else
            {
                txt_Passwork.PasswordChar = '*';
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_QuenMatKhau quen = new frm_QuenMatKhau();
            this.Hide();
            quen.Show();
        }
    }
}
