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
        string _idPhong;
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
            //tableLayoutPanel1.RowCount = 5;
            int tang = Convert.ToInt32((_iBUS_Phong_Service.sendlstPhong().Count) / 5 + 0.9);
            tableLayoutPanel1.RowCount = tang;
            for (int i = 0; i < tang; i++)
            {
                for (int j = 0; j < 5/*_iBUS_Phong_Service.sendlstPhong().Count*/; j++)
                {
                    Label lb = new Label();
                    lb.Size = new Size(150, 150);
                    lb.Text = _iBUS_Phong_Service.sendlstPhong().ToList()[j].TenPhong;
                    //lb.Name = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(j + 1))).ToList()[j].TenPhong;
                    //_idPhong = lb.Text;
                    lb.BackColor = Color.Red;
                    if (_iBUS_Phong_Service.sendlstPhong().ToList()[j].IdtranngThai == Convert.ToString(1))
                    {
                        lb.BackColor = Color.Yellow;
                    }
                    //else
                    //{
                    //    lb.BackColor = Color.Blue;
                    //}
                    //if ((_iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(j + 1))).ToList()[j].IdtranngThai) == "2")
                    //{
                    //    lb.BackColor = Color.Blue;
                    //}
                    tableLayoutPanel1.Controls.Add(lb, j, i);
                    lb.Margin = new Padding(5, 5, 5, 5);
                    tableLayoutPanel1.ColumnCount++;
                }
            }


        }

        private void stripMenu_datPhong_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Frm_ThanhToan frm_thanhToan = new Frm_ThanhToan();
                //frm_Login.MdiParent = this.MdiParent;
                frm_thanhToan.Show();
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            //_idPhong =
        }

        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            ////int indexRow = e.Row;
            //int indexcolumn = e.Column;
            ////if (indexRow < 0) return;
            ////var row = tableLayoutPanel1.RowCount[indexRow];/*indexRow,indexcolumn*/
            ////_idPhong = row.ToString();
            //for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            //{
            //    var control = tableLayoutPanel1.GetControlFromPosition(i, indexcolumn);
            //    control.Text = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(i))).ToList()[i].TenPhong;
            //    //_idPhong = Convert.ToString(tableLayoutPanel1.GetControlFromPosition(i, indexcolumn));
            //    //var temp = _iBUS_Phong_Service.sendlstPhong().Where(x => x.TenPhong.StartsWith(Convert.ToString(i))).ToList()[i].TenPhong;
            //    _idPhong = control.Text;
            //}

            //for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            //{
            //    for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
            //    {
            //        Control Control = tableLayoutPanel1.GetControlFromPosition(j, i);
            //        //_idPhong = Convert.ToString(tableLayoutPanel1.GetCellPosition()).Text;
                    
            //        _idPhong = Control.Name;
            //    }
            //}
        }
    }
}
