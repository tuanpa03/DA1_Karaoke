﻿using System;
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
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            loadform.Controls.Clear();
            frm_datphong frmDatphong = new frm_datphong();
            frmDatphong.TopLevel = false;
            loadform.Controls.Add(frmDatphong);
            frmDatphong.FormBorderStyle = FormBorderStyle.None;
            frmDatphong.Dock = DockStyle.Fill;
            frmDatphong.Show();
        }
        private void btn_Hethong_Click_1(object sender, EventArgs e)
        {
            load();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            loadform.Controls.Add(childform);
            loadform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btn_DanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_menuDanhMuc());
            //loadform.Controls.Clear();
            //frm_menuDanhMuc frmMenuDanhMuc = new frm_menuDanhMuc();
            //frmMenuDanhMuc.TopLevel = false;
            //loadform.Controls.Add(frmMenuDanhMuc);
            //frmMenuDanhMuc.FormBorderStyle = FormBorderStyle.None;
            //frmMenuDanhMuc.Dock = DockStyle.Fill;
            //frmMenuDanhMuc.Show();
        }

        private void btn_Thongke_Click(object sender, EventArgs e)
        {
            loadform.Controls.Clear();
        }

        private void btn_doimk_Click(object sender, EventArgs e)
        {

        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            frm_Login frmlogin = new frm_Login();
            this.Hide();
            frmlogin.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure","cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            { 
                Application.Exit();
            }
        }
    }
}
