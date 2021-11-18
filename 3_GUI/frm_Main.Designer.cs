
namespace _3_GUI
{
    partial class Frm_Main
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
            this.grb_controls = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.btn_Hethong = new System.Windows.Forms.Button();
            this.loadform = new System.Windows.Forms.Panel();
            this.grb_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_controls
            // 
            this.grb_controls.Controls.Add(this.button6);
            this.grb_controls.Controls.Add(this.button5);
            this.grb_controls.Controls.Add(this.button4);
            this.grb_controls.Controls.Add(this.btn_Thongke);
            this.grb_controls.Controls.Add(this.btn_DanhMuc);
            this.grb_controls.Controls.Add(this.btn_Hethong);
            this.grb_controls.Location = new System.Drawing.Point(13, 2);
            this.grb_controls.Name = "grb_controls";
            this.grb_controls.Size = new System.Drawing.Size(121, 1019);
            this.grb_controls.TabIndex = 0;
            this.grb_controls.TabStop = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 720);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 90);
            this.button6.TabIndex = 5;
            this.button6.Text = "Đổi mật khẩu";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 816);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 90);
            this.button5.TabIndex = 4;
            this.button5.Text = "Đăng xuất";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 912);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 90);
            this.button4.TabIndex = 3;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.Location = new System.Drawing.Point(6, 208);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(108, 90);
            this.btn_Thongke.TabIndex = 2;
            this.btn_Thongke.Text = "Báo cáo thống kê";
            this.btn_Thongke.UseVisualStyleBackColor = true;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.Location = new System.Drawing.Point(6, 112);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(108, 90);
            this.btn_DanhMuc.TabIndex = 1;
            this.btn_DanhMuc.Text = "Danh Mục";
            this.btn_DanhMuc.UseVisualStyleBackColor = true;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // btn_Hethong
            // 
            this.btn_Hethong.Location = new System.Drawing.Point(6, 16);
            this.btn_Hethong.Name = "btn_Hethong";
            this.btn_Hethong.Size = new System.Drawing.Size(108, 90);
            this.btn_Hethong.TabIndex = 0;
            this.btn_Hethong.Text = "Hệ Thống";
            this.btn_Hethong.UseVisualStyleBackColor = true;
            this.btn_Hethong.Click += new System.EventHandler(this.btn_Hethong_Click_1);
            // 
            // loadform
            // 
            this.loadform.Location = new System.Drawing.Point(140, 12);
            this.loadform.Name = "loadform";
            this.loadform.Size = new System.Drawing.Size(1750, 1009);
            this.loadform.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.loadform);
            this.Controls.Add(this.grb_controls);
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grb_controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_controls;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.Button btn_Hethong;
        private System.Windows.Forms.Panel loadform;
    }
}