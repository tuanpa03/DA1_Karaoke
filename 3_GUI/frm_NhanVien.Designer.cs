﻿
namespace _3_GUI
{
    partial class frm_NhanVien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            this.dgr_NhanVien = new System.Windows.Forms.DataGridView();
            this.panel_dgr_NhanVien = new System.Windows.Forms.Panel();
            this.rbtn_BoiBan = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_SearchNhanVien = new System.Windows.Forms.TextBox();
            this.rbtn_LocNhanvien = new System.Windows.Forms.RadioButton();
            this.rbtn_LocChucVu = new System.Windows.Forms.RadioButton();
            this.rbtn_LocNone = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_DanhSach = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_TenDem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.txt_EmailLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbox_ChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn_Nu = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_Nam = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_CCCD = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).BeginInit();
            this.panel_dgr_NhanVien.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgr_NhanVien
            // 
            this.dgr_NhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgr_NhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgr_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgr_NhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgr_NhanVien.Location = new System.Drawing.Point(0, 40);
            this.dgr_NhanVien.Name = "dgr_NhanVien";
            this.dgr_NhanVien.RowHeadersWidth = 51;
            this.dgr_NhanVien.RowTemplate.Height = 29;
            this.dgr_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgr_NhanVien.Size = new System.Drawing.Size(1616, 450);
            this.dgr_NhanVien.TabIndex = 0;
            this.dgr_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgr_NhanVien_CellClick);
            // 
            // panel_dgr_NhanVien
            // 
            this.panel_dgr_NhanVien.Controls.Add(this.rbtn_BoiBan);
            this.panel_dgr_NhanVien.Controls.Add(this.label10);
            this.panel_dgr_NhanVien.Controls.Add(this.txt_SearchNhanVien);
            this.panel_dgr_NhanVien.Controls.Add(this.rbtn_LocNhanvien);
            this.panel_dgr_NhanVien.Controls.Add(this.rbtn_LocChucVu);
            this.panel_dgr_NhanVien.Controls.Add(this.rbtn_LocNone);
            this.panel_dgr_NhanVien.Controls.Add(this.label11);
            this.panel_dgr_NhanVien.Controls.Add(this.dgr_NhanVien);
            this.panel_dgr_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel_dgr_NhanVien.Location = new System.Drawing.Point(0, 460);
            this.panel_dgr_NhanVien.Name = "panel_dgr_NhanVien";
            this.panel_dgr_NhanVien.Size = new System.Drawing.Size(1616, 490);
            this.panel_dgr_NhanVien.TabIndex = 1;
            // 
            // rbtn_BoiBan
            // 
            this.rbtn_BoiBan.AutoSize = true;
            this.rbtn_BoiBan.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_BoiBan.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_BoiBan.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_BoiBan.Location = new System.Drawing.Point(388, 0);
            this.rbtn_BoiBan.Name = "rbtn_BoiBan";
            this.rbtn_BoiBan.Size = new System.Drawing.Size(102, 40);
            this.rbtn_BoiBan.TabIndex = 4;
            this.rbtn_BoiBan.TabStop = true;
            this.rbtn_BoiBan.Text = "Bồi bàn";
            this.rbtn_BoiBan.UseVisualStyleBackColor = false;
            this.rbtn_BoiBan.CheckedChanged += new System.EventHandler(this.rbtn_BoiBan_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Right;
            this.label10.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(946, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 32);
            this.label10.TabIndex = 2;
            this.label10.Text = "Search :";
            // 
            // txt_SearchNhanVien
            // 
            this.txt_SearchNhanVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_SearchNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_SearchNhanVien.Location = new System.Drawing.Point(1084, 0);
            this.txt_SearchNhanVien.Name = "txt_SearchNhanVien";
            this.txt_SearchNhanVien.PlaceholderText = "nhập tên nhân viên";
            this.txt_SearchNhanVien.Size = new System.Drawing.Size(532, 34);
            this.txt_SearchNhanVien.TabIndex = 3;
            this.txt_SearchNhanVien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SearchNhanVien_KeyUp);
            // 
            // rbtn_LocNhanvien
            // 
            this.rbtn_LocNhanvien.AutoSize = true;
            this.rbtn_LocNhanvien.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_LocNhanvien.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_LocNhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_LocNhanvien.Location = new System.Drawing.Point(262, 0);
            this.rbtn_LocNhanvien.Name = "rbtn_LocNhanvien";
            this.rbtn_LocNhanvien.Size = new System.Drawing.Size(126, 40);
            this.rbtn_LocNhanvien.TabIndex = 3;
            this.rbtn_LocNhanvien.TabStop = true;
            this.rbtn_LocNhanvien.Text = "Nhân viên";
            this.rbtn_LocNhanvien.UseVisualStyleBackColor = false;
            this.rbtn_LocNhanvien.CheckedChanged += new System.EventHandler(this.rbtn_LocNhanvien_CheckedChanged);
            // 
            // rbtn_LocChucVu
            // 
            this.rbtn_LocChucVu.AutoSize = true;
            this.rbtn_LocChucVu.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_LocChucVu.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_LocChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_LocChucVu.Location = new System.Drawing.Point(169, 0);
            this.rbtn_LocChucVu.Name = "rbtn_LocChucVu";
            this.rbtn_LocChucVu.Size = new System.Drawing.Size(93, 40);
            this.rbtn_LocChucVu.TabIndex = 3;
            this.rbtn_LocChucVu.TabStop = true;
            this.rbtn_LocChucVu.Text = "Admin";
            this.rbtn_LocChucVu.UseVisualStyleBackColor = false;
            this.rbtn_LocChucVu.CheckedChanged += new System.EventHandler(this.rbtn_LocChucVu_CheckedChanged);
            // 
            // rbtn_LocNone
            // 
            this.rbtn_LocNone.AutoSize = true;
            this.rbtn_LocNone.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_LocNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_LocNone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbtn_LocNone.Location = new System.Drawing.Point(83, 0);
            this.rbtn_LocNone.Name = "rbtn_LocNone";
            this.rbtn_LocNone.Size = new System.Drawing.Size(86, 40);
            this.rbtn_LocNone.TabIndex = 3;
            this.rbtn_LocNone.TabStop = true;
            this.rbtn_LocNone.Text = "Tất cả";
            this.rbtn_LocNone.UseVisualStyleBackColor = false;
            this.rbtn_LocNone.CheckedChanged += new System.EventHandler(this.rbtn_LocNone_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Broadway", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 32);
            this.label11.TabIndex = 2;
            this.label11.Text = "Lọc :";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Them.Location = new System.Drawing.Point(28, 36);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(156, 54);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "      Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btn_Luu);
            this.groupBox2.Controls.Add(this.btn_DanhSach);
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1616, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CHỨC NĂNG";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(819, 47);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(586, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(222, 47);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(404, 47);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Luu.Location = new System.Drawing.Point(804, 36);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(159, 54);
            this.btn_Luu.TabIndex = 1;
            this.btn_Luu.Text = "   Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_DanhSach
            // 
            this.btn_DanhSach.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DanhSach.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DanhSach.Location = new System.Drawing.Point(576, 36);
            this.btn_DanhSach.Name = "btn_DanhSach";
            this.btn_DanhSach.Size = new System.Drawing.Size(184, 54);
            this.btn_DanhSach.TabIndex = 1;
            this.btn_DanhSach.Text = "      Danh sách";
            this.btn_DanhSach.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Xoa.Location = new System.Drawing.Point(209, 36);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(156, 54);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "      Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Sua.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Sua.Location = new System.Drawing.Point(391, 36);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(156, 54);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "      Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbl_Timer);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1616, 79);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Timer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Timer.Location = new System.Drawing.Point(713, 16);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(882, 42);
            this.lbl_Timer.TabIndex = 0;
            this.lbl_Timer.Text = "KARAOKE FAMILY - 216 Phúc Tân - Hoàn Kiếm - Hà Nội";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_MaNhanVien);
            this.groupBox3.Controls.Add(this.txt_Ho);
            this.groupBox3.Controls.Add(this.txt_TenDem);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txt_Ten);
            this.groupBox3.Controls.Add(this.txt_EmailLogin);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(3, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 230);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_MaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txt_MaNhanVien.Location = new System.Drawing.Point(159, 25);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(413, 34);
            this.txt_MaNhanVien.TabIndex = 3;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ho.ForeColor = System.Drawing.Color.Black;
            this.txt_Ho.Location = new System.Drawing.Point(159, 64);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(413, 34);
            this.txt_Ho.TabIndex = 3;
            // 
            // txt_TenDem
            // 
            this.txt_TenDem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenDem.ForeColor = System.Drawing.Color.Black;
            this.txt_TenDem.Location = new System.Drawing.Point(159, 102);
            this.txt_TenDem.Name = "txt_TenDem";
            this.txt_TenDem.Size = new System.Drawing.Size(413, 34);
            this.txt_TenDem.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã NV :";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Ten.ForeColor = System.Drawing.Color.Black;
            this.txt_Ten.Location = new System.Drawing.Point(159, 140);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(413, 34);
            this.txt_Ten.TabIndex = 3;
            // 
            // txt_EmailLogin
            // 
            this.txt_EmailLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_EmailLogin.ForeColor = System.Drawing.Color.Black;
            this.txt_EmailLogin.Location = new System.Drawing.Point(159, 180);
            this.txt_EmailLogin.Name = "txt_EmailLogin";
            this.txt_EmailLogin.Size = new System.Drawing.Size(413, 34);
            this.txt_EmailLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(25, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(25, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 31);
            this.label12.TabIndex = 2;
            this.label12.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên đệm :";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính :";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(20, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "Điện thoại :";
            // 
            // cbox_ChucVu
            // 
            this.cbox_ChucVu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbox_ChucVu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbox_ChucVu.ForeColor = System.Drawing.Color.Black;
            this.cbox_ChucVu.FormattingEnabled = true;
            this.cbox_ChucVu.Location = new System.Drawing.Point(166, 63);
            this.cbox_ChucVu.Name = "cbox_ChucVu";
            this.cbox_ChucVu.Size = new System.Drawing.Size(419, 36);
            this.cbox_ChucVu.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(20, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 31);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chức vụ :";
            // 
            // rbtn_Nu
            // 
            this.rbtn_Nu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_Nu.AutoSize = true;
            this.rbtn_Nu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nu.ForeColor = System.Drawing.Color.Black;
            this.rbtn_Nu.Location = new System.Drawing.Point(290, 25);
            this.rbtn_Nu.Name = "rbtn_Nu";
            this.rbtn_Nu.Size = new System.Drawing.Size(66, 35);
            this.rbtn_Nu.TabIndex = 4;
            this.rbtn_Nu.TabStop = true;
            this.rbtn_Nu.Text = "Nữ";
            this.rbtn_Nu.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "Địa chỉ :";
            // 
            // rbtn_Nam
            // 
            this.rbtn_Nam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbtn_Nam.AutoSize = true;
            this.rbtn_Nam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtn_Nam.ForeColor = System.Drawing.Color.Black;
            this.rbtn_Nam.Location = new System.Drawing.Point(166, 25);
            this.rbtn_Nam.Name = "rbtn_Nam";
            this.rbtn_Nam.Size = new System.Drawing.Size(84, 35);
            this.rbtn_Nam.TabIndex = 4;
            this.rbtn_Nam.TabStop = true;
            this.rbtn_Nam.Text = "Nam";
            this.rbtn_Nam.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "CCCD  :";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiaChi.ForeColor = System.Drawing.Color.Black;
            this.txt_DiaChi.Location = new System.Drawing.Point(166, 180);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(419, 34);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_DienThoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DienThoai.ForeColor = System.Drawing.Color.Black;
            this.txt_DienThoai.Location = new System.Drawing.Point(166, 102);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(419, 34);
            this.txt_DienThoai.TabIndex = 3;
            // 
            // txt_CCCD
            // 
            this.txt_CCCD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_CCCD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CCCD.ForeColor = System.Drawing.Color.Black;
            this.txt_CCCD.Location = new System.Drawing.Point(166, 140);
            this.txt_CCCD.Name = "txt_CCCD";
            this.txt_CCCD.Size = new System.Drawing.Size(419, 34);
            this.txt_CCCD.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1616, 280);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CÁ NHÂN";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cbox_ChucVu);
            this.groupBox4.Controls.Add(this.txt_CCCD);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txt_DienThoai);
            this.groupBox4.Controls.Add(this.txt_DiaChi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.rbtn_Nam);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.rbtn_Nu);
            this.groupBox4.Location = new System.Drawing.Point(638, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(598, 230);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1616, 950);
            this.Controls.Add(this.panel_dgr_NhanVien);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân_Viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgr_NhanVien)).EndInit();
            this.panel_dgr_NhanVien.ResumeLayout(false);
            this.panel_dgr_NhanVien.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgr_NhanVien;
        private System.Windows.Forms.Panel panel_dgr_NhanVien;
        private System.Windows.Forms.RadioButton rbtn_BoiBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_SearchNhanVien;
        private System.Windows.Forms.RadioButton rbtn_LocNhanvien;
        private System.Windows.Forms.RadioButton rbtn_LocChucVu;
        private System.Windows.Forms.RadioButton rbtn_LocNone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_DanhSach;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.ComboBox cbox_ChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_TenDem;
        private System.Windows.Forms.RadioButton rbtn_Nu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.RadioButton rbtn_Nam;
        private System.Windows.Forms.TextBox txt_EmailLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_CCCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}