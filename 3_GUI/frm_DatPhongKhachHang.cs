using _1_DAL.Entities;
using _2_BUS.BUS_MatHang_Service;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_MatHang_Service;
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
    public partial class frm_DatPhongKhachHang : Form
    {
        private IBUS_MatHang_Service _matHangService;
        private IBUS_DonViTinh_Service _donViTinhService;
        private IBUS_HoaDonBanHang_Service _ihoaDonBanHang_Service;
        private IBUS_ChiTietHoaDonBan_Service _chiTietHoaDonBanService;
        private IBUS_KhachHang_Service _ikhachHang_Service;
        private IBUS_NhanVien_Service _inhanVien_Service;
        private IBUS_Phong_Service _phong_Service;
        private IBUS_LoaiPhong_Service _loaiphong_Service;
        private HoaDonBanHang _hoaDonBanHang;
        public frm_DatPhongKhachHang(string idPhong)
        {
            InitializeComponent();
            tbx_idPhong.Text = idPhong;
            _matHangService = new BUS_MatHang_Service();
            _donViTinhService = new BUS_DonViTinh_Service();
            _ihoaDonBanHang_Service = new BUS_HoaDonBanHang_Service();
            _chiTietHoaDonBanService = new BUS_ChiTietHoaDonBan_Service();
            _ikhachHang_Service = new BUS_KhachHang_Service();
            _inhanVien_Service = new BUS_NhanVien_Service();
            _phong_Service = new BUS_Phong_Service();
            _loaiphong_Service = new BUS_LoaiPhong_Service();
            _hoaDonBanHang = new HoaDonBanHang();
        }

        private void frm_DatPhongKhachHang_Load(object sender, EventArgs e)
        {
            loadtenPhong();
            loadcbxkhachhang();
            loadcbxCongThucTinh();
        }
        private bool checkForm()
        {
            if (tbx_idPhong.Text == null  && cbx_khachhang.Text == null )
            {
                MessageBox.Show("Bạn phải điền đầy đủ khách hàng , nhân viên, phòng , công thức tính ");
                return true;
            }
            return false;

        }
        private void loadtenPhong()
        {
            lbl_tenPhong.Text = "Tên Phòng :" + _phong_Service.sendlstPhong().FirstOrDefault(x => x.Id == Convert.ToInt32(tbx_idPhong.Text)).TenPhong;
            lbl_giaPhong.Text = "Đơn giá";
        }
        private void loadcbxkhachhang()
        {
            foreach (var x in _ikhachHang_Service.GetlstKhachHangs())
            {
                cbx_khachhang.Items.Add(x.MaKh);
            }
        }


        private void loadcbxCongThucTinh()
        {
            //foreach (var x in .GetlstNhanViens())
            //{
            //    cbx_nhanvien.Items.Add(x.Ho + x.TenDem + x.Ten);
            //}
        }
        private void btn_themHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (checkForm()) return;
                if (_ihoaDonBanHang_Service.sendlstHoaDonBanHang().Count == 0)
                {
                    _hoaDonBanHang.IdhoaDon = 1;
                }
                else 
                { 
                    _hoaDonBanHang.IdhoaDon = _ihoaDonBanHang_Service.sendlstHoaDonBanHang().Max(x => x.IdhoaDon + 1);
                }

                
                _hoaDonBanHang.Idphong = Convert.ToInt32(tbx_idPhong.Text);
                _hoaDonBanHang.IdmaKh = cbx_khachhang.Text;/*_ikhachHang_Service.GetlstKhachHangs().FirstOrDefault(x => x.MaKh == cmb_loaiPhong.Text).Id;*/
                //_hoaDonBanHang.IdmaNv = cbx_nhanvien.Text;
                _hoaDonBanHang.IdcongThucTinh = /*Convert.ToInt32( cbx_congthucTinh.Text)*/1;
                _hoaDonBanHang.ThoiGianBatDau = DateTime.Now;
                _hoaDonBanHang.DonGiaPhong = _loaiphong_Service.sendlstLoaiPhong().FirstOrDefault(x => x.Id == _phong_Service.sendlstPhong().FirstOrDefault(x => x.Id == _hoaDonBanHang.Idphong).IdloaiPhong).DonGia;
                //_hoaDonBanHang.NguoiTao = "Admin";
                //_hoaDonBanHang.NgayTao = DateTime.Now;
                //_hoaDonBanHang.NguoiCapNhap = "Admin";
                //_hoaDonBanHang.NgayCapNhap = DateTime.Now;
                _hoaDonBanHang.IdtranngThai = 1;
                MessageBox.Show(_ihoaDonBanHang_Service.Add(_hoaDonBanHang).ToString());
                tbx_tgianBĐ.Text = _hoaDonBanHang.ThoiGianBatDau.ToString();
                lbl_giaPhong.Text = "Đơn giá :" + _hoaDonBanHang.DonGiaPhong;
                tbx_idHoaĐon.Text = _hoaDonBanHang.IdhoaDon.ToString();
                btn_themHoaDon.Enabled = false;

                var phong = _phong_Service.Find(Convert.ToInt32(tbx_idPhong.Text)).FirstOrDefault();
                phong.TrangThai = 3;
                _phong_Service.Update(phong);

                MessageBox.Show("Đặt phòng thành công","Thông báo");
                this.Close();
                Frm_Main.load();
            }
        }

        private void btn_themKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                frm_KhachHang frm_KhachHang = new frm_KhachHang();
                //frm_Login.MdiParent = this.MdiParent;
                frm_KhachHang.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        
    }
}
