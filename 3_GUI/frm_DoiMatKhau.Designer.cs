﻿
namespace _3_GUI
{
    partial class frm_DoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DoiMatKhau));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NhapLaiPassNew = new System.Windows.Forms.TextBox();
            this.txt_NhapPassNew = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbx_Show_Pass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Forte", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(197, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "NEW PASSWORK";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(213, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 52);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hãy nhập đúng mã nguồn và \r\nđiền đầy đủ thông tin vào form ?";
            // 
            // txt_NhapLaiPassNew
            // 
            this.txt_NhapLaiPassNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NhapLaiPassNew.Location = new System.Drawing.Point(12, 301);
            this.txt_NhapLaiPassNew.Name = "txt_NhapLaiPassNew";
            this.txt_NhapLaiPassNew.PasswordChar = '*';
            this.txt_NhapLaiPassNew.Size = new System.Drawing.Size(577, 34);
            this.txt_NhapLaiPassNew.TabIndex = 12;
            // 
            // txt_NhapPassNew
            // 
            this.txt_NhapPassNew.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NhapPassNew.Location = new System.Drawing.Point(12, 231);
            this.txt_NhapPassNew.Name = "txt_NhapPassNew";
            this.txt_NhapPassNew.PasswordChar = '*';
            this.txt_NhapPassNew.Size = new System.Drawing.Size(577, 34);
            this.txt_NhapPassNew.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 31);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(4, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 54);
            this.button1.TabIndex = 17;
            this.button1.Text = "Đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(232, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 54);
            this.button2.TabIndex = 17;
            this.button2.Text = "Đăng nhập";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbx_Show_Pass
            // 
            this.cbx_Show_Pass.AutoSize = true;
            this.cbx_Show_Pass.BackColor = System.Drawing.Color.Transparent;
            this.cbx_Show_Pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_Show_Pass.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx_Show_Pass.Location = new System.Drawing.Point(12, 341);
            this.cbx_Show_Pass.Name = "cbx_Show_Pass";
            this.cbx_Show_Pass.Size = new System.Drawing.Size(217, 35);
            this.cbx_Show_Pass.TabIndex = 18;
            this.cbx_Show_Pass.Text = "Hiển thị mật khẩu";
            this.cbx_Show_Pass.UseVisualStyleBackColor = false;
            this.cbx_Show_Pass.CheckedChanged += new System.EventHandler(this.cbx_Show_Pass_CheckedChanged);
            // 
            // frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 447);
            this.Controls.Add(this.cbx_Show_Pass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_NhapLaiPassNew);
            this.Controls.Add(this.txt_NhapPassNew);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_DoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_DoiMatKhau";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DoiMatKhau_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_DoiMatKhau_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NhapLaiPassNew;
        private System.Windows.Forms.TextBox txt_NhapPassNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbx_Show_Pass;
    }
}