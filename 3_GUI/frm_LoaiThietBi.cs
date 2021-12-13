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
    public partial class frm_LoaiThietBi : Form
    {
        public frm_LoaiThietBi()
        {
            InitializeComponent();
            _service = new BUS_LoaiThietBi_Service();
            showdata();
        }
        private IBUS_LoaiThietBi_Service _service;

        private void showdata()
        {
            var data = (from a in _service.GetlstLoaiThietBis()
                        select new
                        {
                            a.MaLoaiTb,
                            a.TenLoai,
                            a.XuatXu,
                            a.IdtranngThai
                        }).ToList();
            dgv_LoaiThietBi.DataSource = data;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            _service.SaveLoaiThietBi();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_maltb.Text) || !string.IsNullOrEmpty(txt_tenloai.Text) || !string.IsNullOrEmpty(txt_trangthai.Text) || !string.IsNullOrEmpty(txt_xuatxu.Text)) // nếu text box k null
            {
                LoaiThietBi ltb = new LoaiThietBi();
                ltb.MaLoaiTb = txt_maltb.Text;
                ltb.TenLoai = txt_tenloai.Text;
                ltb.XuatXu = txt_xuatxu.Text;
                ltb.IdtranngThai = txt_trangthai.Text;
                _service.AddLoaiThietBi(ltb);
                MessageBox.Show("Thêm thành công", "Hoàn thành", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                showdata();
                txt_maltb.Text = null;
                txt_tenloai.Text = null;
                txt_trangthai.Text = null;
                txt_xuatxu.Text = null;
            }
            else
            {
                MessageBox.Show("Xem lại nhập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataGridViewRow dt;
        private void dgv_LoaiThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            dt = dgv_LoaiThietBi.Rows[e.RowIndex];
            txt_maltb.Text = dt.Cells["MaLoaiTB"].Value.ToString();
            txt_tenloai.Text = dt.Cells["TenLoai"].Value.ToString();
            txt_xuatxu.Text = dt.Cells["XuatXu"].Value.ToString();
            txt_trangthai.Text = dt.Cells["IdtranngThai"].Value.ToString();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("Bạn chưa chọn loại cần xóa", "Chú ý!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Are you sure about that??", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var ltb = _service.GetlstLoaiThietBis()
                    .SingleOrDefault(x => x.MaLoaiTb == dt.Cells["MaLoaiTb"].Value.ToString());
                _service.RemoveLoaiThietBi(ltb);
                MessageBox.Show("Xóa thành công", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                dt = null;
                txt_maltb.Text = null;
                txt_tenloai.Text = null;
                txt_trangthai.Text = null;
                txt_xuatxu.Text = null;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (dt == null)
            {
                MessageBox.Show("Bạn chưa chọn loại cần cập nhập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(txt_maltb.Text) || !string.IsNullOrEmpty(txt_tenloai.Text) || !string.IsNullOrEmpty(txt_xuatxu.Text) || !string.IsNullOrEmpty(txt_trangthai.Text))
            {
                var ltb = _service.GetlstLoaiThietBis()
                    .SingleOrDefault(x => x.MaLoaiTb == dt.Cells["MaLoaiTb"].Value.ToString());
                ltb.MaLoaiTb = txt_maltb.Text;
                ltb.TenLoai = txt_tenloai.Text;
                ltb.XuatXu = txt_xuatxu.Text;
                ltb.IdtranngThai = txt_trangthai.Text;
                _service.EditLoaiThietBi(ltb);
                MessageBox.Show("Sửa thành công", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showdata();
                dt = null;
                txt_maltb.Text = null;
                txt_tenloai.Text = null;
                txt_trangthai.Text = null;
                txt_xuatxu.Text = null;
            }
            else
            {
                MessageBox.Show("Xem lại nhập", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            frm_menuDanhMuc.loadthietbi();
        }
    }
}
