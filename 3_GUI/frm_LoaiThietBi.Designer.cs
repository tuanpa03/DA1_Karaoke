
namespace _3_GUI
{
    partial class frm_LoaiThietBi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_LoaiThietBi = new System.Windows.Forms.DataGridView();
            this.txt_maltb = new System.Windows.Forms.TextBox();
            this.txt_xuatxu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.txt_tenloai = new System.Windows.Forms.TextBox();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiThietBi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_LoaiThietBi
            // 
            this.dgv_LoaiThietBi.AllowUserToResizeColumns = false;
            this.dgv_LoaiThietBi.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgv_LoaiThietBi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_LoaiThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LoaiThietBi.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_LoaiThietBi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_LoaiThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LoaiThietBi.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_LoaiThietBi.Location = new System.Drawing.Point(9, 105);
            this.dgv_LoaiThietBi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_LoaiThietBi.MultiSelect = false;
            this.dgv_LoaiThietBi.Name = "dgv_LoaiThietBi";
            this.dgv_LoaiThietBi.RowHeadersVisible = false;
            this.dgv_LoaiThietBi.RowHeadersWidth = 51;
            this.dgv_LoaiThietBi.RowTemplate.Height = 29;
            this.dgv_LoaiThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LoaiThietBi.Size = new System.Drawing.Size(762, 209);
            this.dgv_LoaiThietBi.TabIndex = 0;
            this.dgv_LoaiThietBi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LoaiThietBi_CellContentClick);
            // 
            // txt_maltb
            // 
            this.txt_maltb.Location = new System.Drawing.Point(39, 29);
            this.txt_maltb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_maltb.Multiline = true;
            this.txt_maltb.Name = "txt_maltb";
            this.txt_maltb.Size = new System.Drawing.Size(152, 22);
            this.txt_maltb.TabIndex = 1;
            // 
            // txt_xuatxu
            // 
            this.txt_xuatxu.Location = new System.Drawing.Point(414, 29);
            this.txt_xuatxu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_xuatxu.Multiline = true;
            this.txt_xuatxu.Name = "txt_xuatxu";
            this.txt_xuatxu.Size = new System.Drawing.Size(160, 22);
            this.txt_xuatxu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã loại thiết bị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(414, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xuất xứ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(231, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 6;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Aqua;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Location = new System.Drawing.Point(395, 75);
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
            this.btn_Sua.Location = new System.Drawing.Point(649, 75);
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
            this.btn_Xoa.Location = new System.Drawing.Point(524, 75);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 26);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.Aqua;
            this.btn_luu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_luu.Location = new System.Drawing.Point(538, 328);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(82, 26);
            this.btn_luu.TabIndex = 11;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.BackColor = System.Drawing.Color.Aqua;
            this.btn_dong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_dong.Location = new System.Drawing.Point(649, 328);
            this.btn_dong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(82, 26);
            this.btn_dong.TabIndex = 12;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = false;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // txt_tenloai
            // 
            this.txt_tenloai.Location = new System.Drawing.Point(231, 29);
            this.txt_tenloai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tenloai.Multiline = true;
            this.txt_tenloai.Name = "txt_tenloai";
            this.txt_tenloai.Size = new System.Drawing.Size(152, 22);
            this.txt_tenloai.TabIndex = 13;
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(611, 29);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_trangthai.Multiline = true;
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(160, 22);
            this.txt_trangthai.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(611, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "ID Trạng thái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(231, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Tên loại";
            // 
            // frm_LoaiThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(788, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.txt_tenloai);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_xuatxu);
            this.Controls.Add(this.txt_maltb);
            this.Controls.Add(this.dgv_LoaiThietBi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_LoaiThietBi";
            this.Text = "frm_QLMatHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LoaiThietBi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_LoaiThietBi;
        private System.Windows.Forms.TextBox txt_maltb;
        private System.Windows.Forms.TextBox txt_xuatxu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.TextBox txt_tenloai;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}