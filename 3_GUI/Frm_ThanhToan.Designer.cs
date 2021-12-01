
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
            this.txt_tong = new System.Windows.Forms.TextBox();
            this.txt_chiphikhac = new System.Windows.Forms.TextBox();
            this.txt_tiendv = new System.Windows.Forms.TextBox();
            this.txt_tienphong = new System.Windows.Forms.TextBox();
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
            this.dgv_chitietdichvu.Location = new System.Drawing.Point(-1, 83);
            this.dgv_chitietdichvu.MultiSelect = false;
            this.dgv_chitietdichvu.Name = "dgv_chitietdichvu";
            this.dgv_chitietdichvu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv_chitietdichvu.RowHeadersVisible = false;
            this.dgv_chitietdichvu.RowHeadersWidth = 51;
            this.dgv_chitietdichvu.RowTemplate.Height = 29;
            this.dgv_chitietdichvu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_chitietdichvu.Size = new System.Drawing.Size(1327, 400);
            this.dgv_chitietdichvu.TabIndex = 0;
            this.dgv_chitietdichvu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietdichvu_CellClick);
            // 
            // btn_thanhToanHoaDon
            // 
            this.btn_thanhToanHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_thanhToanHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thanhToanHoaDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_thanhToanHoaDon.Location = new System.Drawing.Point(214, 524);
            this.btn_thanhToanHoaDon.Name = "btn_thanhToanHoaDon";
            this.btn_thanhToanHoaDon.Size = new System.Drawing.Size(186, 63);
            this.btn_thanhToanHoaDon.TabIndex = 7;
            this.btn_thanhToanHoaDon.Text = "Thanh toán";
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
            // txt_tong
            // 
            this.txt_tong.Location = new System.Drawing.Point(181, 420);
            this.txt_tong.Name = "txt_tong";
            this.txt_tong.Size = new System.Drawing.Size(168, 27);
            this.txt_tong.TabIndex = 32;
            // 
            // txt_chiphikhac
            // 
            this.txt_chiphikhac.Location = new System.Drawing.Point(181, 185);
            this.txt_chiphikhac.Name = "txt_chiphikhac";
            this.txt_chiphikhac.Size = new System.Drawing.Size(168, 27);
            this.txt_chiphikhac.TabIndex = 31;
            // 
            // txt_tiendv
            // 
            this.txt_tiendv.Location = new System.Drawing.Point(181, 125);
            this.txt_tiendv.Name = "txt_tiendv";
            this.txt_tiendv.Size = new System.Drawing.Size(168, 27);
            this.txt_tiendv.TabIndex = 30;
            // 
            // txt_tienphong
            // 
            this.txt_tienphong.Location = new System.Drawing.Point(181, 66);
            this.txt_tienphong.Name = "txt_tienphong";
            this.txt_tienphong.Size = new System.Drawing.Size(168, 27);
            this.txt_tienphong.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Chi phí khác";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tổng tiền";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tiền Dịch vụ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
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
            this.dgv_MatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MatHang.Size = new System.Drawing.Size(1327, 400);
            this.dgv_MatHang.TabIndex = 11;
            this.dgv_MatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MatHang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbx_congthucTinh);
            this.panel1.Controls.Add(this.lbl_tenPhong);
            this.panel1.Controls.Add(this.btn_fakethanhtoan);
            this.panel1.Controls.Add(this.btn_thanhToanHoaDon);
            this.panel1.Controls.Add(this.txt_tong);
            this.panel1.Controls.Add(this.txt_chiphikhac);
            this.panel1.Controls.Add(this.txt_tiendv);
            this.panel1.Controls.Add(this.txt_tienphong);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(1332, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 864);
            this.panel1.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Công thức tính";
            // 
            // cbx_congthucTinh
            // 
            this.cbx_congthucTinh.FormattingEnabled = true;
            this.cbx_congthucTinh.Location = new System.Drawing.Point(181, 289);
            this.cbx_congthucTinh.Name = "cbx_congthucTinh";
            this.cbx_congthucTinh.Size = new System.Drawing.Size(151, 28);
            this.cbx_congthucTinh.TabIndex = 37;
            // 
            // lbl_tenPhong
            // 
            this.lbl_tenPhong.AutoSize = true;
            this.lbl_tenPhong.Location = new System.Drawing.Point(19, 23);
            this.lbl_tenPhong.Name = "lbl_tenPhong";
            this.lbl_tenPhong.Size = new System.Drawing.Size(78, 20);
            this.lbl_tenPhong.TabIndex = 42;
            this.lbl_tenPhong.Text = "Tên Phòng";
            // 
            // btn_fakethanhtoan
            // 
            this.btn_fakethanhtoan.BackColor = System.Drawing.Color.Tomato;
            this.btn_fakethanhtoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fakethanhtoan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_fakethanhtoan.Location = new System.Drawing.Point(0, 524);
            this.btn_fakethanhtoan.Name = "btn_fakethanhtoan";
            this.btn_fakethanhtoan.Size = new System.Drawing.Size(216, 63);
            this.btn_fakethanhtoan.TabIndex = 7;
            this.btn_fakethanhtoan.Text = "tạm tính";
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
            // Frm_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1732, 996);
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
        private System.Windows.Forms.TextBox txt_tong;
        private System.Windows.Forms.TextBox txt_chiphikhac;
        private System.Windows.Forms.TextBox txt_tiendv;
        private System.Windows.Forms.TextBox txt_tienphong;
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
    }
}