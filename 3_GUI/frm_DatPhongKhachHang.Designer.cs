
namespace _3_GUI
{
    partial class frm_DatPhongKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_themKhachHang = new System.Windows.Forms.Button();
            this.cbx_khachhang = new System.Windows.Forms.ComboBox();
            this.btn_themHoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_idHoaĐon = new System.Windows.Forms.TextBox();
            this.tbx_idPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_tgianBĐ = new System.Windows.Forms.TextBox();
            this.lbl_giaPhong = new System.Windows.Forms.Label();
            this.lbl_tenPhong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_themKhachHang
            // 
            this.btn_themKhachHang.Location = new System.Drawing.Point(413, 151);
            this.btn_themKhachHang.Name = "btn_themKhachHang";
            this.btn_themKhachHang.Size = new System.Drawing.Size(80, 30);
            this.btn_themKhachHang.TabIndex = 51;
            this.btn_themKhachHang.Text = "Thêm";
            this.btn_themKhachHang.UseVisualStyleBackColor = true;
            this.btn_themKhachHang.Click += new System.EventHandler(this.btn_themKhachHang_Click);
            // 
            // cbx_khachhang
            // 
            this.cbx_khachhang.FormattingEnabled = true;
            this.cbx_khachhang.Location = new System.Drawing.Point(256, 153);
            this.cbx_khachhang.Name = "cbx_khachhang";
            this.cbx_khachhang.Size = new System.Drawing.Size(151, 28);
            this.cbx_khachhang.TabIndex = 50;
            // 
            // btn_themHoaDon
            // 
            this.btn_themHoaDon.Location = new System.Drawing.Point(245, 330);
            this.btn_themHoaDon.Name = "btn_themHoaDon";
            this.btn_themHoaDon.Size = new System.Drawing.Size(122, 30);
            this.btn_themHoaDon.TabIndex = 48;
            this.btn_themHoaDon.Text = "Thêm hóa đơn";
            this.btn_themHoaDon.UseVisualStyleBackColor = true;
            this.btn_themHoaDon.Click += new System.EventHandler(this.btn_themHoaDon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã Hóa Đơn";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Mã Phòng";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // tbx_idHoaĐon
            // 
            this.tbx_idHoaĐon.Enabled = false;
            this.tbx_idHoaĐon.Location = new System.Drawing.Point(259, 80);
            this.tbx_idHoaĐon.Name = "tbx_idHoaĐon";
            this.tbx_idHoaĐon.Size = new System.Drawing.Size(168, 27);
            this.tbx_idHoaĐon.TabIndex = 46;
            this.tbx_idHoaĐon.Visible = false;
            // 
            // tbx_idPhong
            // 
            this.tbx_idPhong.Enabled = false;
            this.tbx_idPhong.Location = new System.Drawing.Point(259, 117);
            this.tbx_idPhong.Name = "tbx_idPhong";
            this.tbx_idPhong.Size = new System.Drawing.Size(168, 27);
            this.tbx_idPhong.TabIndex = 47;
            this.tbx_idPhong.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Thời gian Bắt Đầu";
            this.label5.Visible = false;
            // 
            // tbx_tgianBĐ
            // 
            this.tbx_tgianBĐ.Enabled = false;
            this.tbx_tgianBĐ.Location = new System.Drawing.Point(256, 265);
            this.tbx_tgianBĐ.Name = "tbx_tgianBĐ";
            this.tbx_tgianBĐ.Size = new System.Drawing.Size(168, 27);
            this.tbx_tgianBĐ.TabIndex = 53;
            this.tbx_tgianBĐ.Visible = false;
            // 
            // lbl_giaPhong
            // 
            this.lbl_giaPhong.AutoSize = true;
            this.lbl_giaPhong.Location = new System.Drawing.Point(362, 28);
            this.lbl_giaPhong.Name = "lbl_giaPhong";
            this.lbl_giaPhong.Size = new System.Drawing.Size(62, 20);
            this.lbl_giaPhong.TabIndex = 57;
            this.lbl_giaPhong.Text = "Đơn giá";
            // 
            // lbl_tenPhong
            // 
            this.lbl_tenPhong.AutoSize = true;
            this.lbl_tenPhong.Location = new System.Drawing.Point(123, 28);
            this.lbl_tenPhong.Name = "lbl_tenPhong";
            this.lbl_tenPhong.Size = new System.Drawing.Size(78, 20);
            this.lbl_tenPhong.TabIndex = 56;
            this.lbl_tenPhong.Text = "Tên Phòng";
            // 
            // frm_DatPhongKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 391);
            this.Controls.Add(this.lbl_giaPhong);
            this.Controls.Add(this.lbl_tenPhong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbx_tgianBĐ);
            this.Controls.Add(this.btn_themKhachHang);
            this.Controls.Add(this.cbx_khachhang);
            this.Controls.Add(this.btn_themHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_idHoaĐon);
            this.Controls.Add(this.tbx_idPhong);
            this.Name = "frm_DatPhongKhachHang";
            this.Text = "frm_DatPhongKhachHang";
            this.Load += new System.EventHandler(this.frm_DatPhongKhachHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_themKhachHang;
        private System.Windows.Forms.ComboBox cbx_khachhang;
        private System.Windows.Forms.Button btn_themHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_idHoaĐon;
        private System.Windows.Forms.TextBox tbx_idPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_tgianBĐ;
        private System.Windows.Forms.Label lbl_giaPhong;
        private System.Windows.Forms.Label lbl_tenPhong;
    }
}