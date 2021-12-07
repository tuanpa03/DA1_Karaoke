
namespace _3_GUI
{
    partial class frm_datphong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_datphong));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stripMenu_datPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_capNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenu_donPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_phongdangSuaChua = new System.Windows.Forms.Button();
            this.btn_phongDangDon = new System.Windows.Forms.Button();
            this.btn_sanSangDonKhach = new System.Windows.Forms.Button();
            this.btn_phongCoKhach = new System.Windows.Forms.Button();
            this.lbl_Timer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenu_datPhong,
            this.stripMenu_capNhap,
            this.stripMenu_donPhong});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(200, 76);
            // 
            // stripMenu_datPhong
            // 
            this.stripMenu_datPhong.Name = "stripMenu_datPhong";
            this.stripMenu_datPhong.Size = new System.Drawing.Size(199, 24);
            this.stripMenu_datPhong.Text = "Đặt Phòng";
            this.stripMenu_datPhong.Click += new System.EventHandler(this.stripMenu_datPhong_Click);
            // 
            // stripMenu_capNhap
            // 
            this.stripMenu_capNhap.Name = "stripMenu_capNhap";
            this.stripMenu_capNhap.Size = new System.Drawing.Size(199, 24);
            this.stripMenu_capNhap.Text = "Cập Nhập Dịch Vụ";
            this.stripMenu_capNhap.Click += new System.EventHandler(this.stripMenu_capNhap_Click);
            // 
            // stripMenu_donPhong
            // 
            this.stripMenu_donPhong.Name = "stripMenu_donPhong";
            this.stripMenu_donPhong.Size = new System.Drawing.Size(199, 24);
            this.stripMenu_donPhong.Text = "Dọn Phòng";
            this.stripMenu_donPhong.Click += new System.EventHandler(this.stripMenu_donPhong_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1612, 870);
            this.tableLayoutPanel1.TabIndex = 10;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_phongdangSuaChua);
            this.panel1.Controls.Add(this.btn_phongDangDon);
            this.panel1.Controls.Add(this.btn_sanSangDonKhach);
            this.panel1.Controls.Add(this.btn_phongCoKhach);
            this.panel1.Controls.Add(this.lbl_Timer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 877);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1612, 159);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(914, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(131, 102);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(767, 54);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 102);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btn_phongdangSuaChua
            // 
            this.btn_phongdangSuaChua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_phongdangSuaChua.BackColor = System.Drawing.Color.Gray;
            this.btn_phongdangSuaChua.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_phongdangSuaChua.Location = new System.Drawing.Point(289, 106);
            this.btn_phongdangSuaChua.Name = "btn_phongdangSuaChua";
            this.btn_phongdangSuaChua.Size = new System.Drawing.Size(244, 48);
            this.btn_phongdangSuaChua.TabIndex = 11;
            this.btn_phongdangSuaChua.Text = "Phòng cần dọn";
            this.btn_phongdangSuaChua.UseVisualStyleBackColor = false;
            this.btn_phongdangSuaChua.Click += new System.EventHandler(this.btn_phongdangSuaChua_Click);
            // 
            // btn_phongDangDon
            // 
            this.btn_phongDangDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_phongDangDon.BackColor = System.Drawing.Color.Yellow;
            this.btn_phongDangDon.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_phongDangDon.ForeColor = System.Drawing.Color.Gray;
            this.btn_phongDangDon.Location = new System.Drawing.Point(289, 54);
            this.btn_phongDangDon.Name = "btn_phongDangDon";
            this.btn_phongDangDon.Size = new System.Drawing.Size(244, 48);
            this.btn_phongDangDon.TabIndex = 10;
            this.btn_phongDangDon.Text = "Phòng đang dọn ";
            this.btn_phongDangDon.UseVisualStyleBackColor = false;
            this.btn_phongDangDon.Click += new System.EventHandler(this.btn_phongDangDon_Click);
            // 
            // btn_sanSangDonKhach
            // 
            this.btn_sanSangDonKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sanSangDonKhach.BackColor = System.Drawing.Color.Red;
            this.btn_sanSangDonKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sanSangDonKhach.Location = new System.Drawing.Point(9, 106);
            this.btn_sanSangDonKhach.Name = "btn_sanSangDonKhach";
            this.btn_sanSangDonKhach.Size = new System.Drawing.Size(244, 48);
            this.btn_sanSangDonKhach.TabIndex = 9;
            this.btn_sanSangDonKhach.Text = "Sẵn sàng đón khách ";
            this.btn_sanSangDonKhach.UseVisualStyleBackColor = false;
            this.btn_sanSangDonKhach.Click += new System.EventHandler(this.btn_sanSangDonKhach_Click);
            // 
            // btn_phongCoKhach
            // 
            this.btn_phongCoKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_phongCoKhach.BackColor = System.Drawing.Color.Blue;
            this.btn_phongCoKhach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_phongCoKhach.Location = new System.Drawing.Point(9, 52);
            this.btn_phongCoKhach.Name = "btn_phongCoKhach";
            this.btn_phongCoKhach.Size = new System.Drawing.Size(244, 48);
            this.btn_phongCoKhach.TabIndex = 8;
            this.btn_phongCoKhach.Text = "Phòng đang có khách ";
            this.btn_phongCoKhach.UseVisualStyleBackColor = false;
            this.btn_phongCoKhach.Click += new System.EventHandler(this.btn_phongCoKhach_Click);
            // 
            // lbl_Timer
            // 
            this.lbl_Timer.AutoSize = true;
            this.lbl_Timer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Timer.ForeColor = System.Drawing.Color.Red;
            this.lbl_Timer.Location = new System.Drawing.Point(821, 17);
            this.lbl_Timer.Name = "lbl_Timer";
            this.lbl_Timer.Size = new System.Drawing.Size(780, 37);
            this.lbl_Timer.TabIndex = 0;
            this.lbl_Timer.Text = "Karaoke Family - 216 Phúc Tân - Hoàn Kiếm - Hà Nội";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1073, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(447, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "https://www.facebook.com/musicshowvn\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(1076, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Website :           http://www.musicshow.vn\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(1076, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(311, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số điện thoại :  0913 51 53 51";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1612, 887);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_datphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1616, 1059);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_datphong";
            this.Text = "frm_Main";
            this.Load += new System.EventHandler(this.frm_datphong_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_datPhong;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_capNhap;
        private System.Windows.Forms.ToolStripMenuItem stripMenu_donPhong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Timer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_phongdangSuaChua;
        private System.Windows.Forms.Button btn_phongDangDon;
        private System.Windows.Forms.Button btn_sanSangDonKhach;
        private System.Windows.Forms.Button btn_phongCoKhach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}