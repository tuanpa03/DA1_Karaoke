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
        private IBUS_ChiTietHoaDonBan_Service _chiTietHoaDonBanService;
        public Frm_ThanhToan(string idPhong)
        {
            InitializeComponent();
            tbx_idPhong.Text = idPhong;
            _matHangService = new BUS_MatHang_Service();
            _donViTinhService = new BUS_DonViTinh_Service();
            _chiTietHoaDonBanService = new BUS_ChiTietHoaDonBan_Service();
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            showdata();
            load();
            
        }

        private void showdata()
        {
            DataGridViewButtonColumn btnthem = new DataGridViewButtonColumn();
            btnthem.Name = "cl_btn_them";
            btnthem.HeaderText = "";
            btnthem.UseColumnTextForButtonValue = true;
            btnthem.Text = "Thêm";
            var data =
                (from a in _matHangService.GetlstMatHangs()
                    select new
                    {
                        a.Id,
                        a.TenMatHang,
                        a.DonGia,
                    }).ToList();
            dgv_MatHang.DataSource = data;
            dgv_MatHang.Columns.Add(btnthem);
        }

        private List<MatHang> _newlstmathang = new List<MatHang>();

        private void load()
        {
            DataGridViewButtonColumn btnxoa = new DataGridViewButtonColumn();
            btnxoa.Name = "cl_btn_xoa";
            btnxoa.HeaderText = "";
            btnxoa.UseColumnTextForButtonValue = true;
            btnxoa.Text = "Xóa";
            dgv_chitietdichvu.Columns.Add(btnxoa);
        }

        private void loaddichvu()
        {
            var datanew = (from a in _newlstmathang
                select new
                {
                    a.Id,
                    a.TenMatHang,
                    a.DonGia
                }).ToList();
            dgv_chitietdichvu.DataSource = datanew;
        }
        private void adddichvu(DataGridViewRow x)
        {
            MatHang newMatHang = new MatHang();
            if (_newlstmathang.Count==0)
            {
                newMatHang.Id = 1;
            }
            else
            {
                newMatHang.Id = _newlstmathang.Max(c => c.Id) + 1;
            }
            newMatHang.TenMatHang = r.Cells["TenMatHang"].Value.ToString();
            newMatHang.DonGia =int.Parse(r.Cells["DonGia"].Value.ToString());
            _newlstmathang.Add(newMatHang);
           
            loaddichvu();
        }
        private void removedichvu(DataGridViewRow x)
        {
            _newlstmathang.RemoveAt(_newlstmathang.FindIndex(x => x.Id ==int.Parse(r.Cells["Id"].Value.ToString())));
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
            try
            {
                this.Hide();
                frm_datphong frm_Main = new frm_datphong();

                frm_Main.Show();
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
            if (e.ColumnIndex == 0)
            {
                removedichvu(r);
            }
        }
    }
}
