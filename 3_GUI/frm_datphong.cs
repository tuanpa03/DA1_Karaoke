using _1_DAL.Entities;
using _2_BUS.BUS_Service;
using _2_BUS.IBUS_Service;
using _3_GUI_PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class frm_datphong : Form
    {
        private IBUS_Phong_Service _iBUS_Phong_Service;
        private IBUS_Tang_Service _iBUS_Tang_Service;
        private IBUS_HoaDonBanHang_Service _ihoaDonBanHang_Service;
        string _tenPhong;
        int _idPhongDatPhong;
        int _idPhongDonPhong;
        string _idHoaDonTruyenThanhToan;
        string _khachhangTruyenThanhToan;
        string _tGianBDTruyenThanhToan;
        string _idPhongTruyenThanhToan;
        //string _giodonphong;
        List<Phong> _lstPhong = new List<Phong>();
        private System.Windows.Forms.Timer aTimer;

        private int counter = 10;
        public frm_datphong()
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
            _lstPhong = _iBUS_Phong_Service.sendlstPhong();
            _iBUS_Tang_Service = new BUS_Tang_Service();
            _ihoaDonBanHang_Service = new BUS_HoaDonBanHang_Service();
            showRoom();
        }
        public frm_datphong(string idHoaDon111 /*, string khachHang111, string tgianBD111*/,string idPhong111)
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
            _lstPhong = _iBUS_Phong_Service.sendlstPhong();
            _iBUS_Tang_Service = new BUS_Tang_Service();
            _ihoaDonBanHang_Service = new BUS_HoaDonBanHang_Service();
            _idHoaDonTruyenThanhToan = idHoaDon111;
            //_khachhangTruyenThanhToan = khachHang111;
            //_tGianBDTruyenThanhToan = tgianBD111;
            _idPhongTruyenThanhToan = idHoaDon111;
            showRoom();
            
        }
        void showRoom()
        {
            
            tableLayoutPanel1.Controls.Clear();
            int tang = Convert.ToInt32((_iBUS_Phong_Service.sendlstPhong().Count) / 5 + 0.9+2);
            //int tang = Convert.ToInt32(_iBUS_Phong_Service.sendlstPhong().Max(x=>x.TenPhong.Substring(0, 1)));
            //int tang = Convert.ToInt32;
            //tableLayoutPanel1.RowCount = tang;
            for (int i = 0; i < tang; i++)
            {
                for (int j = 0; j < _iBUS_Phong_Service.sendlstPhong().Where(x => x.Idtang == i + 1).ToList().Count; j++)
                {
                    Label lb = new Label();
                    lb.Size = new Size(150, 150);
                    string tenPhong = "Phòng" + _iBUS_Phong_Service.sendlstPhong().Where(x => x.Idtang == i + 1).ToList()[j].TenPhong;
                    lb.Name = Convert.ToString(_iBUS_Phong_Service.sendlstPhong().Where(x => x.Idtang == i + 1).ToList()[j].Id);
                    string maKh;
                    string gioVao;
                    string str = tenPhong + "\n" + "Mã khách hàng" /*+ maKh*/ + "\n" + "Giờ Bắt Đầu" /*+ gioVao*/;
                    lb.Text = str;
                    lb.Text =tenPhong;
                    lb.BackColor = Color.Red;
                    int _trangThai = Convert.ToInt32(_iBUS_Phong_Service.sendlstPhong().Where(x => x.Idtang == i + 1).ToList()[j].TrangThai);
                    if (_trangThai == 1)
                    {
                        lb.BackColor = Color.Red;//phòng trống
                        
                        
                        //stripMenu_capNhap.Enabled = false;
                    }
                    else if (_trangThai == 2)
                    {
                        lb.BackColor = Color.Yellow;//đang dọn
                        lb.ForeColor = Color.Gray;//màu chữ
                    }
                    else if (_trangThai == 3)
                    {
                        lb.BackColor = Color.Blue;//có khách
                        
                    }
                    else if (_trangThai == 4)
                    {
                        lb.BackColor = Color.Gray;//đang sửa chữa
                    }
                    tableLayoutPanel1.Controls.Add(lb, j, i);
                    lb.Margin = new Padding(5, 5, 5, 5);
                    tableLayoutPanel1.ColumnCount++;
                    //tìm lb nào có name id == id bên kia thì truyền sửa lại text

                    //if (_idHoaDonTruyenThanhToan == null)//sửa _idPhong=truyền id bên thanh toán hóa đơn                    
                    //{
                    //    lb.Text = _tenPhong;
                    //}
                    //else if (_idHoaDonTruyenThanhToan != null)
                    //{
                    //    if (lb.Name == _idPhongTruyenThanhToan)//sửa _idPhong=truyền id bên thanh toán hóa đơn
                    //    {
                    //        var hoaDon = _ihoaDonBanHang_Service.sendlstHoaDonBanHang().FirstOrDefault(x => x.IdhoaDon == Convert.ToInt32(_idHoaDonTruyenThanhToan));
                    //        maKh = hoaDon.IdmaKh;
                    //        gioVao = hoaDon.ThoiGianBatDau.ToString();
                    //        lb.Text = tenPhong + "\n" + "Mã khách hàng" + maKh + "\n" + "Giờ Bắt Đầu" + gioVao;
                    //        //tìm hóa đơn giống idphong lấy mã kh , thời gian bắt đầu
                    //        MessageBox.Show(lb.Text);
                    //    }
                    //    else
                    //    {
                    //        lb.Text = "bbbbbbbbbbb";
                    //    }
                    //}


                    //dọn phòng
                    if (lb.Name == _idPhongDonPhong.ToString())//dọn phòng
                        {
                            //string thoiGian = counter.ToString();
                            DateTime thoiGianbg = DateTime.Now;
                            lb.Text = tenPhong + "\n" + "Tgian bắt đầu dọn:" + thoiGianbg + "\n" + "Thời gian dọn:" + counter /*counter*/ + "giây" /*+ "\n" + "Thời gian còn lại:"+_giodonphong*/;
                        }
                        //tableLayoutPanel1.RowCount++;
                    //}
                }
            }
        }
        private void stripMenu_datPhong_Click(object sender, EventArgs e)
        {
            try
            {
                var index = GetRowColIndex(tableLayoutPanel1, tableLayoutPanel1.PointToClient(Cursor.Position));
                _idPhongDatPhong = Convert.ToInt32(tableLayoutPanel1.GetControlFromPosition(index.X, index.Y).Name);
                this.Hide();
                Frm_ThanhToan frm_thanhToan = new Frm_ThanhToan(_idPhongDatPhong.ToString());
                //frm_Login.MdiParent = this.MdiParent;
                frm_thanhToan.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        private void stripMenu_capNhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_ThanhToan frm_thanhToan = new Frm_ThanhToan(_idPhongDatPhong.ToString());
                //frm_Login.MdiParent = this.MdiParent;
                frm_thanhToan.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void stripMenu_donPhong_Click(object sender, EventArgs e)
        {

            var index = GetRowColIndex(tableLayoutPanel1, tableLayoutPanel1.PointToClient(Cursor.Position));
            _idPhongDonPhong = Convert.ToInt32(tableLayoutPanel1.GetControlFromPosition(index.X, index.Y).Name);
            if (Convert.ToInt32(_lstPhong.FirstOrDefault(x => x.Id == _idPhongDonPhong).TrangThai) == 2)
            {
                MessageBox.Show("Phòng đang dọn", "Thông báo"/*,Thread.Sleep(3000)*/);
                return;
            }
 
            foreach (var x in _lstPhong)
            {
                if (Convert.ToInt32(x.TrangThai) ==2)
                {
                    MessageBox.Show("Không thể dọn ! Có Phòng đang dọn", "Thông báo");
                    return;
                }
            }
            var phong = _iBUS_Phong_Service.Find(_idPhongDonPhong).FirstOrDefault();
            phong.TrangThai = 2;
            _iBUS_Phong_Service.Update(phong);
            //showRoom();
            aTimer = new System.Windows.Forms.Timer();

            aTimer.Tick += new EventHandler(aTimer_Tick);

            aTimer.Interval = 1000; // 1 second

            aTimer.Start();

            // label1.Text = counter.ToString();
            counter = 10;
            showRoom();
            counter=10;
            

        }
        private void aTimer_Tick(object sender, EventArgs e)

        {
            counter--;
            if (counter == 0 || counter == -10 || counter == -20)
            {
                aTimer.Stop();
                MessageBox.Show("Phòng" + _lstPhong.FirstOrDefault(x => x.Id == _idPhongDonPhong).TenPhong + "đã dọn phòng xong", "Thông báo");
                var phong = _iBUS_Phong_Service.Find(_idPhongDonPhong).FirstOrDefault();
                phong.TrangThai = 1;
                _iBUS_Phong_Service.Update(phong);
                showRoom();
                

            }
            label1.Text = counter.ToString();
            
        }

        private void đătPhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                frm_Phong frm_phong = new frm_Phong();
                //frm_Login.MdiParent = this.MdiParent;
                frm_phong.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            var index = GetRowColIndex(tableLayoutPanel1, tableLayoutPanel1.PointToClient(Cursor.Position));
            _idPhongDatPhong = Convert.ToInt32(tableLayoutPanel1.GetControlFromPosition(index.X, index.Y).Name);
            MessageBox.Show(Convert.ToString(_idPhongDatPhong));

        }
        public Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(0, 0);

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }
        private void thongKe(int a)
        {
            tableLayoutPanel1.Controls.Clear();
            int tang = Convert.ToInt32((_iBUS_Phong_Service.sendlstPhong().Count) / 5 + 0.9);
            tableLayoutPanel1.RowCount = tang;
            for (int i = 0; i < tang; i++)
            {
                for (int j = 0; j < _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1) && Convert.ToInt32(x.TrangThai) == a).ToList().Count; j++)
                {
                    Label lb = new Label();
                    lb.Size = new Size(150, 150);
                    string tenPhong = "Phòng" + _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1) && Convert.ToInt32(x.TrangThai) == a).ToList()[j].TenPhong;
                    string maKh = "Mã khách hàng";
                    string gioVao = "Giờ Bắt Đầu";
                    string str = tenPhong + "\n" + maKh + "\n" + gioVao;
                    lb.Text = str;
                    _tenPhong = lb.Text;
                    lb.Name = Convert.ToString(_iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1) && Convert.ToInt32(x.TrangThai) == a).ToList()[j].Id);
                    tableLayoutPanel1.Controls.Add(lb, j, i);
                    lb.Margin = new Padding(5, 5, 5, 5);
                    if (a == 1)
                    {
                        lb.BackColor = Color.Red;//phòng trống
                    }
                    else if (a == 2)
                    {
                        lb.BackColor = Color.Yellow;//đang dọn
                        lb.ForeColor = Color.Gray;
                    }
                    else if (a == 3)
                    {
                        lb.BackColor = Color.Blue;//có khách
                    }
                    else
                    {
                        lb.BackColor = Color.Gray;//đang sửa chữa
                    }
                }
            }
        }


        private void btn_sanSangDonKhach_Click(object sender, EventArgs e)
        {
            thongKe(1);
        }

        private void btn_phongDangDon_Click(object sender, EventArgs e)
        {
            thongKe(2);
        }
        private void btn_phongCoKhach_Click(object sender, EventArgs e)
        {
            thongKe(3);
        }

        private void btn_phongdangSuaChua_Click(object sender, EventArgs e)
        {
            thongKe(4);
        }

        private void frm_datphong_Load(object sender, EventArgs e)
        {
            showRoom();
        }
    }
}
