
namespace _3_GUI_PresentationLayer
{
    partial class frm_QLMatHang
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
            this.dgv_QLMatHang = new System.Windows.Forms.DataGridView();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.cmb_IDDvTinh = new System.Windows.Forms.ComboBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_QLMatHang
            // 
            this.dgv_QLMatHang.AllowUserToResizeColumns = false;
            this.dgv_QLMatHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.NullValue = null;
            this.dgv_QLMatHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_QLMatHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_QLMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLMatHang.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_QLMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_QLMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLMatHang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgv_QLMatHang.Location = new System.Drawing.Point(12, 176);
            this.dgv_QLMatHang.MultiSelect = false;
            this.dgv_QLMatHang.Name = "dgv_QLMatHang";
            this.dgv_QLMatHang.RowHeadersVisible = false;
            this.dgv_QLMatHang.RowHeadersWidth = 51;
            this.dgv_QLMatHang.RowTemplate.Height = 29;
            this.dgv_QLMatHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_QLMatHang.Size = new System.Drawing.Size(926, 279);
            this.dgv_QLMatHang.TabIndex = 0;
            this.dgv_QLMatHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TenMH.Location = new System.Drawing.Point(42, 131);
            this.txt_TenMH.Multiline = true;
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(194, 28);
            this.txt_TenMH.TabIndex = 1;
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_DonGia.Location = new System.Drawing.Point(597, 131);
            this.txt_DonGia.Multiline = true;
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(194, 28);
            this.txt_DonGia.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(42, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên mặt hàng";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(597, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(321, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đơn vị tính";
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.BackColor = System.Drawing.Color.Aqua;
            this.btn_Them.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Them.Location = new System.Drawing.Point(844, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 35);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Sua.BackColor = System.Drawing.Color.Aqua;
            this.btn_Sua.Location = new System.Drawing.Point(844, 68);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 35);
            this.btn_Sua.TabIndex = 8;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Xoa.BackColor = System.Drawing.Color.Aqua;
            this.btn_Xoa.Location = new System.Drawing.Point(844, 124);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(94, 35);
            this.btn_Xoa.TabIndex = 9;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // cmb_IDDvTinh
            // 
            this.cmb_IDDvTinh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_IDDvTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_IDDvTinh.FormattingEnabled = true;
            this.cmb_IDDvTinh.Location = new System.Drawing.Point(321, 131);
            this.cmb_IDDvTinh.Name = "cmb_IDDvTinh";
            this.cmb_IDDvTinh.Size = new System.Drawing.Size(194, 28);
            this.cmb_IDDvTinh.TabIndex = 10;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.Red;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_close.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_close.Location = new System.Drawing.Point(804, 471);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(134, 39);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.BackColor = System.Drawing.Color.Red;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Luu.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_Luu.Location = new System.Drawing.Point(643, 471);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(134, 39);
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
            this.label4.Location = new System.Drawing.Point(42, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(425, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "QUẢN LÝ MẶT HÀNG";
            // 
            // frm_QLMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(950, 522);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cmb_IDDvTinh);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.txt_TenMH);
            this.Controls.Add(this.dgv_QLMatHang);
            this.Name = "frm_QLMatHang";
            this.Text = "frm_QLMatHang";
            this.Load += new System.EventHandler(this.frm_QLMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLMatHang;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.ComboBox cmb_IDDvTinh;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label4;
    }
}