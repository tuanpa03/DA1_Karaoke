﻿
namespace _3_GUI
{
    partial class frm_LoaiPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LoaiPhong));
            this.dgv_loaiPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_tenLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbx_donGia = new System.Windows.Forms.TextBox();
            this.btn_themLoaiPhong = new System.Windows.Forms.Button();
            this.btn_xoaLoaiPhong = new System.Windows.Forms.Button();
            this.btn_suaLoaiPhong = new System.Windows.Forms.Button();
            this.btn_clearLoaiPhong = new System.Windows.Forms.Button();
            this.gbx_loaiPhong = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbx_TrangThaiLoaiPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbx_tang = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_tang = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_TrangThaiTang = new System.Windows.Forms.TextBox();
            this.btn_ClearTang = new System.Windows.Forms.Button();
            this.btn_XoaTang = new System.Windows.Forms.Button();
            this.btn_SuaTang = new System.Windows.Forms.Button();
            this.btn_ThemTang = new System.Windows.Forms.Button();
            this.tbx_soLuongPhong = new System.Windows.Forms.TextBox();
            this.tbx_tenTang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.laaaa = new System.Windows.Forms.Label();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).BeginInit();
            this.gbx_loaiPhong.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbx_tang.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_loaiPhong
            // 
            this.dgv_loaiPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loaiPhong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_loaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_loaiPhong.Location = new System.Drawing.Point(3, 30);
            this.dgv_loaiPhong.Name = "dgv_loaiPhong";
            this.dgv_loaiPhong.RowHeadersWidth = 51;
            this.dgv_loaiPhong.RowTemplate.Height = 29;
            this.dgv_loaiPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_loaiPhong.Size = new System.Drawing.Size(1604, 232);
            this.dgv_loaiPhong.TabIndex = 2;
            this.dgv_loaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Loại Phòng :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(614, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 31);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn Giá :";
            // 
            // tbx_tenLoaiPhong
            // 
            this.tbx_tenLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_tenLoaiPhong.Location = new System.Drawing.Point(245, 52);
            this.tbx_tenLoaiPhong.Name = "tbx_tenLoaiPhong";
            this.tbx_tenLoaiPhong.Size = new System.Drawing.Size(333, 34);
            this.tbx_tenLoaiPhong.TabIndex = 9;
            // 
            // tbx_donGia
            // 
            this.tbx_donGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_donGia.Location = new System.Drawing.Point(739, 52);
            this.tbx_donGia.Name = "tbx_donGia";
            this.tbx_donGia.Size = new System.Drawing.Size(333, 34);
            this.tbx_donGia.TabIndex = 11;
            // 
            // btn_themLoaiPhong
            // 
            this.btn_themLoaiPhong.BackColor = System.Drawing.Color.Aqua;
            this.btn_themLoaiPhong.Location = new System.Drawing.Point(245, 118);
            this.btn_themLoaiPhong.Name = "btn_themLoaiPhong";
            this.btn_themLoaiPhong.Size = new System.Drawing.Size(168, 49);
            this.btn_themLoaiPhong.TabIndex = 17;
            this.btn_themLoaiPhong.Text = "      Thêm";
            this.btn_themLoaiPhong.UseVisualStyleBackColor = false;
            this.btn_themLoaiPhong.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoaLoaiPhong
            // 
            this.btn_xoaLoaiPhong.BackColor = System.Drawing.Color.Aqua;
            this.btn_xoaLoaiPhong.Location = new System.Drawing.Point(715, 118);
            this.btn_xoaLoaiPhong.Name = "btn_xoaLoaiPhong";
            this.btn_xoaLoaiPhong.Size = new System.Drawing.Size(168, 49);
            this.btn_xoaLoaiPhong.TabIndex = 19;
            this.btn_xoaLoaiPhong.Text = "      Xóa";
            this.btn_xoaLoaiPhong.UseVisualStyleBackColor = false;
            this.btn_xoaLoaiPhong.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_suaLoaiPhong
            // 
            this.btn_suaLoaiPhong.BackColor = System.Drawing.Color.Aqua;
            this.btn_suaLoaiPhong.Location = new System.Drawing.Point(480, 118);
            this.btn_suaLoaiPhong.Name = "btn_suaLoaiPhong";
            this.btn_suaLoaiPhong.Size = new System.Drawing.Size(168, 49);
            this.btn_suaLoaiPhong.TabIndex = 20;
            this.btn_suaLoaiPhong.Text = "      Sửa";
            this.btn_suaLoaiPhong.UseVisualStyleBackColor = false;
            this.btn_suaLoaiPhong.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clearLoaiPhong
            // 
            this.btn_clearLoaiPhong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_clearLoaiPhong.ForeColor = System.Drawing.Color.White;
            this.btn_clearLoaiPhong.Location = new System.Drawing.Point(950, 118);
            this.btn_clearLoaiPhong.Name = "btn_clearLoaiPhong";
            this.btn_clearLoaiPhong.Size = new System.Drawing.Size(168, 49);
            this.btn_clearLoaiPhong.TabIndex = 21;
            this.btn_clearLoaiPhong.Text = "      Clear";
            this.btn_clearLoaiPhong.UseVisualStyleBackColor = false;
            this.btn_clearLoaiPhong.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // gbx_loaiPhong
            // 
            this.gbx_loaiPhong.Controls.Add(this.groupBox2);
            this.gbx_loaiPhong.Controls.Add(this.pictureBox7);
            this.gbx_loaiPhong.Controls.Add(this.pictureBox6);
            this.gbx_loaiPhong.Controls.Add(this.pictureBox4);
            this.gbx_loaiPhong.Controls.Add(this.pictureBox1);
            this.gbx_loaiPhong.Controls.Add(this.btn_themLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.btn_suaLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.tbx_TrangThaiLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.btn_xoaLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.label4);
            this.gbx_loaiPhong.Controls.Add(this.btn_clearLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.label1);
            this.gbx_loaiPhong.Controls.Add(this.tbx_tenLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.label6);
            this.gbx_loaiPhong.Controls.Add(this.tbx_donGia);
            this.gbx_loaiPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_loaiPhong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbx_loaiPhong.Location = new System.Drawing.Point(0, 79);
            this.gbx_loaiPhong.Name = "gbx_loaiPhong";
            this.gbx_loaiPhong.Size = new System.Drawing.Size(1616, 441);
            this.gbx_loaiPhong.TabIndex = 22;
            this.gbx_loaiPhong.TabStop = false;
            this.gbx_loaiPhong.Text = "Loại Phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_loaiPhong);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(3, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1610, 265);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(971, 128);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(739, 128);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(509, 128);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // tbx_TrangThaiLoaiPhong
            // 
            this.tbx_TrangThaiLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_TrangThaiLoaiPhong.Location = new System.Drawing.Point(1246, 52);
            this.tbx_TrangThaiLoaiPhong.Name = "tbx_TrangThaiLoaiPhong";
            this.tbx_TrangThaiLoaiPhong.Size = new System.Drawing.Size(333, 34);
            this.tbx_TrangThaiLoaiPhong.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1105, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Trạng Thái :";
            // 
            // gbx_tang
            // 
            this.gbx_tang.Controls.Add(this.groupBox1);
            this.gbx_tang.Controls.Add(this.pictureBox8);
            this.gbx_tang.Controls.Add(this.pictureBox2);
            this.gbx_tang.Controls.Add(this.pictureBox5);
            this.gbx_tang.Controls.Add(this.pictureBox3);
            this.gbx_tang.Controls.Add(this.label2);
            this.gbx_tang.Controls.Add(this.tbx_TrangThaiTang);
            this.gbx_tang.Controls.Add(this.btn_ClearTang);
            this.gbx_tang.Controls.Add(this.btn_XoaTang);
            this.gbx_tang.Controls.Add(this.btn_SuaTang);
            this.gbx_tang.Controls.Add(this.btn_ThemTang);
            this.gbx_tang.Controls.Add(this.tbx_soLuongPhong);
            this.gbx_tang.Controls.Add(this.tbx_tenTang);
            this.gbx_tang.Controls.Add(this.label3);
            this.gbx_tang.Controls.Add(this.laaaa);
            this.gbx_tang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_tang.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbx_tang.Location = new System.Drawing.Point(0, 520);
            this.gbx_tang.Name = "gbx_tang";
            this.gbx_tang.Size = new System.Drawing.Size(1616, 430);
            this.gbx_tang.TabIndex = 23;
            this.gbx_tang.TabStop = false;
            this.gbx_tang.Text = "Tầng ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_tang);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1610, 278);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // dgv_tang
            // 
            this.dgv_tang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_tang.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tang.Location = new System.Drawing.Point(3, 30);
            this.dgv_tang.Name = "dgv_tang";
            this.dgv_tang.RowHeadersWidth = 51;
            this.dgv_tang.RowTemplate.Height = 29;
            this.dgv_tang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tang.Size = new System.Drawing.Size(1604, 245);
            this.dgv_tang.TabIndex = 22;
            this.dgv_tang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tang_CellClick);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(971, 104);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 30);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(739, 104);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(509, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1112, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Trạng thái :";
            // 
            // tbx_TrangThaiTang
            // 
            this.tbx_TrangThaiTang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_TrangThaiTang.Location = new System.Drawing.Point(1248, 38);
            this.tbx_TrangThaiTang.Name = "tbx_TrangThaiTang";
            this.tbx_TrangThaiTang.Size = new System.Drawing.Size(333, 34);
            this.tbx_TrangThaiTang.TabIndex = 23;
            // 
            // btn_ClearTang
            // 
            this.btn_ClearTang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ClearTang.ForeColor = System.Drawing.Color.White;
            this.btn_ClearTang.Location = new System.Drawing.Point(950, 94);
            this.btn_ClearTang.Name = "btn_ClearTang";
            this.btn_ClearTang.Size = new System.Drawing.Size(168, 49);
            this.btn_ClearTang.TabIndex = 22;
            this.btn_ClearTang.Text = "      Clear";
            this.btn_ClearTang.UseVisualStyleBackColor = false;
            this.btn_ClearTang.Click += new System.EventHandler(this.btn_ClearTang_Click);
            // 
            // btn_XoaTang
            // 
            this.btn_XoaTang.BackColor = System.Drawing.Color.Aqua;
            this.btn_XoaTang.Location = new System.Drawing.Point(715, 94);
            this.btn_XoaTang.Name = "btn_XoaTang";
            this.btn_XoaTang.Size = new System.Drawing.Size(168, 49);
            this.btn_XoaTang.TabIndex = 22;
            this.btn_XoaTang.Text = "      Xóa";
            this.btn_XoaTang.UseVisualStyleBackColor = false;
            this.btn_XoaTang.Click += new System.EventHandler(this.btn_XoaTang_Click);
            // 
            // btn_SuaTang
            // 
            this.btn_SuaTang.BackColor = System.Drawing.Color.Aqua;
            this.btn_SuaTang.Location = new System.Drawing.Point(480, 94);
            this.btn_SuaTang.Name = "btn_SuaTang";
            this.btn_SuaTang.Size = new System.Drawing.Size(168, 49);
            this.btn_SuaTang.TabIndex = 22;
            this.btn_SuaTang.Text = "      Sửa";
            this.btn_SuaTang.UseVisualStyleBackColor = false;
            this.btn_SuaTang.Click += new System.EventHandler(this.btn_SuaTang_Click);
            // 
            // btn_ThemTang
            // 
            this.btn_ThemTang.BackColor = System.Drawing.Color.Aqua;
            this.btn_ThemTang.Location = new System.Drawing.Point(245, 94);
            this.btn_ThemTang.Name = "btn_ThemTang";
            this.btn_ThemTang.Size = new System.Drawing.Size(168, 49);
            this.btn_ThemTang.TabIndex = 22;
            this.btn_ThemTang.Text = "      Thêm";
            this.btn_ThemTang.UseVisualStyleBackColor = false;
            this.btn_ThemTang.Click += new System.EventHandler(this.btn_ThemTang_Click);
            // 
            // tbx_soLuongPhong
            // 
            this.tbx_soLuongPhong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_soLuongPhong.Location = new System.Drawing.Point(722, 38);
            this.tbx_soLuongPhong.Name = "tbx_soLuongPhong";
            this.tbx_soLuongPhong.Size = new System.Drawing.Size(333, 34);
            this.tbx_soLuongPhong.TabIndex = 11;
            // 
            // tbx_tenTang
            // 
            this.tbx_tenTang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbx_tenTang.Location = new System.Drawing.Point(152, 38);
            this.tbx_tenTang.Name = "tbx_tenTang";
            this.tbx_tenTang.Size = new System.Drawing.Size(333, 34);
            this.tbx_tenTang.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(509, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng Phòng :";
            // 
            // laaaa
            // 
            this.laaaa.AutoSize = true;
            this.laaaa.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laaaa.Location = new System.Drawing.Point(68, 40);
            this.laaaa.Name = "laaaa";
            this.laaaa.Size = new System.Drawing.Size(78, 31);
            this.laaaa.TabIndex = 0;
            this.laaaa.Text = "Tầng :";
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Timer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Timer.Location = new System.Drawing.Point(722, 23);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(882, 42);
            this.lbl_Timer.TabIndex = 1;
            this.lbl_Timer.Text = "KARAOKE FAMILY - 216 Phúc Tân - Hoàn Kiếm - Hà Nội";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.lbl_Timer);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1616, 79);
            this.groupBox3.TabIndex = 57;
            this.groupBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1616, 950);
            this.Controls.Add(this.gbx_loaiPhong);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbx_tang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_LoaiPhong";
            this.Text = "frm_LoaiPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).EndInit();
            this.gbx_loaiPhong.ResumeLayout(false);
            this.gbx_loaiPhong.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbx_tang.ResumeLayout(false);
            this.gbx_tang.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_loaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_tenLoaiPhong;
        private System.Windows.Forms.TextBox tbx_donGia;
        private System.Windows.Forms.Button btn_themLoaiPhong;
        private System.Windows.Forms.Button btn_xoaLoaiPhong;
        private System.Windows.Forms.Button btn_suaLoaiPhong;
        private System.Windows.Forms.Button btn_clearLoaiPhong;
        private System.Windows.Forms.GroupBox gbx_loaiPhong;
        private System.Windows.Forms.GroupBox gbx_tang;
        private System.Windows.Forms.DataGridView dgv_tang;
        private System.Windows.Forms.TextBox tbx_soLuongPhong;
        private System.Windows.Forms.TextBox tbx_tenTang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laaaa;
        private System.Windows.Forms.Button btn_ClearTang;
        private System.Windows.Forms.Button btn_XoaTang;
        private System.Windows.Forms.Button btn_SuaTang;
        private System.Windows.Forms.Button btn_ThemTang;
        private System.Windows.Forms.TextBox tbx_TrangThaiLoaiPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_TrangThaiTang;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}