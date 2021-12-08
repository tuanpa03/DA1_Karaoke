
namespace _3_GUI
{
    partial class frm_hoadon
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
            this.lb_phong = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tienphong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_tenkh = new System.Windows.Forms.Label();
            this.lb_tienDV = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lb_tong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_phong
            // 
            this.lb_phong.AutoSize = true;
            this.lb_phong.Location = new System.Drawing.Point(27, 21);
            this.lb_phong.Name = "lb_phong";
            this.lb_phong.Size = new System.Drawing.Size(50, 20);
            this.lb_phong.TabIndex = 5;
            this.lb_phong.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(450, 300);
            this.dataGridView1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 451);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tiền phòng";
            // 
            // lb_tienphong
            // 
            this.lb_tienphong.AutoSize = true;
            this.lb_tienphong.Location = new System.Drawing.Point(244, 451);
            this.lb_tienphong.Name = "lb_tienphong";
            this.lb_tienphong.Size = new System.Drawing.Size(50, 20);
            this.lb_tienphong.TabIndex = 7;
            this.lb_tienphong.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 497);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tổng";
            // 
            // lb_tenkh
            // 
            this.lb_tenkh.AutoSize = true;
            this.lb_tenkh.Location = new System.Drawing.Point(223, 21);
            this.lb_tenkh.Name = "lb_tenkh";
            this.lb_tenkh.Size = new System.Drawing.Size(50, 20);
            this.lb_tenkh.TabIndex = 7;
            this.lb_tenkh.Text = "label2";
            // 
            // lb_tienDV
            // 
            this.lb_tienDV.AutoSize = true;
            this.lb_tienDV.Location = new System.Drawing.Point(244, 410);
            this.lb_tienDV.Name = "lb_tienDV";
            this.lb_tienDV.Size = new System.Drawing.Size(50, 20);
            this.lb_tienDV.TabIndex = 7;
            this.lb_tienDV.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiền dịch vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 612);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "in hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 612);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 8;
            this.button2.Text = "thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Location = new System.Drawing.Point(244, 497);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(50, 20);
            this.lb_tong.TabIndex = 7;
            this.lb_tong.Text = "label2";
            // 
            // frm_hoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_tenkh);
            this.Controls.Add(this.lb_tong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_tienDV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_tienphong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lb_phong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_hoadon";
            this.Text = "frm_hoadon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_phong;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tienphong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_tenkh;
        private System.Windows.Forms.Label lb_tienDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lb_tong;
    }
}