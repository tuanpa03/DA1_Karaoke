
namespace _3_GUI
{
    partial class frm_Phong
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
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xóa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_nguoiTao = new System.Windows.Forms.TextBox();
            this.tbx_ngayCapNhap = new System.Windows.Forms.TextBox();
            this.tbx_nguoiCapNhap = new System.Windows.Forms.TextBox();
            this.tbx_ngayTao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbx_tenPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbx_SucChua = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_loaiPhong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_idtang = new System.Windows.Forms.ComboBox();
            this.cbb_trangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(189, 302);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(111, 36);
            this.btn_sua.TabIndex = 40;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xóa
            // 
            this.btn_xóa.Location = new System.Drawing.Point(376, 302);
            this.btn_xóa.Name = "btn_xóa";
            this.btn_xóa.Size = new System.Drawing.Size(121, 36);
            this.btn_xóa.TabIndex = 39;
            this.btn_xóa.Text = "Xóa";
            this.btn_xóa.UseVisualStyleBackColor = true;
            this.btn_xóa.Click += new System.EventHandler(this.btn_xóa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(772, 302);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(123, 36);
            this.btn_dong.TabIndex = 38;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(41, 302);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(108, 36);
            this.btn_them.TabIndex = 37;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 426);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 35;
            // 
            // tbx_nguoiTao
            // 
            this.tbx_nguoiTao.Location = new System.Drawing.Point(517, 53);
            this.tbx_nguoiTao.Name = "tbx_nguoiTao";
            this.tbx_nguoiTao.Size = new System.Drawing.Size(143, 27);
            this.tbx_nguoiTao.TabIndex = 34;
            this.tbx_nguoiTao.Text = "Admin";
            // 
            // tbx_ngayCapNhap
            // 
            this.tbx_ngayCapNhap.Enabled = false;
            this.tbx_ngayCapNhap.Location = new System.Drawing.Point(878, 150);
            this.tbx_ngayCapNhap.Name = "tbx_ngayCapNhap";
            this.tbx_ngayCapNhap.Size = new System.Drawing.Size(151, 27);
            this.tbx_ngayCapNhap.TabIndex = 33;
            // 
            // tbx_nguoiCapNhap
            // 
            this.tbx_nguoiCapNhap.Location = new System.Drawing.Point(878, 49);
            this.tbx_nguoiCapNhap.Name = "tbx_nguoiCapNhap";
            this.tbx_nguoiCapNhap.Size = new System.Drawing.Size(151, 27);
            this.tbx_nguoiCapNhap.TabIndex = 32;
            this.tbx_nguoiCapNhap.Text = "Admin";
            // 
            // tbx_ngayTao
            // 
            this.tbx_ngayTao.Enabled = false;
            this.tbx_ngayTao.Location = new System.Drawing.Point(517, 150);
            this.tbx_ngayTao.Name = "tbx_ngayTao";
            this.tbx_ngayTao.Size = new System.Drawing.Size(143, 27);
            this.tbx_ngayTao.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Người tạo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(704, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Người cập nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(711, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày cập nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Phòng";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1690, 418);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tbx_tenPhong
            // 
            this.tbx_tenPhong.Location = new System.Drawing.Point(116, 42);
            this.tbx_tenPhong.Name = "tbx_tenPhong";
            this.tbx_tenPhong.Size = new System.Drawing.Size(145, 27);
            this.tbx_tenPhong.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Sức chứa";
            // 
            // tbx_SucChua
            // 
            this.tbx_SucChua.Location = new System.Drawing.Point(118, 153);
            this.tbx_SucChua.Name = "tbx_SucChua";
            this.tbx_SucChua.Size = new System.Drawing.Size(143, 27);
            this.tbx_SucChua.TabIndex = 44;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(566, 302);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(124, 36);
            this.btn_clear.TabIndex = 45;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 48;
            this.label9.Text = "Mã loại phòng";
            // 
            // cmb_loaiPhong
            // 
            this.cmb_loaiPhong.FormattingEnabled = true;
            this.cmb_loaiPhong.Location = new System.Drawing.Point(116, 93);
            this.cmb_loaiPhong.Name = "cmb_loaiPhong";
            this.cmb_loaiPhong.Size = new System.Drawing.Size(151, 28);
            this.cmb_loaiPhong.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Tầng";
            // 
            // cbb_idtang
            // 
            this.cbb_idtang.FormattingEnabled = true;
            this.cbb_idtang.Location = new System.Drawing.Point(118, 219);
            this.cbb_idtang.Name = "cbb_idtang";
            this.cbb_idtang.Size = new System.Drawing.Size(151, 28);
            this.cbb_idtang.TabIndex = 52;
            // 
            // cbb_trangThai
            // 
            this.cbb_trangThai.FormattingEnabled = true;
            this.cbb_trangThai.Location = new System.Drawing.Point(517, 219);
            this.cbb_trangThai.Name = "cbb_trangThai";
            this.cbb_trangThai.Size = new System.Drawing.Size(151, 28);
            this.cbb_trangThai.TabIndex = 53;
            // 
            // frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1690, 788);
            this.Controls.Add(this.cbb_trangThai);
            this.Controls.Add(this.cbb_idtang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_loaiPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.tbx_SucChua);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xóa);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_nguoiTao);
            this.Controls.Add(this.tbx_ngayCapNhap);
            this.Controls.Add(this.tbx_nguoiCapNhap);
            this.Controls.Add(this.tbx_ngayTao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbx_tenPhong);
            this.Name = "frm_Phong";
            this.Text = "frm_Phong";
            this.Load += new System.EventHandler(this.frm_Phong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xóa;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_nguoiTao;
        private System.Windows.Forms.TextBox tbx_ngayCapNhap;
        private System.Windows.Forms.TextBox tbx_nguoiCapNhap;
        private System.Windows.Forms.TextBox tbx_ngayTao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbx_tenPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbx_SucChua;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_loaiPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_idtang;
        private System.Windows.Forms.ComboBox cbb_trangThai;
    }
}