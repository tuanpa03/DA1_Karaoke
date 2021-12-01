
namespace _3_GUI
{
    partial class frm_menuDanhMuc
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
            this.btn_Phong = new System.Windows.Forms.Button();
            this.btn_Nhanvien = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.loadform = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_thietbi = new System.Windows.Forms.Button();
            this.btn_dvt = new System.Windows.Forms.Button();
            this.btn_loaithietbi = new System.Windows.Forms.Button();
            this.btn_nhacungcap = new System.Windows.Forms.Button();
            this.btn_loaiphong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Phong
            // 
            this.btn_Phong.Location = new System.Drawing.Point(12, 22);
            this.btn_Phong.Name = "btn_Phong";
            this.btn_Phong.Size = new System.Drawing.Size(180, 75);
            this.btn_Phong.TabIndex = 0;
            this.btn_Phong.Text = "Phong";
            this.btn_Phong.UseVisualStyleBackColor = true;
            this.btn_Phong.Click += new System.EventHandler(this.btn_Phong_Click);
            // 
            // btn_Nhanvien
            // 
            this.btn_Nhanvien.Location = new System.Drawing.Point(435, 22);
            this.btn_Nhanvien.Name = "btn_Nhanvien";
            this.btn_Nhanvien.Size = new System.Drawing.Size(180, 75);
            this.btn_Nhanvien.TabIndex = 0;
            this.btn_Nhanvien.Text = "Nhân viên";
            this.btn_Nhanvien.UseVisualStyleBackColor = true;
            this.btn_Nhanvien.Click += new System.EventHandler(this.btn_Nhanvien_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(648, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 75);
            this.button3.TabIndex = 0;
            this.button3.Text = "Mặt Hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // loadform
            // 
            this.loadform.Location = new System.Drawing.Point(12, 115);
            this.loadform.Name = "loadform";
            this.loadform.Size = new System.Drawing.Size(1720, 865);
            this.loadform.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_thietbi);
            this.groupBox1.Controls.Add(this.btn_dvt);
            this.groupBox1.Controls.Add(this.btn_loaithietbi);
            this.groupBox1.Controls.Add(this.btn_nhacungcap);
            this.groupBox1.Controls.Add(this.btn_loaiphong);
            this.groupBox1.Controls.Add(this.btn_Phong);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.btn_Nhanvien);
            this.groupBox1.Location = new System.Drawing.Point(13, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1719, 110);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_thietbi
            // 
            this.btn_thietbi.Location = new System.Drawing.Point(1277, 22);
            this.btn_thietbi.Name = "btn_thietbi";
            this.btn_thietbi.Size = new System.Drawing.Size(180, 75);
            this.btn_thietbi.TabIndex = 1;
            this.btn_thietbi.Text = "Thiết bị";
            this.btn_thietbi.UseVisualStyleBackColor = true;
            this.btn_thietbi.Click += new System.EventHandler(this.btn_thietbi_Click);
            // 
            // btn_dvt
            // 
            this.btn_dvt.Location = new System.Drawing.Point(860, 22);
            this.btn_dvt.Name = "btn_dvt";
            this.btn_dvt.Size = new System.Drawing.Size(180, 75);
            this.btn_dvt.TabIndex = 1;
            this.btn_dvt.Text = "Đơn vị tính";
            this.btn_dvt.UseVisualStyleBackColor = true;
            this.btn_dvt.Click += new System.EventHandler(this.btn_dvt_Click);
            // 
            // btn_loaithietbi
            // 
            this.btn_loaithietbi.Location = new System.Drawing.Point(1487, 22);
            this.btn_loaithietbi.Name = "btn_loaithietbi";
            this.btn_loaithietbi.Size = new System.Drawing.Size(180, 75);
            this.btn_loaithietbi.TabIndex = 1;
            this.btn_loaithietbi.Text = "Loại thiết bị";
            this.btn_loaithietbi.UseVisualStyleBackColor = true;
            this.btn_loaithietbi.Click += new System.EventHandler(this.btn_loaithietbi_Click);
            // 
            // btn_nhacungcap
            // 
            this.btn_nhacungcap.Location = new System.Drawing.Point(1069, 22);
            this.btn_nhacungcap.Name = "btn_nhacungcap";
            this.btn_nhacungcap.Size = new System.Drawing.Size(180, 75);
            this.btn_nhacungcap.TabIndex = 1;
            this.btn_nhacungcap.Text = "Nhà cung cấp";
            this.btn_nhacungcap.UseVisualStyleBackColor = true;
            this.btn_nhacungcap.Click += new System.EventHandler(this.btn_nhacungcap_Click);
            // 
            // btn_loaiphong
            // 
            this.btn_loaiphong.Location = new System.Drawing.Point(222, 22);
            this.btn_loaiphong.Name = "btn_loaiphong";
            this.btn_loaiphong.Size = new System.Drawing.Size(180, 75);
            this.btn_loaiphong.TabIndex = 0;
            this.btn_loaiphong.Text = "Loại Phong";
            this.btn_loaiphong.UseVisualStyleBackColor = true;
            this.btn_loaiphong.Click += new System.EventHandler(this.btn_loaiphong_Click);
            // 
            // frm_menuDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1732, 992);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loadform);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frm_menuDanhMuc";
            this.Text = "frm_menuDanhMuc";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Phong;
        private System.Windows.Forms.Button btn_Nhanvien;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel loadform;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thietbi;
        private System.Windows.Forms.Button btn_nhacungcap;
        private System.Windows.Forms.Button btn_dvt;
        private System.Windows.Forms.Button btn_loaithietbi;
        private System.Windows.Forms.Button btn_loaiphong;
    }
}