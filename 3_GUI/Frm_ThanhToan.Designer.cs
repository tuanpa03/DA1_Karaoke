﻿
namespace _3_GUI_PresentationLayer
{
    partial class Frm_ThanhToan
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
            this.dgv_chitietdichvu = new System.Windows.Forms.DataGridView();
            this.btn_thanhToanHoaDon = new System.Windows.Forms.Button();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgv_MatHang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_congthucTinh = new System.Windows.Forms.ComboBox();
            this.lbl_tenPhong = new System.Windows.Forms.Label();
            this.btn_fakethanhtoan = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_tienphong = new System.Windows.Forms.Label();
            this.txt_tiendv = new System.Windows.Forms.Label();
            this.txt_chiphikhac = new System.Windows.Forms.TextBox();
            this.trakhach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.Label();
            this.txt_khachtra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdichvu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_chitietdichvu
            // 
            this.dgv_chitietdichvu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_chitietdichvu.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_chitietdichvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietdichvu.EnableHeadersVisualStyles = false;
            this.dgv_chitietdichvu.Location = new System.Drawing.Point(-14, 83);
            this.dgv_chitietdichvu.MultiSelect = false;
            this.dgv_chitietdichvu.Name = "dgv_chitietdichvu";
            this.dgv_chitietdichvu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_chitietdichvu.RowHeadersVisible = false;
            this.dgv_chitietdichvu.RowHeadersWidth = 51;
            this.dgv_chitietdichvu.RowTemplate.Height = 29;
            this.dgv_chitietdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_chitietdichvu.Size = new System.Drawing.Size(1225, 400);
            this.dgv_chitietdichvu.TabIndex = 0;
            this.dgv_chitietdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietdichvu_CellClick);
            // 
            // btn_thanhToanHoaDon
            // 
            this.btn_thanhToanHoaDon.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_thanhToanHoaDon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_thanhToanHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_thanhToanHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhToanHoaDon.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thanhToanHoaDon.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_thanhToanHoaDon.Location = new System.Drawing.Point(214, 524);
            this.btn_thanhToanHoaDon.Name = "btn_thanhToanHoaDon";
            this.btn_thanhToanHoaDon.Size = new System.Drawing.Size(186, 63);
            this.btn_thanhToanHoaDon.TabIndex = 7;
            this.btn_thanhToanHoaDon.Text = "Thanh Toán";
            this.btn_thanhToanHoaDon.UseVisualStyleBackColor = false;
            this.btn_thanhToanHoaDon.Click += new System.EventHandler(this.btn_thanhToanHoaDon_Click);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(12, 12);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(162, 65);
            this.btn_thoat.TabIndex = 34;
            this.btn_thoat.Text = "Back";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(30, 175);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 31);
            this.label13.TabIndex = 28;
            this.label13.Text = "Chi phí khác :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(58, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 31);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tổng tiền :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(30, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 31);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tiền Dịch vụ :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(39, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 31);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tiền phòng :";
            // 
            // dgv_MatHang
            // 
            this.dgv_MatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MatHang.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_MatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MatHang.Location = new System.Drawing.Point(-1, 547);
            this.dgv_MatHang.Name = "dgv_MatHang";
            this.dgv_MatHang.RowHeadersWidth = 51;
            this.dgv_MatHang.RowTemplate.Height = 29;
            this.dgv_MatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_MatHang.Size = new System.Drawing.Size(1212, 400);
            this.dgv_MatHang.TabIndex = 11;
            this.dgv_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MatHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txt_tongtien);
            this.panel1.Controls.Add(this.txt_tiendv);
            this.panel1.Controls.Add(this.txt_tienphong);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbx_congthucTinh);
            this.panel1.Controls.Add(this.lbl_tenPhong);
            this.panel1.Controls.Add(this.btn_fakethanhtoan);
            this.panel1.Controls.Add(this.btn_thanhToanHoaDon);
            this.panel1.Controls.Add(this.trakhach);
            this.panel1.Controls.Add(this.txt_khachtra);
            this.panel1.Controls.Add(this.txt_chiphikhac);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1217, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 864);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 31);
            this.label7.TabIndex = 38;
            this.label7.Text = "Công thức tính :";
            // 
            // cbx_congthucTinh
            // 
            this.cbx_congthucTinh.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_congthucTinh.FormattingEnabled = true;
            this.cbx_congthucTinh.Location = new System.Drawing.Point(199, 227);
            this.cbx_congthucTinh.Name = "cbx_congthucTinh";
            this.cbx_congthucTinh.Size = new System.Drawing.Size(188, 33);
            this.cbx_congthucTinh.TabIndex = 37;
            // 
            // lbl_tenPhong
            // 
            this.lbl_tenPhong.AutoSize = true;
            this.lbl_tenPhong.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_tenPhong.ForeColor = System.Drawing.Color.Green;
            this.lbl_tenPhong.Location = new System.Drawing.Point(117, 10);
            this.lbl_tenPhong.Name = "lbl_tenPhong";
            this.lbl_tenPhong.Size = new System.Drawing.Size(166, 41);
            this.lbl_tenPhong.TabIndex = 42;
            this.lbl_tenPhong.Text = "Tên Phòng";
            // 
            // btn_fakethanhtoan
            // 
            this.btn_fakethanhtoan.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_fakethanhtoan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_fakethanhtoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btn_fakethanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fakethanhtoan.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fakethanhtoan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_fakethanhtoan.Location = new System.Drawing.Point(0, 524);
            this.btn_fakethanhtoan.Name = "btn_fakethanhtoan";
            this.btn_fakethanhtoan.Size = new System.Drawing.Size(216, 63);
            this.btn_fakethanhtoan.TabIndex = 7;
            this.btn_fakethanhtoan.Text = "Tạm Tính";
            this.btn_fakethanhtoan.UseVisualStyleBackColor = false;
            this.btn_fakethanhtoan.Click += new System.EventHandler(this.btn_fakethanhtoan_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(12, 496);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(372, 27);
            this.txt_search.TabIndex = 12;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // txt_tienphong
            // 
            this.txt_tienphong.AutoSize = true;
            this.txt_tienphong.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tienphong.Location = new System.Drawing.Point(214, 75);
            this.txt_tienphong.Name = "txt_tienphong";
            this.txt_tienphong.Size = new System.Drawing.Size(81, 31);
            this.txt_tienphong.TabIndex = 43;
            this.txt_tienphong.Text = "phong";
            // 
            // txt_tiendv
            // 
            this.txt_tiendv.AutoSize = true;
            this.txt_tiendv.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tiendv.Location = new System.Drawing.Point(214, 125);
            this.txt_tiendv.Name = "txt_tiendv";
            this.txt_tiendv.Size = new System.Drawing.Size(82, 31);
            this.txt_tiendv.TabIndex = 43;
            this.txt_tiendv.Text = "dichvu";
            // 
            // txt_chiphikhac
            // 
            this.txt_chiphikhac.Location = new System.Drawing.Point(199, 175);
            this.txt_chiphikhac.Multiline = true;
            this.txt_chiphikhac.Name = "txt_chiphikhac";
            this.txt_chiphikhac.Size = new System.Drawing.Size(188, 31);
            this.txt_chiphikhac.TabIndex = 32;
            // 
            // trakhach
            // 
            this.trakhach.Location = new System.Drawing.Point(199, 325);
            this.trakhach.Multiline = true;
            this.trakhach.Name = "trakhach";
            this.trakhach.Size = new System.Drawing.Size(188, 31);
            this.trakhach.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tiền khách trả :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 31);
            this.label2.TabIndex = 38;
            this.label2.Text = "Tiền trả khác :";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.AutoSize = true;
            this.txt_tongtien.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tongtien.Location = new System.Drawing.Point(214, 413);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(26, 31);
            this.txt_tongtien.TabIndex = 43;
            this.txt_tongtien.Text = "0";
            // 
            // txt_khachtra
            // 
            this.txt_khachtra.Location = new System.Drawing.Point(199, 275);
            this.txt_khachtra.Multiline = true;
            this.txt_khachtra.Name = "txt_khachtra";
            this.txt_khachtra.Size = new System.Drawing.Size(188, 31);
            this.txt_khachtra.TabIndex = 32;
            // 
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1616, 1087);
            this.Controls.Add(this.dgv_MatHang);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_chitietdichvu);
            this.Controls.Add(this.btn_thoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ThanhToan";
            this.Text = "Frm_ThanhToan";
            this.Load += new System.EventHandler(this.Frm_ThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietdichvu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MatHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_chitietdichvu;
        private System.Windows.Forms.Button btn_thanhToanHoaDon;
        private System.Windows.Forms.DataGridView dgv_MatHang;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbx_congthucTinh;
        private System.Windows.Forms.Label lbl_tenPhong;
        private System.Windows.Forms.Button btn_fakethanhtoan;
        private System.Windows.Forms.Label txt_tongtien;
        private System.Windows.Forms.Label txt_tiendv;
        private System.Windows.Forms.Label txt_tienphong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox trakhach;
        private System.Windows.Forms.TextBox txt_chiphikhac;
        private System.Windows.Forms.TextBox txt_khachtra;
    }
}