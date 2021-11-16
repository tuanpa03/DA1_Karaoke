
namespace _3_GUI
{
    partial class frm_ThietBi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_QLThietBi = new System.Windows.Forms.DataGridView();
            this.txt_matb = new System.Windows.Forms.TextBox();
            this.txt_tentb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cmb_mltb = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tinhtrang = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLThietBi
            // 
            this.dgv_QLThietBi.AllowUserToResizeColumns = false;
            this.dgv_QLThietBi.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.NullValue = null;
            this.dgv_QLThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_QLThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLThietBi.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_QLThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_QLThietBi.Location = new System.Drawing.Point(12, 234);
            this.dgv_QLThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_QLThietBi.MultiSelect = false;
            this.dgv_QLThietBi.Name = "dgv_QLThietBi";
            this.dgv_QLThietBi.RowHeadersVisible = false;
            this.dgv_QLThietBi.RowHeadersWidth = 51;
            this.dgv_QLThietBi.RowTemplate.Height = 29;
            this.dgv_QLThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLThietBi.Size = new System.Drawing.Size(774, 209);
            this.dgv_QLThietBi.TabIndex = 0;
            this.dgv_QLThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLThietBi_CellContentClick);
            // 
            // txt_matb
            // 
            this.txt_matb.Location = new System.Drawing.Point(37, 98);
            this.txt_matb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_matb.Multiline = true;
            this.txt_matb.Name = "txt_matb";
            this.txt_matb.Size = new System.Drawing.Size(143, 22);
            this.txt_matb.TabIndex = 1;
            // 
            // txt_tentb
            // 
            this.txt_tentb.Location = new System.Drawing.Point(420, 97);
            this.txt_tentb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tentb.Multiline = true;
            this.txt_tentb.Name = "txt_tentb";
            this.txt_tentb.Size = new System.Drawing.Size(149, 22);
            this.txt_tentb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(420, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên thiết bị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(225, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mã loại thiết bị";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Aqua;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Location = new System.Drawing.Point(420, 182);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 26);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Aqua;
            this.btn_Sua.Location = new System.Drawing.Point(662, 182);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(82, 26);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Aqua;
            this.btn_Xoa.Location = new System.Drawing.Point(540, 182);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 26);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cmb_mltb
            // 
            this.cmb_mltb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mltb.FormattingEnabled = true;
            this.cmb_mltb.Location = new System.Drawing.Point(225, 97);
            this.cmb_mltb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_mltb.Name = "cmb_mltb";
            this.cmb_mltb.Size = new System.Drawing.Size(152, 23);
            this.cmb_mltb.TabIndex = 10;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_close.Location = new System.Drawing.Point(662, 447);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(117, 29);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Red;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Luu.Location = new System.Drawing.Point(505, 447);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(117, 29);
            this.btn_Luu.TabIndex = 12;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(37, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "QUẢN LÝ THIẾT BỊ\r\n";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(609, 97);
            this.txt_dongia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_dongia.Multiline = true;
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(149, 22);
            this.txt_dongia.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(609, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(37, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Số lượng";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(37, 182);
            this.txt_soluong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_soluong.Multiline = true;
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(149, 22);
            this.txt_soluong.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(225, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Tình trạng";
            // 
            // txt_tinhtrang
            // 
            this.txt_tinhtrang.Location = new System.Drawing.Point(225, 182);
            this.txt_tinhtrang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tinhtrang.Multiline = true;
            this.txt_tinhtrang.Name = "txt_tinhtrang";
            this.txt_tinhtrang.Size = new System.Drawing.Size(149, 22);
            this.txt_tinhtrang.TabIndex = 18;
            // 
            // frm_QLThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(799, 492);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_tinhtrang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmb_mltb);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tentb);
            this.Controls.Add(this.txt_matb);
            this.Controls.Add(this.dgv_QLThietBi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_QLThietBi";
            this.Text = "frm_QLMatHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLThietBi;
        private System.Windows.Forms.TextBox txt_matb;
        private System.Windows.Forms.TextBox txt_tentb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cmb_mltb;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_tinhtrang;
    }
}