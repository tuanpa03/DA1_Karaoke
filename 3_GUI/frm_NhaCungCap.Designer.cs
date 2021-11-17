
namespace _3_GUI
{
    partial class frm_NhaCungCap
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
            this.dgrid_DataOfNCC = new System.Windows.Forms.DataGridView();
            this.txt_NameOfNcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.txt_NumberPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DataOfNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_DataOfNCC
            // 
            this.dgrid_DataOfNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_DataOfNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DataOfNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_DataOfNCC.Location = new System.Drawing.Point(0, 225);
            this.dgrid_DataOfNCC.Name = "dgrid_DataOfNCC";
            this.dgrid_DataOfNCC.RowHeadersWidth = 51;
            this.dgrid_DataOfNCC.RowTemplate.Height = 29;
            this.dgrid_DataOfNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_DataOfNCC.Size = new System.Drawing.Size(800, 225);
            this.dgrid_DataOfNCC.TabIndex = 0;
            this.dgrid_DataOfNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_DataOfNCC_CellClick);
            // 
            // txt_NameOfNcc
            // 
            this.txt_NameOfNcc.Location = new System.Drawing.Point(152, 32);
            this.txt_NameOfNcc.Name = "txt_NameOfNcc";
            this.txt_NameOfNcc.Size = new System.Drawing.Size(227, 27);
            this.txt_NameOfNcc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(326, 170);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(94, 29);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(444, 170);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(94, 29);
            this.btn_Update.TabIndex = 3;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(562, 170);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(94, 29);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(680, 170);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(94, 29);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txt_NumberPhone
            // 
            this.txt_NumberPhone.Location = new System.Drawing.Point(152, 102);
            this.txt_NumberPhone.Name = "txt_NumberPhone";
            this.txt_NumberPhone.Size = new System.Drawing.Size(227, 27);
            this.txt_NumberPhone.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(547, 29);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(227, 27);
            this.txt_Address.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(547, 103);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(227, 27);
            this.txt_Email.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_NumberPhone);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.txt_NameOfNcc);
            this.Controls.Add(this.dgrid_DataOfNCC);
            this.Name = "frm_NhaCungCap";
            this.Text = "frm_NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DataOfNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_DataOfNCC;
        private System.Windows.Forms.TextBox txt_NameOfNcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.TextBox txt_NumberPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}