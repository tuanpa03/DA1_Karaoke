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
    public partial class frm_LoaiPhong : Form
    {
        private IBUS_LoaiPhong_Service _iBUS_LoaiPhong_Service;
        private LoaiPhong _loaiPhong;
        private int _id;
        public frm_LoaiPhong()
        {
            InitializeComponent();
            _iBUS_LoaiPhong_Service = new BUS_LoaiPhong_Service();
            _loaiPhong = new LoaiPhong();
            //tbx_ngayTao.Visible = false;
            //tbx_ngayCapNhap.Visible = false;
            LoadData();
        }
        private void LoadData()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Tên Loại Phòng";
            dataGridView1.Columns[1].Name = "Đơn Giá";
            dataGridView1.Columns[2].Name = "Người Tạo";
            dataGridView1.Columns[3].Name = "Ngày tạo";
            dataGridView1.Columns[4].Name = "Người cập nhập";
            dataGridView1.Columns[5].Name = "Ngày cập nhập";
            dataGridView1.Columns[6].Name = "ID";
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Rows.Clear();
            foreach (var x in _iBUS_LoaiPhong_Service.sendlstLoaiPhong())
            {
                dataGridView1.Rows.Add(x.TenLoaiPhong, x.DonGia, x.NguoiTao, x.NgayTao, x.NguoiCapNhap, x.NgayCapNhap, x.Id);
            }
        }
        private bool checkForm()
        {
            if (tbx_tenLoaiPhong.Text.Length == 0 || tbx_donGia.Text.Length == 0 || tbx_nguoiCapNhap.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
                return true;
            }
            return false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;
            var row = dataGridView1.Rows[indexRow];
            tbx_tenLoaiPhong.Text = row.Cells[0].Value + "";
            tbx_donGia.Text = row.Cells[1].Value + "";
            tbx_nguoiTao.Text = row.Cells[2].Value + "";
            tbx_ngayTao.Text = row.Cells[3].Value + "";
            tbx_nguoiCapNhap.Text = row.Cells[4].Value + "";
            tbx_ngayCapNhap.Text = row.Cells[5].Value + "";

            _id = Convert.ToInt32(row.Cells[6].Value);
            // Enabled button
            btn_them.Enabled = false;
        }
        private void ClearForm()
        {
            tbx_donGia.Text = "";
            tbx_ngayCapNhap.Text = "";
            tbx_ngayTao.Text = "";
            tbx_nguoiCapNhap.Text = "";
            tbx_nguoiTao.Text = "";
            tbx_tenLoaiPhong.Text = "";
            btn_them.Enabled = true;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (checkForm()) return;

                _loaiPhong = new LoaiPhong();
                //_loaiPhong.Id = Convert.ToInt32(_iBUS_LoaiPhong_Service.sendlstLoaiPhong().Max(x => x.Id) + 1);
                _loaiPhong.TenLoaiPhong = tbx_tenLoaiPhong.Text;
                _loaiPhong.DonGia = Convert.ToDouble(tbx_donGia.Text);
                _loaiPhong.NguoiTao = tbx_nguoiTao.Text;
                _loaiPhong.NgayTao = DateTime.Now;
                _loaiPhong.NguoiCapNhap = tbx_nguoiCapNhap.Text;
                _loaiPhong.NgayCapNhap = DateTime.Now;
                //_loaiPhong.IdtranngThai = "1";
                MessageBox.Show(_iBUS_LoaiPhong_Service.Add(_loaiPhong).ToString());
                LoadData();
                ClearForm();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn sửa không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (checkForm()) return;
                var loaiPhong = _iBUS_LoaiPhong_Service.Find(_id).FirstOrDefault();//tìm kiếm
                loaiPhong.TenLoaiPhong = tbx_tenLoaiPhong.Text;
                loaiPhong.DonGia = Convert.ToDouble(tbx_donGia.Text);
                loaiPhong.NguoiTao = tbx_nguoiTao.Text;
                loaiPhong.NgayCapNhap = DateTime.Now;
                loaiPhong.NguoiCapNhap = tbx_nguoiCapNhap.Text;

                MessageBox.Show(_iBUS_LoaiPhong_Service.Update(loaiPhong).ToString());
                LoadData();
                ClearForm();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                MessageBox.Show(_iBUS_LoaiPhong_Service.Remove(_id).ToString(), "thông báo");
                LoadData();
                ClearForm();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbx_donGia.Text = "";
            tbx_ngayCapNhap.Text = "";
            tbx_ngayTao.Text = "";
            tbx_nguoiCapNhap.Text = "";
            tbx_nguoiTao.Text = "";
            tbx_tenLoaiPhong.Text = "";
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }

        private void frm_LoaiPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
