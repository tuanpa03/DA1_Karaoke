
namespace _3_GUI
{
    partial class frm_ThongKeDoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.rbt_mathang = new System.Windows.Forms.RadioButton();
            this.rbt_phong = new System.Windows.Forms.RadioButton();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(318, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1122, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1698, 452);
            this.dataGridView1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1162, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 45);
            this.comboBox1.TabIndex = 5;
            // 
            // rbt_mathang
            // 
            this.rbt_mathang.AutoSize = true;
            this.rbt_mathang.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_mathang.Location = new System.Drawing.Point(828, 271);
            this.rbt_mathang.Name = "rbt_mathang";
            this.rbt_mathang.Size = new System.Drawing.Size(153, 41);
            this.rbt_mathang.TabIndex = 6;
            this.rbt_mathang.TabStop = true;
            this.rbt_mathang.Text = "Mặt Hàng";
            this.rbt_mathang.UseVisualStyleBackColor = true;
            this.rbt_mathang.CheckedChanged += new System.EventHandler(this.rbt_mathang_CheckedChanged);
            // 
            // rbt_phong
            // 
            this.rbt_phong.AutoSize = true;
            this.rbt_phong.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbt_phong.Location = new System.Drawing.Point(1009, 271);
            this.rbt_phong.Name = "rbt_phong";
            this.rbt_phong.Size = new System.Drawing.Size(112, 41);
            this.rbt_phong.TabIndex = 6;
            this.rbt_phong.TabStop = true;
            this.rbt_phong.Text = "Phòng";
            this.rbt_phong.UseVisualStyleBackColor = true;
            this.rbt_phong.CheckedChanged += new System.EventHandler(this.rbt_phong_CheckedChanged);
            // 
            // btn_thongke
            // 
            this.btn_thongke.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_thongke.Location = new System.Drawing.Point(1478, 267);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(155, 48);
            this.btn_thongke.TabIndex = 7;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1704, 484);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1704, 826);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.rbt_phong);
            this.Controls.Add(this.rbt_mathang);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "frm_ThongKeDoanhThu";
            this.Text = "frm_ThongKeDoanhThu";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton rbt_mathang;
        private System.Windows.Forms.RadioButton rbt_phong;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}