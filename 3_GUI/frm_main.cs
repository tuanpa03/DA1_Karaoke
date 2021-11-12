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
    public partial class frm_main : Form
    {
        private const int V = 64;
        IBUS_Phong_Service _iBUS_Phong_Service;
        private Phong phong;
        public frm_main()
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
            phong = new Phong();
            showPhong();
        }

        void showPhong()
        {
            foreach (var x in _iBUS_Phong_Service.sendlstPhong())
            {
                //gbx_phong.cap
                
            }
        }
        
    }
}
