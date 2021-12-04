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
        public Frm_ThanhToan(int idphong)
        {
            InitializeComponent();
            _matHangService = new BUS_MatHang_Service();
            _donViTinhService = new BUS_DonViTinh_Service();
            _ihoaDonBanHang_Service = new BUS_HoaDonBanHang_Service();
            _chiTietHoaDonBanService = new BUS_ChiTietHoaDonBan_Service();
            _ikhachHang_Service = new BUS_KhachHang_Service();
            _inhanVien_Service = new BUS_NhanVien_Service();
            _phong_Service = new BUS_Phong_Service();
            _loaiphong_Service = new BUS_LoaiPhong_Service();
            _dataMatHangs = new List<MatHang>();
            _hoaDonBanHang = new HoaDonBanHang();
            _hoaDonBanHang = _ihoaDonBanHang_Service.sendlstHoaDonBanHang().Where(x => x.IdtranngThai == 1 && x.Idphong == idphong).SingleOrDefault();
            txt_chiphikhac.Text = "0";
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            loaddichvu();
            getdata("");
            loadtien();
        }

        private void loadtien()
        {
            txt_tongtien.Text = null;
            lbl_tenPhong.Text = _phong_Service.sendlstPhong().Where(x => x.Id == _hoaDonBanHang.Idphong).SingleOrDefault().TenPhong.ToString();
            txt_tienphong.Text = _loaiphong_Service.sendlstLoaiPhong()
                .Where(x => x.Id == _phong_Service.sendlstPhong()
                    .SingleOrDefault(x => x.Id == _hoaDonBanHang.Idphong).IdloaiPhong).SingleOrDefault().DonGia
                .ToString();
            txt_tiendv.Text = tinhtiendv().ToString();
        }

        double tinhtiendv()
        {
            double C = 0;
            foreach (var x in _chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Where(x => x.IdhoaDon == _hoaDonBanHang.IdhoaDon))
            {
                C += x.DonGia.Value * x.SoLuong.Value;
            }
            return C;

        }
        private void getdata(string tenMH)
        {
            _dataMatHangs = _matHangService.GetlstMatHangs().Where(c => c.TenMatHang.StartsWith(tenMH)).ToList();
            showdata();
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
            loadtien();
            DataGridViewButtonColumn btnxoa = new DataGridViewButtonColumn();
            btnxoa.Name = "cl_btn_xoa";
            btnxoa.HeaderText = "";
            btnxoa.UseColumnTextForButtonValue = true;
            btnxoa.Text = "Xóa";
            dgv_chitietdichvu.Columns.Clear();
            var datanew = (from a in _chiTietHoaDonBanService.sendlstChiTietHoaDonBan().Where(x => x.IdhoaDon == _hoaDonBanHang.IdhoaDon)
                           join b in _matHangService.GetlstMatHangs() on a.IdmatHang equals b.Id
                           select new
                           {
                               a.IdchiTietHoaDonBan,
                               b.Id,
                               b.TenMatHang,
                               a.DonGia,
                               a.SoLuong
                           }).ToList();
            dgv_chitietdichvu.DataSource = datanew;
            dgv_chitietdichvu.Columns["Id"].Visible = false;
            dgv_chitietdichvu.Columns["IdchiTietHoaDonBan"].Visible = false;
            dgv_chitietdichvu.Columns.Add(btnxoa);

        }
        private void adddichvu(DataGridViewRow x)
        {
            ChiTietHoaDonBan newChiTietHoaDonBan = new ChiTietHoaDonBan();
            newChiTietHoaDonBan.IdhoaDon = _hoaDonBanHang.IdhoaDon;
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
            Frm_Main.load();
            this.Close();

        }

        private void dgv_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgv_MatHang.Rows[e.RowIndex];
            if (e.ColumnIndex != 2&&e.ColumnIndex != 3)
            {
                adddichvu(r);
            }
        }

        private void dgv_chitietdichvu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            r = dgv_chitietdichvu.Rows[e.RowIndex];
            if (e.ColumnIndex != 4&& e.ColumnIndex != 3&& e.ColumnIndex != 2)
            {
                removedichvu(r);
            }
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            getdata(txt_search.Text);
        }



        private void btn_fakethanhtoan_Click(object sender, EventArgs e)
        {
            double tientheogio = (DateTime.Now.Hour - _hoaDonBanHang.ThoiGianBatDau.Value.Hour + 1) * 70000;
            txt_tongtien.Text = (double.Parse(txt_tienphong.Text) + double.Parse(txt_tiendv.Text) + tientheogio +double.Parse(txt_chiphikhac.Text)).ToString();
        }

        private void btn_thanhToanHoaDon_Click(object sender, EventArgs e)
        {
            _hoaDonBanHang.IdtranngThai = 2;
            _ihoaDonBanHang_Service.Update(_hoaDonBanHang);
            var phong = _phong_Service.sendlstPhong().Where(x => x.Id == _hoaDonBanHang.Idphong).SingleOrDefault();
            phong.TrangThai = 4;
            _phong_Service.Update(phong);
            MessageBox.Show("thanh toán thành công", "thông báo", MessageBoxButtons.OK);
            Frm_Main.load();
        }
        void loadcongthuctinh()
        {

        }
    }
}
