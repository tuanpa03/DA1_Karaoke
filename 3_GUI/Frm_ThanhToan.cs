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
        private List<MatHang> _dataMatHangs;
        public Frm_ThanhToan(string idPhong)
        {
            InitializeComponent();
            tbx_idPhong.Text = idPhong;
            _matHangService = new BUS_MatHang_Service();
            _donViTinhService = new BUS_DonViTinh_Service();
            _chiTietHoaDonBanService = new BUS_ChiTietHoaDonBan_Service();
            _dataMatHangs = new List<MatHang>();
        }
        private void Frm_ThanhToan_Load(object sender, EventArgs e)
        {
            loaddichvu();
            getdata("");
        }

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
    }
}
