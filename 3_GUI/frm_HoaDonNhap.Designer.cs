
namespace _3_GUI
{
    partial class frm_HoaDonNhap
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
            this.gbx_HoaDon = new System.Windows.Forms.GroupBox();
            this.btn_AddHoaDon = new System.Windows.Forms.Button();
            this.dgrid_HoaDonNhap = new System.Windows.Forms.DataGridView();
            this.gbx_MatHang = new System.Windows.Forms.GroupBox();
            this.dgrid_MatHang = new System.Windows.Forms.DataGridView();
            this.gbx_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_NgayTao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_NhaCungCap = new System.Windows.Forms.GroupBox();
            this.btn_AddNhaCungCap = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.txt_TenNhaCungCap = new System.Windows.Forms.TextBox();
            this.chk_NhaCungCap = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_NhaCungCap = new System.Windows.Forms.ComboBox();
            this.txt_TienThanhToan = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.txt_MaHoaDon = new System.Windows.Forms.TextBox();
            this.dgrid_ChiTietHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.gbx_HoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonNhap)).BeginInit();
            this.gbx_MatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MatHang)).BeginInit();
            this.gbx_ChiTietHoaDon.SuspendLayout();
            this.gbx_NhaCungCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_HoaDon
            // 
            this.gbx_HoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.gbx_HoaDon.Controls.Add(this.btn_AddHoaDon);
            this.gbx_HoaDon.Controls.Add(this.dgrid_HoaDonNhap);
            this.gbx_HoaDon.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbx_HoaDon.Location = new System.Drawing.Point(0, 0);
            this.gbx_HoaDon.Name = "gbx_HoaDon";
            this.gbx_HoaDon.Size = new System.Drawing.Size(430, 900);
            this.gbx_HoaDon.TabIndex = 2;
            this.gbx_HoaDon.TabStop = false;
            this.gbx_HoaDon.Text = "Hóa đơn nhập";
            // 
            // btn_AddHoaDon
            // 
            this.btn_AddHoaDon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_AddHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_AddHoaDon.Location = new System.Drawing.Point(3, 23);
            this.btn_AddHoaDon.Name = "btn_AddHoaDon";
            this.btn_AddHoaDon.Size = new System.Drawing.Size(424, 43);
            this.btn_AddHoaDon.TabIndex = 1;
            this.btn_AddHoaDon.Text = "Tạo hóa đơn mới";
            this.btn_AddHoaDon.UseVisualStyleBackColor = false;
            this.btn_AddHoaDon.Click += new System.EventHandler(this.btn_AddHoaDon_Click);
            // 
            // dgrid_HoaDonNhap
            // 
            this.dgrid_HoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_HoaDonNhap.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgrid_HoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_HoaDonNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_HoaDonNhap.Location = new System.Drawing.Point(3, 72);
            this.dgrid_HoaDonNhap.Name = "dgrid_HoaDonNhap";
            this.dgrid_HoaDonNhap.RowHeadersWidth = 51;
            this.dgrid_HoaDonNhap.RowTemplate.Height = 29;
            this.dgrid_HoaDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_HoaDonNhap.Size = new System.Drawing.Size(424, 825);
            this.dgrid_HoaDonNhap.TabIndex = 0;
            this.dgrid_HoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonNhap_CellClick);
            this.dgrid_HoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_HoaDonNhap_CellContentClick);
            // 
            // gbx_MatHang
            // 
            this.gbx_MatHang.BackColor = System.Drawing.SystemColors.Control;
            this.gbx_MatHang.Controls.Add(this.dgrid_MatHang);
            this.gbx_MatHang.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbx_MatHang.Location = new System.Drawing.Point(880, 0);
            this.gbx_MatHang.Name = "gbx_MatHang";
            this.gbx_MatHang.Size = new System.Drawing.Size(430, 900);
            this.gbx_MatHang.TabIndex = 3;
            this.gbx_MatHang.TabStop = false;
            this.gbx_MatHang.Text = "Mặt hàng";
            // 
            // dgrid_MatHang
            // 
            this.dgrid_MatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_MatHang.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgrid_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_MatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_MatHang.Location = new System.Drawing.Point(3, 23);
            this.dgrid_MatHang.Name = "dgrid_MatHang";
            this.dgrid_MatHang.RowHeadersWidth = 51;
            this.dgrid_MatHang.RowTemplate.Height = 29;
            this.dgrid_MatHang.Size = new System.Drawing.Size(424, 874);
            this.dgrid_MatHang.TabIndex = 0;
            this.dgrid_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_MatHang_CellClick);
            this.dgrid_MatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_MatHang_CellContentClick);
            // 
            // gbx_ChiTietHoaDon
            // 
            this.gbx_ChiTietHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this.gbx_ChiTietHoaDon.Controls.Add(this.label8);
            this.gbx_ChiTietHoaDon.Controls.Add(this.dtp_NgayTao);
            this.gbx_ChiTietHoaDon.Controls.Add(this.label2);
            this.gbx_ChiTietHoaDon.Controls.Add(this.gbx_NhaCungCap);
            this.gbx_ChiTietHoaDon.Controls.Add(this.chk_NhaCungCap);
            this.gbx_ChiTietHoaDon.Controls.Add(this.label1);
            this.gbx_ChiTietHoaDon.Controls.Add(this.label3);
            this.gbx_ChiTietHoaDon.Controls.Add(this.cbx_NhaCungCap);
            this.gbx_ChiTietHoaDon.Controls.Add(this.txt_TienThanhToan);
            this.gbx_ChiTietHoaDon.Controls.Add(this.btn_Huy);
            this.gbx_ChiTietHoaDon.Controls.Add(this.btn_XacNhan);
            this.gbx_ChiTietHoaDon.Controls.Add(this.txt_MaHoaDon);
            this.gbx_ChiTietHoaDon.Controls.Add(this.dgrid_ChiTietHoaDonNhap);
            this.gbx_ChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_ChiTietHoaDon.Location = new System.Drawing.Point(430, 0);
            this.gbx_ChiTietHoaDon.Name = "gbx_ChiTietHoaDon";
            this.gbx_ChiTietHoaDon.Size = new System.Drawing.Size(450, 900);
            this.gbx_ChiTietHoaDon.TabIndex = 4;
            this.gbx_ChiTietHoaDon.TabStop = false;
            this.gbx_ChiTietHoaDon.Text = "Chi tiết hóa đơn nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 473);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày tạo";
            // 
            // dtp_NgayTao
            // 
            this.dtp_NgayTao.Location = new System.Drawing.Point(188, 468);
            this.dtp_NgayTao.Name = "dtp_NgayTao";
            this.dtp_NgayTao.Size = new System.Drawing.Size(248, 27);
            this.dtp_NgayTao.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tiền thanh toán";
            // 
            // gbx_NhaCungCap
            // 
            this.gbx_NhaCungCap.Controls.Add(this.btn_AddNhaCungCap);
            this.gbx_NhaCungCap.Controls.Add(this.label7);
            this.gbx_NhaCungCap.Controls.Add(this.label5);
            this.gbx_NhaCungCap.Controls.Add(this.label6);
            this.gbx_NhaCungCap.Controls.Add(this.label4);
            this.gbx_NhaCungCap.Controls.Add(this.txt_Email);
            this.gbx_NhaCungCap.Controls.Add(this.txt_DiaChi);
            this.gbx_NhaCungCap.Controls.Add(this.txt_SoDienThoai);
            this.gbx_NhaCungCap.Controls.Add(this.txt_TenNhaCungCap);
            this.gbx_NhaCungCap.Location = new System.Drawing.Point(6, 169);
            this.gbx_NhaCungCap.Name = "gbx_NhaCungCap";
            this.gbx_NhaCungCap.Size = new System.Drawing.Size(438, 293);
            this.gbx_NhaCungCap.TabIndex = 10;
            this.gbx_NhaCungCap.TabStop = false;
            this.gbx_NhaCungCap.Text = "Thông tin nhà cung cấp";
            // 
            // btn_AddNhaCungCap
            // 
            this.btn_AddNhaCungCap.Location = new System.Drawing.Point(171, 221);
            this.btn_AddNhaCungCap.Name = "btn_AddNhaCungCap";
            this.btn_AddNhaCungCap.Size = new System.Drawing.Size(103, 35);
            this.btn_AddNhaCungCap.TabIndex = 11;
            this.btn_AddNhaCungCap.Text = "Thêm";
            this.btn_AddNhaCungCap.UseVisualStyleBackColor = true;
            this.btn_AddNhaCungCap.Click += new System.EventHandler(this.btn_AddNhaCungCap_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_Email.Location = new System.Drawing.Point(171, 178);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(186, 27);
            this.txt_Email.TabIndex = 5;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_DiaChi.Location = new System.Drawing.Point(171, 135);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(186, 27);
            this.txt_DiaChi.TabIndex = 5;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_SoDienThoai.Location = new System.Drawing.Point(171, 86);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(186, 27);
            this.txt_SoDienThoai.TabIndex = 6;
            // 
            // txt_TenNhaCungCap
            // 
            this.txt_TenNhaCungCap.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_TenNhaCungCap.Location = new System.Drawing.Point(171, 42);
            this.txt_TenNhaCungCap.Name = "txt_TenNhaCungCap";
            this.txt_TenNhaCungCap.Size = new System.Drawing.Size(186, 27);
            this.txt_TenNhaCungCap.TabIndex = 7;
            // 
            // chk_NhaCungCap
            // 
            this.chk_NhaCungCap.AutoSize = true;
            this.chk_NhaCungCap.Location = new System.Drawing.Point(375, 127);
            this.chk_NhaCungCap.Name = "chk_NhaCungCap";
            this.chk_NhaCungCap.Size = new System.Drawing.Size(63, 24);
            this.chk_NhaCungCap.TabIndex = 9;
            this.chk_NhaCungCap.Text = "Khác";
            this.chk_NhaCungCap.UseVisualStyleBackColor = true;
            this.chk_NhaCungCap.CheckedChanged += new System.EventHandler(this.chk_NhaCungCap_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nhà cung cấp";
            // 
            // cbx_NhaCungCap
            // 
            this.cbx_NhaCungCap.BackColor = System.Drawing.SystemColors.Menu;
            this.cbx_NhaCungCap.FormattingEnabled = true;
            this.cbx_NhaCungCap.Location = new System.Drawing.Point(171, 125);
            this.cbx_NhaCungCap.Name = "cbx_NhaCungCap";
            this.cbx_NhaCungCap.Size = new System.Drawing.Size(186, 28);
            this.cbx_NhaCungCap.TabIndex = 7;
            this.cbx_NhaCungCap.SelectedIndexChanged += new System.EventHandler(this.cbx_NhaCungCap_SelectedIndexChanged_1);
            // 
            // txt_TienThanhToan
            // 
            this.txt_TienThanhToan.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_TienThanhToan.Location = new System.Drawing.Point(171, 77);
            this.txt_TienThanhToan.Name = "txt_TienThanhToan";
            this.txt_TienThanhToan.Size = new System.Drawing.Size(186, 27);
            this.txt_TienThanhToan.TabIndex = 11;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Huy.Location = new System.Drawing.Point(239, 521);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(199, 38);
            this.btn_Huy.TabIndex = 1;
            this.btn_Huy.Text = "Hủy đơn";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_XacNhan.Location = new System.Drawing.Point(17, 521);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(201, 38);
            this.btn_XacNhan.TabIndex = 1;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // txt_MaHoaDon
            // 
            this.txt_MaHoaDon.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_MaHoaDon.Location = new System.Drawing.Point(171, 31);
            this.txt_MaHoaDon.Name = "txt_MaHoaDon";
            this.txt_MaHoaDon.Size = new System.Drawing.Size(186, 27);
            this.txt_MaHoaDon.TabIndex = 12;
            // 
            // dgrid_ChiTietHoaDonNhap
            // 
            this.dgrid_ChiTietHoaDonNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ChiTietHoaDonNhap.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dgrid_ChiTietHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_ChiTietHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_ChiTietHoaDonNhap.Location = new System.Drawing.Point(3, 577);
            this.dgrid_ChiTietHoaDonNhap.Name = "dgrid_ChiTietHoaDonNhap";
            this.dgrid_ChiTietHoaDonNhap.RowHeadersWidth = 51;
            this.dgrid_ChiTietHoaDonNhap.RowTemplate.Height = 29;
            this.dgrid_ChiTietHoaDonNhap.Size = new System.Drawing.Size(444, 320);
            this.dgrid_ChiTietHoaDonNhap.TabIndex = 0;
            this.dgrid_ChiTietHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChiTietHoaDonNhap_CellClick);
            this.dgrid_ChiTietHoaDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_ChiTietHoaDonNhap_CellContentClick);
            // 
            // frm_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1310, 900);
            this.Controls.Add(this.gbx_ChiTietHoaDon);
            this.Controls.Add(this.gbx_MatHang);
            this.Controls.Add(this.gbx_HoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_HoaDonNhap";
            this.Text = "frm_HoaDonNhap";
            this.gbx_HoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_HoaDonNhap)).EndInit();
            this.gbx_MatHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MatHang)).EndInit();
            this.gbx_ChiTietHoaDon.ResumeLayout(false);
            this.gbx_ChiTietHoaDon.PerformLayout();
            this.gbx_NhaCungCap.ResumeLayout(false);
            this.gbx_NhaCungCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ChiTietHoaDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_HoaDon;
        private System.Windows.Forms.Button btn_AddHoaDon;
        private System.Windows.Forms.DataGridView dgrid_HoaDonNhap;
        private System.Windows.Forms.GroupBox gbx_MatHang;
        private System.Windows.Forms.DataGridView dgrid_MatHang;
        private System.Windows.Forms.GroupBox gbx_ChiTietHoaDon;
        private System.Windows.Forms.DataGridView dgrid_ChiTietHoaDonNhap;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.GroupBox gbx_NhaCungCap;
        private System.Windows.Forms.Button btn_AddNhaCungCap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox txt_TenNhaCungCap;
        private System.Windows.Forms.CheckBox chk_NhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_NhaCungCap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TienThanhToan;
        private System.Windows.Forms.TextBox txt_MaHoaDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtp_NgayTao;
    }
}