﻿using _1_DAL.Entities;
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
    public partial class frm_Phong : Form
    {
        private IBUS_Phong_Service _iBUS_Phong_Service;
        private Phong _phong;
        private string _idPhong;
        public frm_Phong()
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
            _phong = new Phong();
            LoadData();
            //tbx_ngayCapNhap.Visible = false;
            //tbx_ngayTao.Visible = false;
        }
        private void LoadData()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Name = "Mã Loại Phòng";
            dataGridView1.Columns[2].Name = "Tên Phòng";
            dataGridView1.Columns[3].Name = "Trạng thái";
            dataGridView1.Columns[4].Name = "Sức chứa";
            dataGridView1.Columns[5].Name = "Người Tạo";
            dataGridView1.Columns[6].Name = "Ngày tạo";
            dataGridView1.Columns[7].Name = "Người cập nhập";
            dataGridView1.Columns[8].Name = "Ngày cập nhập";
            
            dataGridView1.Rows.Clear();
            foreach (var x in _iBUS_Phong_Service.sendlstPhong())
            {
                dataGridView1.Rows.Add(x.Id, x.IdloaiPhong, x.TenPhong, x.TrangThai, x.SucChua, x.NguoiTao, x.NgayTao, x.NguoiCapNhap, x.NgayCapNhap);
            }
        }
        private bool checkForm()
        {
            if (tbx_tenPhong.Text.Length == 0 || tbx_SucChua.Text.Length == 0 || tbx_nguoiTao.Text.Length == 0 || tbx_nguoiCapNhap.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
                return true;
            }
            if (rbt_coKhach.Checked == false && rbt_khongCoKhach.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn trạng thái");
                return true;
            }
            
            return false;
        }
        private void ClearForm()
        {
            tbx_tenPhong.Text = "";
            tbx_maLoaiPhong.Text = "";
            tbx_SucChua.Text = "";
            tbx_nguoiTao.Text = "";
            tbx_ngayTao.Text = "";
            tbx_nguoiCapNhap.Text = "";
            tbx_ngayCapNhap.Text = ""; 
            rbt_khongCoKhach.Checked = true;
            rbt_coKhach.Checked = false;
            btn_them.Enabled = true;

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            if (indexRow < 0) return;
            var row = dataGridView1.Rows[indexRow];
            tbx_maLoaiPhong.Text = row.Cells[1].Value + "";
            tbx_tenPhong.Text = row.Cells[2].Value + "";
            if (row.Cells[3].Value + "" == "Có khách")
            {
                rbt_coKhach.Checked = true;
            }
            if (row.Cells[3].Value + "" == "Không có khách")
            {
                rbt_khongCoKhach.Checked = true;
            }
            tbx_SucChua.Text = row.Cells[4].Value + "";           
            tbx_nguoiTao.Text = row.Cells[5].Value + "";
            tbx_ngayTao.Text = row.Cells[6].Value + "";
            tbx_nguoiCapNhap.Text = row.Cells[7].Value + "";
            tbx_ngayCapNhap.Text = row.Cells[8].Value + "";

            _idPhong = row.Cells[0].Value + "";
            // Enabled button
            btn_them.Enabled = false;

        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {
                if (checkForm()) return;
                
                _phong = new Phong();
                _phong.Id = _iBUS_Phong_Service.sendlstPhong().Max(x => x.Id+ 1);
                _phong.TenPhong = tbx_tenPhong.Text;
                _phong.IdloaiPhong = Convert.ToInt32(tbx_maLoaiPhong.Text);
                if (rbt_khongCoKhach.Checked == true)
                {
                    rbt_coKhach.Checked = false;
                }
                if (rbt_coKhach.Checked == true)
                {
                    rbt_khongCoKhach.Checked = false;
                }
                _phong.SucChua = Convert.ToInt32(tbx_SucChua.Text);
                _phong.NguoiTao = tbx_nguoiTao.Text;
                _phong.NgayTao = DateTime.Now;
                _phong.NguoiCapNhap = tbx_nguoiCapNhap.Text;
                _phong.NgayCapNhap = DateTime.Now;
                _phong.IdtranngThai = "1";
                MessageBox.Show(_iBUS_Phong_Service.Add(_phong).ToString());
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
                var phong = _iBUS_Phong_Service.Find(_idPhong).FirstOrDefault();//tìm kiếm
                phong.IdloaiPhong = Convert.ToInt32( tbx_maLoaiPhong.Text);
                phong.TenPhong = tbx_tenPhong.Text;
                phong.SucChua = Convert.ToInt32( tbx_SucChua.Text);
                phong.NguoiCapNhap = tbx_nguoiCapNhap.Text;
                if (rbt_khongCoKhach.Checked == true)
                {
                    rbt_coKhach.Checked = false;
                }
                if (rbt_coKhach.Checked == true)
                {
                    rbt_khongCoKhach.Checked = false;
                }
                MessageBox.Show(_iBUS_Phong_Service.Update(phong).ToString());
                LoadData();
                ClearForm();
            }
        }

        private void btn_xóa_Click(object sender, EventArgs e)
        {
            DialogResult hoi;
            hoi = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (hoi == DialogResult.Yes)
            {               
                MessageBox.Show(_iBUS_Phong_Service.Remove(_idPhong).ToString(), "thông báo");
                LoadData();
                ClearForm();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {

        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {

        }
    }
}
