
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
            this.dgv_loaiPhong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_tenLoaiPhong = new System.Windows.Forms.TextBox();
            this.tbx_donGia = new System.Windows.Forms.TextBox();
            this.btn_themLoaiPhong = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.btn_xoaLoaiPhong = new System.Windows.Forms.Button();
            this.btn_suaLoaiPhong = new System.Windows.Forms.Button();
            this.btn_clearLoaiPhong = new System.Windows.Forms.Button();
            this.gbx_loaiPhong = new System.Windows.Forms.GroupBox();
            this.gbx_tang = new System.Windows.Forms.GroupBox();
            this.btn_ClearTang = new System.Windows.Forms.Button();
            this.btn_XoaTang = new System.Windows.Forms.Button();
            this.btn_SuaTang = new System.Windows.Forms.Button();
            this.btn_ThemTang = new System.Windows.Forms.Button();
            this.dgv_tang = new System.Windows.Forms.DataGridView();
            this.tbx_soLuongPhong = new System.Windows.Forms.TextBox();
            this.tbx_tenTang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.laaaa = new System.Windows.Forms.Label();
            this.tbx_TrangThaiTang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_TrangThaiLoaiPhong = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).BeginInit();
            this.gbx_loaiPhong.SuspendLayout();
            this.gbx_tang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_loaiPhong
            // 
            this.dgv_loaiPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaiPhong.Location = new System.Drawing.Point(273, 26);
            this.dgv_loaiPhong.Name = "dgv_loaiPhong";
            this.dgv_loaiPhong.RowHeadersWidth = 51;
            this.dgv_loaiPhong.RowTemplate.Height = 29;
            this.dgv_loaiPhong.Size = new System.Drawing.Size(521, 119);
            this.dgv_loaiPhong.TabIndex = 2;
            this.dgv_loaiPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Loại Phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Đơn giá";
            // 
            // tbx_tenLoaiPhong
            // 
            this.tbx_tenLoaiPhong.Location = new System.Drawing.Point(116, 26);
            this.tbx_tenLoaiPhong.Name = "tbx_tenLoaiPhong";
            this.tbx_tenLoaiPhong.Size = new System.Drawing.Size(145, 27);
            this.tbx_tenLoaiPhong.TabIndex = 9;
            // 
            // tbx_donGia
            // 
            this.tbx_donGia.Location = new System.Drawing.Point(116, 67);
            this.tbx_donGia.Name = "tbx_donGia";
            this.tbx_donGia.Size = new System.Drawing.Size(145, 27);
            this.tbx_donGia.TabIndex = 11;
            // 
            // btn_themLoaiPhong
            // 
            this.btn_themLoaiPhong.Location = new System.Drawing.Point(6, 158);
            this.btn_themLoaiPhong.Name = "btn_themLoaiPhong";
            this.btn_themLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btn_themLoaiPhong.TabIndex = 17;
            this.btn_themLoaiPhong.Text = "Thêm";
            this.btn_themLoaiPhong.UseVisualStyleBackColor = true;
            this.btn_themLoaiPhong.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(615, 158);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(94, 29);
            this.btn_dong.TabIndex = 18;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // btn_xoaLoaiPhong
            // 
            this.btn_xoaLoaiPhong.Location = new System.Drawing.Point(302, 158);
            this.btn_xoaLoaiPhong.Name = "btn_xoaLoaiPhong";
            this.btn_xoaLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btn_xoaLoaiPhong.TabIndex = 19;
            this.btn_xoaLoaiPhong.Text = "Xóa";
            this.btn_xoaLoaiPhong.UseVisualStyleBackColor = true;
            this.btn_xoaLoaiPhong.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_suaLoaiPhong
            // 
            this.btn_suaLoaiPhong.Location = new System.Drawing.Point(148, 158);
            this.btn_suaLoaiPhong.Name = "btn_suaLoaiPhong";
            this.btn_suaLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btn_suaLoaiPhong.TabIndex = 20;
            this.btn_suaLoaiPhong.Text = "Sửa";
            this.btn_suaLoaiPhong.UseVisualStyleBackColor = true;
            this.btn_suaLoaiPhong.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_clearLoaiPhong
            // 
            this.btn_clearLoaiPhong.Location = new System.Drawing.Point(456, 158);
            this.btn_clearLoaiPhong.Name = "btn_clearLoaiPhong";
            this.btn_clearLoaiPhong.Size = new System.Drawing.Size(94, 29);
            this.btn_clearLoaiPhong.TabIndex = 21;
            this.btn_clearLoaiPhong.Text = "Clear";
            this.btn_clearLoaiPhong.UseVisualStyleBackColor = true;
            this.btn_clearLoaiPhong.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // gbx_loaiPhong
            // 
            this.gbx_loaiPhong.Controls.Add(this.tbx_TrangThaiLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.label4);
            this.gbx_loaiPhong.Controls.Add(this.label1);
            this.gbx_loaiPhong.Controls.Add(this.dgv_loaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.btn_dong);
            this.gbx_loaiPhong.Controls.Add(this.btn_clearLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.tbx_tenLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.btn_xoaLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.btn_suaLoaiPhong);
            this.gbx_loaiPhong.Controls.Add(this.label6);
            this.gbx_loaiPhong.Controls.Add(this.tbx_donGia);
            this.gbx_loaiPhong.Controls.Add(this.btn_themLoaiPhong);
            this.gbx_loaiPhong.Location = new System.Drawing.Point(0, 227);
            this.gbx_loaiPhong.Name = "gbx_loaiPhong";
            this.gbx_loaiPhong.Size = new System.Drawing.Size(800, 222);
            this.gbx_loaiPhong.TabIndex = 22;
            this.gbx_loaiPhong.TabStop = false;
            this.gbx_loaiPhong.Text = "Loại Phòng";
            // 
            // gbx_tang
            // 
            this.gbx_tang.Controls.Add(this.label2);
            this.gbx_tang.Controls.Add(this.tbx_TrangThaiTang);
            this.gbx_tang.Controls.Add(this.btn_ClearTang);
            this.gbx_tang.Controls.Add(this.btn_XoaTang);
            this.gbx_tang.Controls.Add(this.btn_SuaTang);
            this.gbx_tang.Controls.Add(this.btn_ThemTang);
            this.gbx_tang.Controls.Add(this.dgv_tang);
            this.gbx_tang.Controls.Add(this.tbx_soLuongPhong);
            this.gbx_tang.Controls.Add(this.tbx_tenTang);
            this.gbx_tang.Controls.Add(this.label3);
            this.gbx_tang.Controls.Add(this.laaaa);
            this.gbx_tang.Location = new System.Drawing.Point(0, 13);
            this.gbx_tang.Name = "gbx_tang";
            this.gbx_tang.Size = new System.Drawing.Size(800, 218);
            this.gbx_tang.TabIndex = 23;
            this.gbx_tang.TabStop = false;
            this.gbx_tang.Text = "Tầng Phòng";
            // 
            // btn_ClearTang
            // 
            this.btn_ClearTang.Location = new System.Drawing.Point(456, 168);
            this.btn_ClearTang.Name = "btn_ClearTang";
            this.btn_ClearTang.Size = new System.Drawing.Size(94, 29);
            this.btn_ClearTang.TabIndex = 22;
            this.btn_ClearTang.Text = "Clear";
            this.btn_ClearTang.UseVisualStyleBackColor = true;
            this.btn_ClearTang.Click += new System.EventHandler(this.btn_ClearTang_Click);
            // 
            // btn_XoaTang
            // 
            this.btn_XoaTang.Location = new System.Drawing.Point(302, 168);
            this.btn_XoaTang.Name = "btn_XoaTang";
            this.btn_XoaTang.Size = new System.Drawing.Size(94, 29);
            this.btn_XoaTang.TabIndex = 22;
            this.btn_XoaTang.Text = "Xóa";
            this.btn_XoaTang.UseVisualStyleBackColor = true;
            this.btn_XoaTang.Click += new System.EventHandler(this.btn_XoaTang_Click);
            // 
            // btn_SuaTang
            // 
            this.btn_SuaTang.Location = new System.Drawing.Point(148, 168);
            this.btn_SuaTang.Name = "btn_SuaTang";
            this.btn_SuaTang.Size = new System.Drawing.Size(94, 29);
            this.btn_SuaTang.TabIndex = 22;
            this.btn_SuaTang.Text = "Sửa";
            this.btn_SuaTang.UseVisualStyleBackColor = true;
            this.btn_SuaTang.Click += new System.EventHandler(this.btn_SuaTang_Click);
            // 
            // btn_ThemTang
            // 
            this.btn_ThemTang.Location = new System.Drawing.Point(16, 168);
            this.btn_ThemTang.Name = "btn_ThemTang";
            this.btn_ThemTang.Size = new System.Drawing.Size(94, 29);
            this.btn_ThemTang.TabIndex = 22;
            this.btn_ThemTang.Text = "Thêm";
            this.btn_ThemTang.UseVisualStyleBackColor = true;
            this.btn_ThemTang.Click += new System.EventHandler(this.btn_ThemTang_Click);
            // 
            // dgv_tang
            // 
            this.dgv_tang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tang.Location = new System.Drawing.Point(279, 26);
            this.dgv_tang.Name = "dgv_tang";
            this.dgv_tang.RowHeadersWidth = 51;
            this.dgv_tang.RowTemplate.Height = 29;
            this.dgv_tang.Size = new System.Drawing.Size(521, 119);
            this.dgv_tang.TabIndex = 22;
            this.dgv_tang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tang_CellClick);
            // 
            // tbx_soLuongPhong
            // 
            this.tbx_soLuongPhong.Location = new System.Drawing.Point(116, 65);
            this.tbx_soLuongPhong.Name = "tbx_soLuongPhong";
            this.tbx_soLuongPhong.Size = new System.Drawing.Size(145, 27);
            this.tbx_soLuongPhong.TabIndex = 11;
            // 
            // tbx_tenTang
            // 
            this.tbx_tenTang.Location = new System.Drawing.Point(116, 26);
            this.tbx_tenTang.Name = "tbx_tenTang";
            this.tbx_tenTang.Size = new System.Drawing.Size(145, 27);
            this.tbx_tenTang.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Lượng Phòng";
            // 
            // laaaa
            // 
            this.laaaa.AutoSize = true;
            this.laaaa.Location = new System.Drawing.Point(31, 37);
            this.laaaa.Name = "laaaa";
            this.laaaa.Size = new System.Drawing.Size(42, 20);
            this.laaaa.TabIndex = 0;
            this.laaaa.Text = "Tầng";
            // 
            // tbx_TrangThaiTang
            // 
            this.tbx_TrangThaiTang.Location = new System.Drawing.Point(116, 108);
            this.tbx_TrangThaiTang.Name = "tbx_TrangThaiTang";
            this.tbx_TrangThaiTang.Size = new System.Drawing.Size(145, 27);
            this.tbx_TrangThaiTang.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-8, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-8, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Trạng thái";
            // 
            // tbx_TrangThaiLoaiPhong
            // 
            this.tbx_TrangThaiLoaiPhong.Location = new System.Drawing.Point(116, 111);
            this.tbx_TrangThaiLoaiPhong.Name = "tbx_TrangThaiLoaiPhong";
            this.tbx_TrangThaiLoaiPhong.Size = new System.Drawing.Size(145, 27);
            this.tbx_TrangThaiLoaiPhong.TabIndex = 26;
            // 
            // frm_LoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbx_tang);
            this.Controls.Add(this.gbx_loaiPhong);
            this.Name = "frm_LoaiPhong";
            this.Text = "frm_LoaiPhong";
            this.Load += new System.EventHandler(this.frm_LoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaiPhong)).EndInit();
            this.gbx_loaiPhong.ResumeLayout(false);
            this.gbx_loaiPhong.PerformLayout();
            this.gbx_tang.ResumeLayout(false);
            this.gbx_tang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_loaiPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_tenLoaiPhong;
        private System.Windows.Forms.TextBox tbx_donGia;
        private System.Windows.Forms.Button btn_themLoaiPhong;
        private System.Windows.Forms.Button btn_dong;
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
    }
}