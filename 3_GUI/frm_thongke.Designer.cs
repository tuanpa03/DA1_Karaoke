
namespace _3_GUI
{
    partial class frm_thongke
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
            this.pl_load = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sanpham = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_load
            // 
            this.pl_load.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pl_load.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_load.Location = new System.Drawing.Point(0, 0);
            this.pl_load.Name = "pl_load";
            this.pl_load.Size = new System.Drawing.Size(1616, 1059);
            this.pl_load.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.btn_sanpham);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1616, 109);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(433, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 77);
            this.button2.TabIndex = 0;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(223, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 77);
            this.button4.TabIndex = 0;
            this.button4.Text = "Doanh thu";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btn_sanpham
            // 
            this.btn_sanpham.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_sanpham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sanpham.Location = new System.Drawing.Point(12, 12);
            this.btn_sanpham.Name = "btn_sanpham";
            this.btn_sanpham.Size = new System.Drawing.Size(181, 77);
            this.btn_sanpham.TabIndex = 0;
            this.btn_sanpham.Text = "Sản phẩm";
            this.btn_sanpham.UseVisualStyleBackColor = false;
            this.btn_sanpham.Click += new System.EventHandler(this.btn_sanpham_Click);
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1616, 1059);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pl_load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_thongke";
            this.Text = "frm_thongke";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_load;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_sanpham;
    }
}