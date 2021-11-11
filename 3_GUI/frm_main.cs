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
        IBUS_Phong_Service _iBUS_Phong_Service;
        public frm_main()
        {
            InitializeComponent();
            _iBUS_Phong_Service = new BUS_Phong_Service();
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
