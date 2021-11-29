
namespace _3_GUI
{
    partial class frm_CongThucTinh
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
            this.dgrid_DataOfCTT = new System.Windows.Forms.DataGridView();
            this.btn_Add = new System.Windows.Forms.Button();
            this.txt_TGUD1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UD1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TGUD2 = new System.Windows.Forms.TextBox();
            this.txt_UD2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_TGUD3 = new System.Windows.Forms.TextBox();
            this.txt_UD3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.txt_PriceOfRoom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_PriceOfVIPRoom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DataOfCTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_DataOfCTT
            // 
            this.dgrid_DataOfCTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_DataOfCTT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_DataOfCTT.Location = new System.Drawing.Point(0, 392);
            this.dgrid_DataOfCTT.Name = "dgrid_DataOfCTT";
            this.dgrid_DataOfCTT.RowHeadersWidth = 51;
            this.dgrid_DataOfCTT.RowTemplate.Height = 29;
            this.dgrid_DataOfCTT.Size = new System.Drawing.Size(800, 235);
            this.dgrid_DataOfCTT.TabIndex = 0;
            this.dgrid_DataOfCTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrid_DataOfCTT_CellClick);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(74, 314);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(108, 44);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_TGUD1
            // 
            this.txt_TGUD1.Location = new System.Drawing.Point(149, 45);
            this.txt_TGUD1.Name = "txt_TGUD1";
            this.txt_TGUD1.Size = new System.Drawing.Size(135, 27);
            this.txt_TGUD1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "TGUĐ1";
            // 
            // txt_UD1
            // 
            this.txt_UD1.Location = new System.Drawing.Point(149, 113);
            this.txt_UD1.Name = "txt_UD1";
            this.txt_UD1.Size = new System.Drawing.Size(135, 27);
            this.txt_UD1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ưu đãi 1";
            // 
            // txt_TGUD2
            // 
            this.txt_TGUD2.Location = new System.Drawing.Point(378, 45);
            this.txt_TGUD2.Name = "txt_TGUD2";
            this.txt_TGUD2.Size = new System.Drawing.Size(135, 27);
            this.txt_TGUD2.TabIndex = 2;
            // 
            // txt_UD2
            // 
            this.txt_UD2.Location = new System.Drawing.Point(378, 110);
            this.txt_UD2.Name = "txt_UD2";
            this.txt_UD2.Size = new System.Drawing.Size(135, 27);
            this.txt_UD2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "TGUĐ2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ưu đãi 2";
            // 
            // txt_TGUD3
            // 
            this.txt_TGUD3.Location = new System.Drawing.Point(653, 45);
            this.txt_TGUD3.Name = "txt_TGUD3";
            this.txt_TGUD3.Size = new System.Drawing.Size(135, 27);
            this.txt_TGUD3.TabIndex = 2;
            // 
            // txt_UD3
            // 
            this.txt_UD3.Location = new System.Drawing.Point(653, 110);
            this.txt_UD3.Name = "txt_UD3";
            this.txt_UD3.Size = new System.Drawing.Size(135, 27);
            this.txt_UD3.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "TGUĐ3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(584, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ưu đãi 3";
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(378, 174);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.Size = new System.Drawing.Size(410, 104);
            this.txt_Note.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ghi chú";
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(246, 314);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(108, 44);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Sửa";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(418, 314);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 44);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // txt_PriceOfRoom
            // 
            this.txt_PriceOfRoom.Location = new System.Drawing.Point(149, 180);
            this.txt_PriceOfRoom.Name = "txt_PriceOfRoom";
            this.txt_PriceOfRoom.Size = new System.Drawing.Size(135, 27);
            this.txt_PriceOfRoom.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Giá Phòng";
            // 
            // txt_PriceOfVIPRoom
            // 
            this.txt_PriceOfVIPRoom.Location = new System.Drawing.Point(149, 251);
            this.txt_PriceOfVIPRoom.Name = "txt_PriceOfVIPRoom";
            this.txt_PriceOfVIPRoom.Size = new System.Drawing.Size(135, 27);
            this.txt_PriceOfVIPRoom.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Giá phòng VIP";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(598, 314);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(108, 44);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frm_CongThucTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 627);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_UD3);
            this.Controls.Add(this.txt_UD2);
            this.Controls.Add(this.txt_TGUD3);
            this.Controls.Add(this.txt_TGUD2);
            this.Controls.Add(this.txt_Note);
            this.Controls.Add(this.txt_PriceOfVIPRoom);
            this.Controls.Add(this.txt_PriceOfRoom);
            this.Controls.Add(this.txt_UD1);
            this.Controls.Add(this.txt_TGUD1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.dgrid_DataOfCTT);
            this.Name = "frm_CongThucTinh";
            this.Text = "frm_CongThucTinh";
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_DataOfCTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_DataOfCTT;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_TGUD1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UD1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TGUD2;
        private System.Windows.Forms.TextBox txt_UD2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TGUD3;
        private System.Windows.Forms.TextBox txt_UD3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.TextBox txt_PriceOfRoom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_PriceOfVIPRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Clear;
    }
}