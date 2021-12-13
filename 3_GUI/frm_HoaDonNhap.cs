using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_Service;

namespace _3_GUI
{
    public partial class frm_HoaDonNhap : Form
    {
        private IBUS_ChiTietHoaDonNhap_Service _chiTietHoaDonNhapService;
        private IBUS_HoaDonNhap_Service _hoaDonNhapService;
        private IBUS_RE_MatHang_Service _reMatHangService;
        private IBUS_NhaCungCap_Service _nhaCungCapService;
        private string _iDNhanVien;
        private int _iDHoaDon;
        private int _iDChiTietHoaDon;
        private int _idMatHang;
        private int _idChiTietHoaDonNhap;

        //tạo form không có tham số
        public frm_HoaDonNhap()
        {
            InitializeComponent();
            _chiTietHoaDonNhapService = new BUS_ChiTietHoaDonNhap_Service();
            _hoaDonNhapService = new BUS_HoaDonNhap_Service();
            _reMatHangService = new BUS_RE_MatHang_Service();
            _nhaCungCapService = new BUS_NhaCungCap_Service();
            _iDNhanVien = "admin";
            txt_TienThanhToan.Text = "0";
            gbx_ChiTietHoaDon.Enabled = false;
            gbx_NhaCungCap.Enabled = false;
            gbx_MatHang.Enabled = false;
            txt_MaHoaDon.Enabled = false;
            txt_TienThanhToan.Enabled = false;
            dtp_NgayTao.Enabled = false;
            FillDataNhaCungCapToCBX();
            FillDataHoaDontoGrid();
            FillDataMatHangToGrid();
        }

        //có tham số 
        public frm_HoaDonNhap(string maNhanVien)
        {
            InitializeComponent();
            _chiTietHoaDonNhapService = new BUS_ChiTietHoaDonNhap_Service();
            _hoaDonNhapService = new BUS_HoaDonNhap_Service();
            _reMatHangService = new BUS_RE_MatHang_Service();
            _nhaCungCapService = new BUS_NhaCungCap_Service();
            txt_TienThanhToan.Text = "0";
            gbx_ChiTietHoaDon.Enabled = false;
            gbx_NhaCungCap.Enabled = false;
            gbx_MatHang.Enabled = false;
            txt_MaHoaDon.Enabled = false;
            txt_TienThanhToan.Enabled = false;
            dtp_NgayTao.Enabled = false;
            FillDataNhaCungCapToCBX();
            FillDataHoaDontoGrid();
            FillDataMatHangToGrid();
        }

        public void FillDataNhaCungCapToCBX()
        {
            cbx_NhaCungCap.Items.Clear();
            foreach (var x in _nhaCungCapService.GetListnNhaCungCapsFromDAL())
            {
                cbx_NhaCungCap.Items.Add(x.Id);
            }

            cbx_NhaCungCap.SelectedIndex = 0;
        }

        public void FillDataChiTietHoaDon(int? idHoaDon)
        {
            dgrid_ChiTietHoaDonNhap.Columns.Clear();
            dgrid_ChiTietHoaDonNhap.ColumnCount = 5;
            dgrid_ChiTietHoaDonNhap.Columns[0].Name = "Mã chi tiết hóa đơn";
            dgrid_ChiTietHoaDonNhap.Columns[1].Name = "Mã hóa đơn";
            dgrid_ChiTietHoaDonNhap.Columns[2].Name = "Mã mặt hàng";
            dgrid_ChiTietHoaDonNhap.Columns[3].Name = "Số lượng";
            dgrid_ChiTietHoaDonNhap.Columns[4].Name = "Đơn giá";
            if (idHoaDon != null)
            {
                foreach (var x in _chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps().Where(c => c.IdhoaDon == _iDHoaDon))
                {
                    dgrid_ChiTietHoaDonNhap.Rows.Add(x.IdchiTietHoaDonNhap, x.IdhoaDon, x.IdmatHang, x.SoLuong,
                        x.DonGiaNhap);
                }
            }

            var btnXoa = new DataGridViewButtonColumn();
            btnXoa.Text = "Xóa";
            btnXoa.Name = "Xóa mặt hàng";
            btnXoa.UseColumnTextForButtonValue = true;
            dgrid_ChiTietHoaDonNhap.Columns.Add(btnXoa);
        }

        public void FillDataHoaDontoGrid()
        {
            dgrid_HoaDonNhap.Columns.Clear();
            dgrid_HoaDonNhap.ColumnCount = 7;
            dgrid_HoaDonNhap.Columns[0].Name = "Mã hóa đơn";
            dgrid_HoaDonNhap.Columns[1].Name = "Tiền thanh toán";
            dgrid_HoaDonNhap.Columns[2].Name = "Mã nhà cung cấp";
            dgrid_HoaDonNhap.Columns[3].Name = "Ngày tạo";
            dgrid_HoaDonNhap.Columns[4].Name = "Người tạo";
            dgrid_HoaDonNhap.Columns[5].Name = "Ngày cập nhật";
            dgrid_HoaDonNhap.Columns[6].Name = "Người cập nhật";
            dgrid_HoaDonNhap.Columns[2].Visible = false;
            foreach (var x in _hoaDonNhapService.GetListHoaDonNhaps())
            {
                dgrid_HoaDonNhap.Rows.Add(x.Id, x.TienThanhToan, x.IdnhaCc, x.NgayTao, x.NguoiTao, x.NgayCapNhap, x.NguoiCapNhap);
            }

            var btnCapNhat = new DataGridViewButtonColumn();
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.Name = "Update";
            btnCapNhat.UseColumnTextForButtonValue = true;
            dgrid_HoaDonNhap.Columns.Add(btnCapNhat);
        }

        public void FillDataMatHangToGrid()
        {
            dgrid_MatHang.Columns.Clear();
            dgrid_MatHang.ColumnCount = 4;
            dgrid_MatHang.Columns[0].Name = "Mã mặt hàng";
            dgrid_MatHang.Columns[1].Name = "Tên mặt hàng";
            dgrid_MatHang.Columns[2].Name = "Đơn giá";
            dgrid_MatHang.Columns[3].Name = "Số lượng hiện có";
            dgrid_MatHang.Columns[0].Visible = false;
            foreach (var x in _reMatHangService.GetListMatHangs())
            {
                dgrid_MatHang.Rows.Add(x.Id, x.TenMatHang, x.DonGia, x.SoLuong);
            }

            var btnThem = new DataGridViewButtonColumn();
            btnThem.Text = "Thêm";
            btnThem.Name = "Thêm vào hóa đơn";
            btnThem.UseColumnTextForButtonValue = true;
            dgrid_MatHang.Columns.Add(btnThem);
        }

        private void btn_AddHoaDon_Click(object sender, EventArgs e)
        {
            _hoaDonNhapService.AddHoaDonNhapTo(_iDNhanVien, null, Convert.ToInt64(txt_TienThanhToan.Text), _iDNhanVien,
                _iDNhanVien);
            var ngayHoaDonNhap = _hoaDonNhapService.GetListHoaDonNhaps().Max(c => c.NgayTao);
            if (_hoaDonNhapService != null)
                _iDHoaDon = _hoaDonNhapService.GetListHoaDonNhaps().FirstOrDefault(c => c.NgayTao == ngayHoaDonNhap).Id;
            gbx_ChiTietHoaDon.Enabled = true;
            gbx_HoaDon.Enabled = false;
            gbx_MatHang.Enabled = true;
            txt_MaHoaDon.Text = null;
            txt_TienThanhToan.Text = null;
            dgrid_ChiTietHoaDonNhap.Columns.Clear();
        }

        private void btn_AddNhaCungCap_Click(object sender, EventArgs e)
        {
            _nhaCungCapService.AddNhaCungCap(txt_TenNhaCungCap.Text, _iDNhanVien, _iDNhanVien, txt_SoDienThoai.Text,
                txt_Email.Text, txt_DiaChi.Text);
            FillDataNhaCungCapToCBX();
            chk_NhaCungCap.Checked = false;
            cbx_NhaCungCap.SelectedIndex = (_nhaCungCapService.GetListnNhaCungCapsFromDAL().Count) - 1;
        }

        private void cbx_NhaCungCap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var nhaCungCap = _nhaCungCapService.GetListnNhaCungCapsFromDAL()
                .FirstOrDefault(c => c.Id == Convert.ToInt32(cbx_NhaCungCap.SelectedItem.ToString()));
            if (nhaCungCap != null)
            {
                txt_TenNhaCungCap.Text = nhaCungCap.TenNcc;
                txt_SoDienThoai.Text = nhaCungCap.DienThoai;
                txt_DiaChi.Text = nhaCungCap.DiaChi;
                txt_Email.Text = nhaCungCap.Email;
            }
        }

        private void chk_NhaCungCap_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_NhaCungCap.Checked)
            {
                cbx_NhaCungCap.Enabled = false;
                gbx_NhaCungCap.Enabled = true;
            }
            else
            {
                cbx_NhaCungCap.Enabled = true;
                gbx_NhaCungCap.Enabled = false;
            }
        }

        private void dgrid_HoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == _hoaDonNhapService.GetListHoaDonNhaps().Count || e.RowIndex == -1) return;
            _iDHoaDon = Convert.ToInt32(dgrid_HoaDonNhap.Rows[e.RowIndex].Cells[0].Value);
            txt_MaHoaDon.Text = _iDHoaDon.ToString();
            txt_TienThanhToan.Text = dgrid_HoaDonNhap.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbx_NhaCungCap.Text = dgrid_HoaDonNhap.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtp_NgayTao.Text = dgrid_HoaDonNhap.Rows[e.RowIndex].Cells[3].Value.ToString();
            FillDataChiTietHoaDon(_iDHoaDon);
        }

        private void dgrid_HoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrid_HoaDonNhap.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected &&
                dgrid_HoaDonNhap.Columns[e.ColumnIndex].Name == "Update")
            {
                gbx_ChiTietHoaDon.Enabled = true;
                gbx_HoaDon.Enabled = false;
                gbx_MatHang.Enabled = true;
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            gbx_ChiTietHoaDon.Enabled = false;
            gbx_HoaDon.Enabled = true;
            gbx_MatHang.Enabled = false;
            _hoaDonNhapService.UpdateHoaDonNhap(_iDHoaDon, _iDNhanVien, Convert.ToInt32(cbx_NhaCungCap.Text),
                Convert.ToInt64(txt_TienThanhToan.Text), _iDNhanVien);
            foreach (var x in _chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps().Where(c => c.IdhoaDon == _iDHoaDon))
            {
                var matHang = _reMatHangService.GetListMatHangs().FirstOrDefault(c => c.Id == x.IdmatHang);
                if (matHang != null)
                {
                    _reMatHangService.ReUpdateMatHang(matHang.Id, matHang.TenMatHang, matHang.IddonViTinh,
                        matHang.DonGia, matHang.SoLuong + x.SoLuong, _iDNhanVien);
                }
            }
            FillDataHoaDontoGrid();
            FillDataMatHangToGrid();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            gbx_ChiTietHoaDon.Enabled = false;
            gbx_HoaDon.Enabled = true;
            gbx_MatHang.Enabled = false;
            foreach (var x in _chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps().Where(c => c.IdhoaDon == _iDHoaDon))
            {
                _chiTietHoaDonNhapService.DeleteChiTietHoaDonNhap(x.IdchiTietHoaDonNhap);
            }
            _hoaDonNhapService.DeleteHoaDonNhap(_iDHoaDon);
            dgrid_ChiTietHoaDonNhap.Columns.Clear();
            FillDataHoaDontoGrid();
        }

        private void dgrid_MatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex == _hoaDonNhapService.GetListHoaDonNhaps().Count || e.RowIndex == -1) return;
            _idMatHang = Convert.ToInt32(dgrid_MatHang.Rows[e.RowIndex].Cells[0].Value);
        }

        private void dgrid_MatHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgrid_MatHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected &&
                dgrid_MatHang.Columns[e.ColumnIndex].Name == "Thêm vào hóa đơn")
            {
                if (_chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps()
                    .Any(c => c.IdhoaDon == _iDHoaDon && c.IdmatHang == _idMatHang))
                {
                    var chiTietHoaDon = _chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps()
                        .FirstOrDefault(c => c.IdhoaDon == _iDHoaDon && c.IdmatHang == _idMatHang);
                    if (chiTietHoaDon != null)
                    {
                        _chiTietHoaDonNhapService.UpdateChiTietHoaDonNhap(chiTietHoaDon.IdchiTietHoaDonNhap,
                            chiTietHoaDon.IdhoaDon, chiTietHoaDon.IdmatHang, chiTietHoaDon.SoLuong + 1,
                            (_reMatHangService.GetListMatHangs().FirstOrDefault(c => c.Id == _idMatHang).DonGia) * (chiTietHoaDon.SoLuong + 1));
                    }
                }
                else
                {
                    var matHang = _reMatHangService.GetListMatHangs().FirstOrDefault(c => c.Id == _idMatHang);
                    if (matHang != null)
                    {
                        _chiTietHoaDonNhapService.AddChiTietHoaDonNhap(_iDHoaDon, _idMatHang, 1, matHang.DonGia);
                    }
                }

                double? sum = 0;
                foreach (var x in _chiTietHoaDonNhapService.GetListChiTietHoaDonNhaps().Where(c => c.IdhoaDon == _iDHoaDon))
                {
                    sum += x.DonGiaNhap;
                }
                txt_TienThanhToan.Text = sum.ToString();
                FillDataChiTietHoaDon(_iDHoaDon);
            }
        }

        private void dgrid_ChiTietHoaDonNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgrid_ChiTietHoaDonNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
