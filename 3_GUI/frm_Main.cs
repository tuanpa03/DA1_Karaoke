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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_GUI
{
    public partial class frm_Main : Form
    {
        private IBUS_Phong_Service _iBUS_Phong_Service;
        string _tenPhong;
        int _idPhong;
        List<Phong> _lstPhong = new List<Phong>();
        public frm_Main()
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
            _lstPhong = _iBUS_Phong_Service.sendlstPhong();
            showRoom();
        }
        void showRoom()
        {
            //tableLayoutPanel1.Controls.Clear();
            int tang = Convert.ToInt32((_iBUS_Phong_Service.sendlstPhong().Count) / 5 + 0.9);
            //int tang = Convert.ToInt32(_iBUS_Phong_Service.sendlstPhong().Where(x=>x.TenPhong.Substring(0, 1).Count );
            tableLayoutPanel1.RowCount = tang;
            for (int i = 0; i < tang; i++)
            {
                for (int j = 0; j < _iBUS_Phong_Service.sendlstPhong().Where(x=>x.TenPhong.Substring(0, 1) == Convert.ToString(i+1)).ToList().Count; j++)
                {
                    Label lb = new Label();
                    lb.Size = new Size(150, 150);
                    lb.Text = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1)).ToList()[j].TenPhong;
                    _tenPhong = lb.Text;
                    lb.Name = Convert.ToString( _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1)).ToList()[j].Id);
                    
                    lb.BackColor = Color.Red;
                    int _idTrangThai = Convert.ToInt32(_iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.Substring(0, 1) == Convert.ToString(i + 1)).ToList()[j].IdtranngThai);
                    if (_idTrangThai== 1)
                    {
                        lb.BackColor = Color.Red;//có khách
                    }
                    else if (_idTrangThai == 2)
                    {
                        lb.BackColor = Color.Yellow;//đang dọn
                    }
                    else if (_idTrangThai == 3)
                    {
                        lb.BackColor = Color.Gray;//đang sửa chữa
                    }
                    else
                    {
                        lb.BackColor = Color.Blue;//phòng trống
                    }
                    //lb.Click += new System.EventHandler(this.lb_Click);
                    tableLayoutPanel1.Controls.Add(lb, j, i);
                    lb.Margin = new Padding(5, 5, 5, 5);
                    tableLayoutPanel1.ColumnCount++;
                }
            }
        }
        //private void lb_Click(object sender, EventArgs e)
        //{
        //    _tenPhong = e.ToString();
        //    MessageBox.Show(_tenPhong);
        //}
        private void stripMenu_datPhong_Click(object sender, EventArgs e)
        {
            try
            {
                var index = GetRowColIndex(tableLayoutPanel1, tableLayoutPanel1.PointToClient(Cursor.Position));
                _idPhong = Convert.ToInt32(tableLayoutPanel1.GetControlFromPosition(index.X, index.Y).Name);
                this.Hide();
                Frm_ThanhToan frm_thanhToan = new Frm_ThanhToan(_idPhong.ToString());
                //frm_Login.MdiParent = this.MdiParent;
                frm_thanhToan.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        //private void tableLayoutPanel1_Click(object sender, EventArgs e)
        //{
            
        //    //for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
        //    //{
        //    //    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
        //    //    {
        //    //        Control Control = tableLayoutPanel1.GetControlFromPosition(j, i);
        //    //        _tenPhong = Control.Text;
        //    //        //_idPhong = Convert.ToString(tableLayoutPanel1.GetCellPosition()).Text;

        //    //        //_tenPhong = Control.Name;
        //    //    }
        //    //}
        //}

        //private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        //{
        //    ////int indexRow = e.Row;
        //    //int indexcolumn = e.Column;
        //    ////if (indexRow < 0) return;
        //    ////var row = tableLayoutPanel1.RowCount[indexRow];/*indexRow,indexcolumn*/
        //    ////_idPhong = row.ToString();
        //    //for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
        //    //{
        //    //    var control = tableLayoutPanel1.GetControlFromPosition(i, indexcolumn);
        //    //    control.Text = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(i))).ToList()[i].TenPhong;
        //    //    //_idPhong = Convert.ToString(tableLayoutPanel1.GetControlFromPosition(i, indexcolumn));
        //    //    //var temp = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(i))).ToList()[i].TenPhong;
        //    //    _idPhong = control.Text;
        //    //}

        //    //for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
        //    //{
        //    //    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
        //    //    {
        //    //        Control Control = tableLayoutPanel1.GetControlFromPosition(j, i);
        //    //        //_idPhong = Convert.ToString(tableLayoutPanel1.GetCellPosition()).Text;
                    
        //    //        _idPhong = Control.Name;
        //    //    }
        //    //}
        //}

        private void stripMenu_capNhap_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_ThanhToan frm_thanhToan = new Frm_ThanhToan(_idPhong.ToString());
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
            MessageBox.Show(_tenPhong);
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
            var index = GetRowColIndex(tableLayoutPanel1,tableLayoutPanel1.PointToClient(Cursor.Position));
            _idPhong = Convert.ToInt32( tableLayoutPanel1.GetControlFromPosition(index.X,index.Y).Name);
            MessageBox.Show(Convert.ToString( _idPhong));

        }
         public Point GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return new Point(0,0);

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

        //private void contextMenuStrip1_Click(object sender, EventArgs e)
        //{
        //    //Point point = tableLayoutPanel1.PointToClient(Control.MousePosition);
        //    ////RibbonHitInfo
        //    //string tenphong = tableLayoutPanel1.PointToClient(Control.MousePosition).ToString();
        //    //MessageBox.Show(tenphong);
        //    _idPhong = this.l


        //}
    }
}
