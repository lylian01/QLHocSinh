namespace GUI
{
    partial class Form_UC1_QuanLyMonHoc
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
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_SoTiet = new System.Windows.Forms.TextBox();
            this.txt_TenMonHoc = new System.Windows.Forms.TextBox();
            this.txt_MaMoHoc = new System.Windows.Forms.TextBox();
            this.label_SoTiet = new System.Windows.Forms.Label();
            this.label_TenMonHoc = new System.Windows.Forms.Label();
            this.label_MaMonHoc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_NhapLai = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTiet});
            this.dgv_MonHoc.Location = new System.Drawing.Point(520, 68);
            this.dgv_MonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MonHoc.Size = new System.Drawing.Size(598, 471);
            this.dgv_MonHoc.TabIndex = 77;
            this.dgv_MonHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_RowEnter);
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 130;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 200;
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.HeaderText = "Số tiết";
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Width = 75;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search3;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(264, 283);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(134, 41);
            this.btn_TimKiem.TabIndex = 103;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(39, 293);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(208, 22);
            this.txt_TimKiem.TabIndex = 68;
            // 
            // txt_SoTiet
            // 
            this.txt_SoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoTiet.Location = new System.Drawing.Point(127, 149);
            this.txt_SoTiet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoTiet.Name = "txt_SoTiet";
            this.txt_SoTiet.Size = new System.Drawing.Size(319, 22);
            this.txt_SoTiet.TabIndex = 67;
            // 
            // txt_TenMonHoc
            // 
            this.txt_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenMonHoc.Location = new System.Drawing.Point(127, 92);
            this.txt_TenMonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMonHoc.Name = "txt_TenMonHoc";
            this.txt_TenMonHoc.Size = new System.Drawing.Size(319, 22);
            this.txt_TenMonHoc.TabIndex = 66;
            // 
            // txt_MaMoHoc
            // 
            this.txt_MaMoHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaMoHoc.Location = new System.Drawing.Point(127, 36);
            this.txt_MaMoHoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaMoHoc.Name = "txt_MaMoHoc";
            this.txt_MaMoHoc.Size = new System.Drawing.Size(319, 22);
            this.txt_MaMoHoc.TabIndex = 65;
            // 
            // label_SoTiet
            // 
            this.label_SoTiet.AutoSize = true;
            this.label_SoTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SoTiet.Location = new System.Drawing.Point(15, 149);
            this.label_SoTiet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoTiet.Name = "label_SoTiet";
            this.label_SoTiet.Size = new System.Drawing.Size(48, 17);
            this.label_SoTiet.TabIndex = 64;
            this.label_SoTiet.Text = "Số tiết";
            // 
            // label_TenMonHoc
            // 
            this.label_TenMonHoc.AutoSize = true;
            this.label_TenMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TenMonHoc.Location = new System.Drawing.Point(15, 92);
            this.label_TenMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TenMonHoc.Name = "label_TenMonHoc";
            this.label_TenMonHoc.Size = new System.Drawing.Size(91, 17);
            this.label_TenMonHoc.TabIndex = 63;
            this.label_TenMonHoc.Text = "Tên môn học";
            // 
            // label_MaMonHoc
            // 
            this.label_MaMonHoc.AutoSize = true;
            this.label_MaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaMonHoc.Location = new System.Drawing.Point(15, 36);
            this.label_MaMonHoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaMonHoc.Name = "label_MaMonHoc";
            this.label_MaMonHoc.Size = new System.Drawing.Size(85, 17);
            this.label_MaMonHoc.TabIndex = 62;
            this.label_MaMonHoc.Text = "Mã môn học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SoTiet);
            this.groupBox1.Controls.Add(this.txt_TenMonHoc);
            this.groupBox1.Controls.Add(this.txt_MaMoHoc);
            this.groupBox1.Controls.Add(this.label_SoTiet);
            this.groupBox1.Controls.Add(this.label_TenMonHoc);
            this.groupBox1.Controls.Add(this.label_MaMonHoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(26, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 195);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp ";
            // 
            // btn_NhapLai
            // 
            this.btn_NhapLai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btn_NhapLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_NhapLai.Image = global::GUI.Properties.Resources.retype3;
            this.btn_NhapLai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NhapLai.Location = new System.Drawing.Point(254, 39);
            this.btn_NhapLai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NhapLai.Name = "btn_NhapLai";
            this.btn_NhapLai.Size = new System.Drawing.Size(136, 47);
            this.btn_NhapLai.TabIndex = 109;
            this.btn_NhapLai.Text = "Nhập lại";
            this.btn_NhapLai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NhapLai.UseVisualStyleBackColor = false;
            this.btn_NhapLai.Click += new System.EventHandler(this.btn_NhapLai_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Them.Image = global::GUI.Properties.Resources.add2;
            this.btn_Them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Them.Location = new System.Drawing.Point(11, 125);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(105, 47);
            this.btn_Them.TabIndex = 111;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(164)))));
            this.btn_Xem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xem.ForeColor = System.Drawing.Color.Black;
            this.btn_Xem.Image = global::GUI.Properties.Resources.see2;
            this.btn_Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xem.Location = new System.Drawing.Point(75, 39);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xem.Size = new System.Drawing.Size(103, 47);
            this.btn_Xem.TabIndex = 110;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Sua.Image = global::GUI.Properties.Resources.edit2;
            this.btn_Sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sua.Location = new System.Drawing.Point(173, 125);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(100, 47);
            this.btn_Sua.TabIndex = 112;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xoa.Image = global::GUI.Properties.Resources.delete1;
            this.btn_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xoa.Location = new System.Drawing.Point(329, 125);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(100, 47);
            this.btn_Xoa.TabIndex = 114;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Xoa);
            this.groupBox2.Controls.Add(this.btn_NhapLai);
            this.groupBox2.Controls.Add(this.btn_Them);
            this.groupBox2.Controls.Add(this.btn_Xem);
            this.groupBox2.Controls.Add(this.btn_Sua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(26, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(448, 188);
            this.groupBox2.TabIndex = 115;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ ";
            // 
            // Form_UC1_QuanLyMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1145, 695);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_MonHoc);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC1_QuanLyMonHoc";
            this.Text = "Form_UC1_Quản Lý Môn Học";
            this.Load += new System.EventHandler(this.Form_QuanLyMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.TextBox txt_SoTiet;
        private System.Windows.Forms.TextBox txt_TenMonHoc;
        private System.Windows.Forms.TextBox txt_MaMoHoc;
        private System.Windows.Forms.Label label_SoTiet;
        private System.Windows.Forms.Label label_TenMonHoc;
        private System.Windows.Forms.Label label_MaMonHoc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_NhapLai;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        public System.Windows.Forms.Button btn_Them;
        public System.Windows.Forms.Button btn_Sua;
        public System.Windows.Forms.Button btn_Xoa;
    }
}

