﻿
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
            this.btn_doimk = new System.Windows.Forms.Button();
            this.btn_dangxuat = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.btn_DanhMuc = new System.Windows.Forms.Button();
            this.btn_Hethong = new System.Windows.Forms.Button();
            this.loadform = new System.Windows.Forms.Panel();
            this.grb_controls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_controls
            // 
            this.grb_controls.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grb_controls.Controls.Add(this.btn_doimk);
            this.grb_controls.Controls.Add(this.btn_dangxuat);
            this.grb_controls.Controls.Add(this.btn_close);
            this.grb_controls.Controls.Add(this.btn_Thongke);
            this.grb_controls.Controls.Add(this.btn_DanhMuc);
            this.grb_controls.Controls.Add(this.btn_Hethong);
            this.grb_controls.Location = new System.Drawing.Point(13, 12);
            this.grb_controls.Name = "grb_controls";
            this.grb_controls.Size = new System.Drawing.Size(121, 1009);
            this.grb_controls.TabIndex = 0;
            this.grb_controls.TabStop = false;
            // 
            // btn_doimk
            // 
            this.btn_doimk.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_doimk.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_doimk.Location = new System.Drawing.Point(6, 720);
            this.btn_doimk.Name = "btn_doimk";
            this.btn_doimk.Size = new System.Drawing.Size(108, 90);
            this.btn_doimk.TabIndex = 5;
            this.btn_doimk.Text = "Đổi mật khẩu";
            this.btn_doimk.UseVisualStyleBackColor = false;
            this.btn_doimk.Click += new System.EventHandler(this.btn_doimk_Click);
            // 
            // btn_dangxuat
            // 
            this.btn_dangxuat.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_dangxuat.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_dangxuat.Location = new System.Drawing.Point(6, 816);
            this.btn_dangxuat.Name = "btn_dangxuat";
            this.btn_dangxuat.Size = new System.Drawing.Size(108, 90);
            this.btn_dangxuat.TabIndex = 4;
            this.btn_dangxuat.Text = "Đăng xuất";
            this.btn_dangxuat.UseVisualStyleBackColor = false;
            this.btn_dangxuat.Click += new System.EventHandler(this.btn_dangxuat_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_close.Location = new System.Drawing.Point(6, 912);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 90);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Thoát";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Thongke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Thongke.Location = new System.Drawing.Point(6, 197);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(108, 90);
            this.btn_Thongke.TabIndex = 2;
            this.btn_Thongke.Text = "Báo cáo thống kê";
            this.btn_Thongke.UseVisualStyleBackColor = false;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // btn_DanhMuc
            // 
            this.btn_DanhMuc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_DanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DanhMuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_DanhMuc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DanhMuc.Location = new System.Drawing.Point(6, 101);
            this.btn_DanhMuc.Name = "btn_DanhMuc";
            this.btn_DanhMuc.Size = new System.Drawing.Size(108, 90);
            this.btn_DanhMuc.TabIndex = 1;
            this.btn_DanhMuc.Text = "Danh Mục";
            this.btn_DanhMuc.UseVisualStyleBackColor = false;
            this.btn_DanhMuc.Click += new System.EventHandler(this.btn_DanhMuc_Click);
            // 
            // btn_Hethong
            // 
            this.btn_Hethong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Hethong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hethong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Hethong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Hethong.Location = new System.Drawing.Point(6, 5);
            this.btn_Hethong.Name = "btn_Hethong";
            this.btn_Hethong.Size = new System.Drawing.Size(108, 90);
            this.btn_Hethong.TabIndex = 0;
            this.btn_Hethong.Text = "Hệ Thống";
            this.btn_Hethong.UseVisualStyleBackColor = false;
            this.btn_Hethong.Click += new System.EventHandler(this.btn_Hethong_Click_1);
            // 
            // loadform
            // 
            this.loadform.BackgroundImage = global::_3_GUI.Properties.Resources.karaoke_party_banner_layout_95169_774;
            this.loadform.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loadform.Location = new System.Drawing.Point(140, 12);
            this.loadform.Name = "loadform";
            this.loadform.Size = new System.Drawing.Size(1750, 1009);
            this.loadform.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1902, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.loadform);
            this.Controls.Add(this.grb_controls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Main";
            this.Text = "Frm_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.grb_controls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_controls;
        private System.Windows.Forms.Button btn_doimk;
        private System.Windows.Forms.Button btn_dangxuat;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.Button btn_DanhMuc;
        private System.Windows.Forms.Button btn_Hethong;
        private System.Windows.Forms.Panel loadform;
    }
}