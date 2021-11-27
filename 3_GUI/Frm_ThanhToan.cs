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
        private IBUS_HoaDonBanHang_Service _ihoaDonBanHang_Service;
        private IBUS_ChiTietHoaDonBan_Service _chiTietHoaDonBanService;
        private IBUS_KhachHang_Service _ikhachHang_Service;
        private IBUS_NhanVien_Service _inhanVien_Service;
        private IBUS_Phong_Service _phong_Service;
        private IBUS_LoaiPhong_Service _loaiphong_Service;
        private List<MatHang> _dataMatHangs;
        private HoaDonBanHang _hoaDonBanHang;
        public Frm_ThanhToan(string idPhong)
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
            _dataMatHangs = new List<MatHang>();
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            loaddichvu();
            loadcbxNhanVien();
            loadtenPhong();
            getdata("");
        }
        private bool checkForm()
        {
            if (tbx_idPhong.Text == null && cbx_congthucTinh.Text == null && cbx_khachhang.Text == null && cbx_nhanvien.Text == null)
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
        //private void loadcbxkhachhang()
        //{
        //    foreach (var x in _ikhachHang_Service.sendlstLoaiPhong())
        //    {
        //        cbx_khachhang.Items.Add(x.TenLoaiPhong);
        //    }
        //}
        private void loadcbxNhanVien()
        {
            foreach (var x in _inhanVien_Service.GetlstNhanViens())
            {
                cbx_nhanvien.Items.Add(x.MaNv);
            }
        }
        //private void loadcbxCongThucTinh()
        //{
        //    foreach (var x in .GetlstNhanViens())
        //    {
        //        cbx_nhanvien.Items.Add(x.Ho + x.TenDem + x.Ten);
        //    }
        //}





        private void getdata(string tenMH)
        {
            _dataMatHangs = _matHangService.GetlstMatHangs().Where(c => c.TenMatHang.StartsWith(tenMH)).ToList();
            showdata();
        }

        void loadControl()
        {
            DataGridViewButtonColumn btnthem = new DataGridViewButtonColumn();
            btnthem.Name = "cl_btn_them";
            btnthem.HeaderText = "";
            btnthem.UseColumnTextForButtonValue = true;
            btnthem.Text = "Thêm";
        }
        private void showdata()
        {
            DataGridViewButtonColumn btnthem = new DataGridViewButtonColumn();
            btnthem.Name = "cl_btn_them";
            btnthem.HeaderText = "";
            btnthem.UseColumnTextForButtonValue = true;
            btnthem.Text = "Thêm";
            dgv_MatHang.Columns.Clear();
            var data =
                (from a in _dataMatHangs
                 select new
                 {
                     a.Id,
                     a.TenMatHang,
                     a.DonGia,
                 }).ToList();
            dgv_MatHang.DataSource = data;
            dgv_MatHang.Columns["Id"].Visible = false;
            dgv_MatHang.Columns.Add(btnthem);
        }

        private List<MatHang> _newlstmathang = new List<MatHang>();

        

        private void loaddichvu()
        {
            DataGridViewButtonColumn btnxoa = new DataGridViewButtonColumn();
            btnxoa.Name = "cl_btn_xoa";
            btnxoa.HeaderText = "";
            btnxoa.UseColumnTextForButtonValue = true;
            btnxoa.Text = "Xóa";
            dgv_chitietdichvu.Columns.Clear();
            var datanew = (from a in _chiTietHoaDonBanService.sendlstChiTietHoaDonBan()
                           join b in _matHangService.GetlstMatHangs() on a.IdmatHang equals b.Id
                           select new
                           {
                               a.IdchiTietHoaDonBan,
                               b.TenMatHang,
                               a.DonGia,
                               a.SoLuong
                           }).ToList();
            dgv_chitietdichvu.DataSource = datanew;
            dgv_chitietdichvu.Columns["IdchiTietHoaDonBan"].Visible = false;
            dgv_chitietdichvu.Columns.Add(btnxoa);
        }
        private void adddichvu(DataGridViewRow x)
        {
            ChiTietHoaDonBan newChiTietHoaDonBan = new ChiTietHoaDonBan();
            newChiTietHoaDonBan.IdhoaDon = 1;
            //if (_chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Count == 0)
            //{
            //    newChiTietHoaDonBan.IdchiTietHoaDonBan = 1;
            //}
            //else
            //{
            //    if (_chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Where(x => x.IdhoaDon == 1).Count() == 0)
            //    {
            //        newChiTietHoaDonBan.IdchiTietHoaDonBan =
            //            _chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Max(x => x.IdchiTietHoaDonBan) + 1;
            //    }

            //}
            newChiTietHoaDonBan.IdmatHang = int.Parse(r.Cells["Id"].Value.ToString());
            newChiTietHoaDonBan.DonGia = int.Parse(r.Cells["DonGia"].Value.ToString());
            _chiTietHoaDonBanService.Add(newChiTietHoaDonBan);
            loaddichvu();
        }
        private void removedichvu(DataGridViewRow x)
        {
            //newChiTietHoaDonBan.IdhoaDon = 1;
            //newChiTietHoaDonBan.IdmatHang = int.Parse(r.Cells["Id"].Value.ToString());
            _chiTietHoaDonBanService.Remove(int.Parse(r.Cells["IdchiTietHoaDonBan"].Value.ToString()));
            loaddichvu();
        }
        private DataGridViewRow r;
        private DataGridViewColumn c;
        private void dgv_MatHang_Click(object sender, EventArgs e)
        {
            //textBox1.Text = dgv_MatHang.CurrentCell.Value.ToString();
        }



        private void btn_thoat_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.Hide();
            //    frm_datphong frm_Main = new frm_datphong();

            //    frm_Main.Show();
            //}
            //catch
            //{
            //    Console.WriteLine("Error");
            //}
            //Button btn_new = new Button();
            //btn_new.Name = "btn_new";
            //btn_new.Text = "thêm";
            //btn_new.Size = new Size(150, 150);
            //panel1.Controls.Add(btn_new);
            _chiTietHoaDonBanService.Save();
            try
            {

                string idHoaDon11 = tbx_idHoaĐon.Text;//Khởi tạo và gán biến title
                string khachHang11 = cbx_khachhang.Text;//Khởi tạo và gán biến title
                string tgianBD = tbx_tgianBĐ.Text;
                string idPhong11 = tbx_idPhong.Text;
                if (idHoaDon11 == null )
                {
                    this.Hide();
                    frm_datphong frm_datphong1 = new frm_datphong(idHoaDon11/*,khachHang11,tgianBD*/,idPhong11);
                    //truyền text idhoasdon sang from main , nếu text == null thì kh load lại form main
                    //frm_datphong1.Show();
                }
                this.Hide();
                frm_datphong frm_datphong = new frm_datphong();
                //truyền text idhoasdon sang from main , nếu text == null thì kh load lại form main
                //frm_datphong.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgv_MatHang.Rows[e.RowIndex];
            if (e.ColumnIndex == 3)
            {
                adddichvu(r);
            }
        }

        private void dgv_chitietdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgv_chitietdichvu.Rows[e.RowIndex];
            if (e.ColumnIndex == 4)
            {
                removedichvu(r);
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {  
            getdata(txt_search.Text);
        }

        private void btn_themHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (checkForm()) return;

                
                _hoaDonBanHang.IdhoaDon = _ihoaDonBanHang_Service.sendlstHoaDonBanHang().Max(x => x.IdhoaDon+ 1);
                _hoaDonBanHang.Idphong = Convert.ToInt32( tbx_idPhong.Text);
                //_hoaDonBanHang.IdmaKh = _ikhachHang_Service.se().FirstOrDefault(x => x.TenLoaiPhong == cmb_loaiPhong.Text).Id;
                _hoaDonBanHang.IdmaNv = cbx_nhanvien.Text;
                _hoaDonBanHang.IdcongThucTinh = /*Convert.ToInt32( cbx_congthucTinh.Text)*/1;
                _hoaDonBanHang.ThoiGianBatDau = DateTime.Now;
                _hoaDonBanHang.DonGiaPhong = _loaiphong_Service.sendlstLoaiPhong().FirstOrDefault(x=>x.Id == _phong_Service.sendlstPhong().FirstOrDefault(x => x.Id == _hoaDonBanHang.Idphong).IdloaiPhong).DonGia;
                //_hoaDonBanHang.NguoiTao = "Admin";
                //_hoaDonBanHang.NgayTao = DateTime.Now;
                //_hoaDonBanHang.NguoiCapNhap = "Admin";
                //_hoaDonBanHang.NgayCapNhap = DateTime.Now;
                _hoaDonBanHang.IdtranngThai = 1;
                MessageBox.Show(_ihoaDonBanHang_Service.Add(_hoaDonBanHang).ToString());
                tbx_tgianBĐ.Text = _hoaDonBanHang.ThoiGianBatDau.ToString();
                lbl_giaPhong.Text = "Đơn giá :" + _hoaDonBanHang.DonGiaPhong;
                tbx_idHoaĐon.Text = _hoaDonBanHang.IdhoaDon.ToString();


                var phong = _phong_Service.Find(Convert.ToInt32( tbx_idPhong.Text)).FirstOrDefault();
                phong.IdtranngThai = 3.ToString();
                _phong_Service.Update(phong);



            }
        }

        private void btn_thanhToanHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                //hóa đơn lúc thanh toán kết thúc thời gian dùng , đổi trạng thái id về thanh toán và đổi tt phòng thành trống          
                _hoaDonBanHang.ThoiGianKetThuc = DateTime.Now;
                _hoaDonBanHang.IdtranngThai = 2;
                MessageBox.Show(_ihoaDonBanHang_Service.Add(_hoaDonBanHang).ToString());

                var phong = _phong_Service.Find(Convert.ToInt32(tbx_idPhong.Text)).FirstOrDefault();
                phong.IdtranngThai = 1.ToString();
                _phong_Service.Update(phong);
            }
        }
    }
}
