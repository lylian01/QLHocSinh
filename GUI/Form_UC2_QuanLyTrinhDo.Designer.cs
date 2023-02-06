namespace GUI
{
    partial class Form_UC2_QuanLyTrinhDo
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
            this.dgv_TrinhDo = new System.Windows.Forms.DataGridView();
            this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_TenTrinhDo = new System.Windows.Forms.TextBox();
            this.txt_MaTrinhDo = new System.Windows.Forms.TextBox();
            this.label_TenTrinhDo = new System.Windows.Forms.Label();
            this.label_MaTrinhDo = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrinhDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_TrinhDo
            // 
            this.dgv_TrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TrinhDo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTD,
            this.TenTD});
            this.dgv_TrinhDo.Location = new System.Drawing.Point(61, 324);
            this.dgv_TrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_TrinhDo.Name = "dgv_TrinhDo";
            this.dgv_TrinhDo.Size = new System.Drawing.Size(699, 234);
            this.dgv_TrinhDo.TabIndex = 74;
            this.dgv_TrinhDo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TrinhDo_RowEnter);
            // 
            // MaTD
            // 
            this.MaTD.DataPropertyName = "MaTD";
            this.MaTD.HeaderText = "Mã trình độ";
            this.MaTD.Name = "MaTD";
            this.MaTD.Width = 130;
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenTD";
            this.TenTD.HeaderText = "Tên trình độ";
            this.TenTD.Name = "TenTD";
            this.TenTD.Width = 130;
            // 
            // ChuyenNganh
            // 
            this.ChuyenNganh.Name = "ChuyenNganh";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(650, 49);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(200, 22);
            this.txt_TimKiem.TabIndex = 71;
            // 
            // txt_TenTrinhDo
            // 
            this.txt_TenTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenTrinhDo.Location = new System.Drawing.Point(154, 91);
            this.txt_TenTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenTrinhDo.Name = "txt_TenTrinhDo";
            this.txt_TenTrinhDo.Size = new System.Drawing.Size(276, 22);
            this.txt_TenTrinhDo.TabIndex = 69;
            // 
            // txt_MaTrinhDo
            // 
            this.txt_MaTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaTrinhDo.Location = new System.Drawing.Point(154, 38);
            this.txt_MaTrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaTrinhDo.Name = "txt_MaTrinhDo";
            this.txt_MaTrinhDo.Size = new System.Drawing.Size(276, 22);
            this.txt_MaTrinhDo.TabIndex = 68;
            // 
            // label_TenTrinhDo
            // 
            this.label_TenTrinhDo.AutoSize = true;
            this.label_TenTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TenTrinhDo.Location = new System.Drawing.Point(18, 100);
            this.label_TenTrinhDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenTrinhDo.Name = "label_TenTrinhDo";
            this.label_TenTrinhDo.Size = new System.Drawing.Size(85, 17);
            this.label_TenTrinhDo.TabIndex = 66;
            this.label_TenTrinhDo.Text = "Tên trình độ";
            // 
            // label_MaTrinhDo
            // 
            this.label_MaTrinhDo.AutoSize = true;
            this.label_MaTrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaTrinhDo.Location = new System.Drawing.Point(18, 43);
            this.label_MaTrinhDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaTrinhDo.Name = "label_MaTrinhDo";
            this.label_MaTrinhDo.Size = new System.Drawing.Size(79, 17);
            this.label_MaTrinhDo.TabIndex = 65;
            this.label_MaTrinhDo.Text = "Mã trình độ";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Image = global::GUI.Properties.Resources.delete1;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(368, 95);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 47);
            this.btn_Xoa.TabIndex = 124;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Image = global::GUI.Properties.Resources.edit2;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(220, 95);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 47);
            this.btn_Sua.TabIndex = 123;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(164)))));
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xem.ForeColor = System.Drawing.Color.Black;
            this.btn_Xem.Image = global::GUI.Properties.Resources.see6;
            this.btn_Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xem.Location = new System.Drawing.Point(128, 24);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xem.Size = new System.Drawing.Size(112, 47);
            this.btn_Xem.TabIndex = 121;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.UseWaitCursor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Image = global::GUI.Properties.Resources.add2;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(51, 95);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 47);
            this.btn_Them.TabIndex = 122;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btn_NhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_NhapLai.Image = global::GUI.Properties.Resources.retype1;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(306, 24);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(142, 47);
            this.btn_NhapLai.TabIndex = 120;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search1;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(910, 39);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(137, 41);
            this.btn_TimKiem.TabIndex = 125;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Xem);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_NhapLai);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(588, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 161);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tác Vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TenTrinhDo);
            this.groupBox2.Controls.Add(this.txt_MaTrinhDo);
            this.groupBox2.Controls.Add(this.label_TenTrinhDo);
            this.groupBox2.Controls.Add(this.label_MaTrinhDo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(61, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 144);
            this.groupBox2.TabIndex = 127;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin trình độ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(64, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 128;
            this.label1.Text = "Danh sách trình độ";
            // 
            // Form_UC1_QuanLyTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.dgv_TrinhDo);
            this.Controls.Add(this.txt_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC1_QuanLyTrinhDo";
            this.Text = "Form_UC1_QuanLyTrinhDo";
            this.Load += new System.EventHandler(this.Form_QuanLyTrinhDo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TrinhDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_TrinhDo;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_TenTrinhDo;
        private System.Windows.Forms.TextBox txt_MaTrinhDo;
        private System.Windows.Forms.Label label_TenTrinhDo;
        private System.Windows.Forms.Label label_MaTrinhDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
    }
}