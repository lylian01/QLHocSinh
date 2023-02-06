namespace GUI
{
    partial class Form_UC3_PhanCongGiangDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UC3_PhanCongGiangDay));
            this.dtg_phancong = new System.Windows.Forms.DataGridView();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_themphancong = new System.Windows.Forms.Button();
            this.txt_ngayphancong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_tenlophoc = new System.Windows.Forms.ComboBox();
            this.cbb_tengiaovien = new System.Windows.Forms.ComboBox();
            this.cbb_tenmonhoc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_PhanCongGiangDay = new System.Windows.Forms.RadioButton();
            this.rad_tenlophoc = new System.Windows.Forms.RadioButton();
            this.cbb_tenmonhoc2 = new System.Windows.Forms.ComboBox();
            this.rad_tengiaovien = new System.Windows.Forms.RadioButton();
            this.cbb_tengiaovien2 = new System.Windows.Forms.ComboBox();
            this.rad_tenmonhoc = new System.Windows.Forms.RadioButton();
            this.cbb_tenlophoc2 = new System.Windows.Forms.ComboBox();
            this.btn_inbangphancong = new System.Windows.Forms.Button();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.rb_XemInPhanCongGiangDay = new System.Windows.Forms.RadioButton();
            this.groupboxXemPCGD = new System.Windows.Forms.GroupBox();
            this.btn_suaphancong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxPCGD = new System.Windows.Forms.GroupBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phancong)).BeginInit();
            this.groupboxXemPCGD.SuspendLayout();
            this.groupBoxPCGD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_phancong
            // 
            this.dtg_phancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_phancong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenLop,
            this.TenMH,
            this.HoTenGV,
            this.NgayPhanCong});
            this.dtg_phancong.Location = new System.Drawing.Point(50, 400);
            this.dtg_phancong.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_phancong.Name = "dtg_phancong";
            this.dtg_phancong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_phancong.Size = new System.Drawing.Size(927, 239);
            this.dtg_phancong.TabIndex = 76;
            this.dtg_phancong.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_RowEnter);
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên Lớp Học";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 170;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn Học";
            this.TenMH.Name = "TenMH";
            this.TenMH.Width = 170;
            // 
            // HoTenGV
            // 
            this.HoTenGV.DataPropertyName = "HoTenGV";
            this.HoTenGV.HeaderText = "Tên Giáo Viên";
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.Width = 162;
            // 
            // NgayPhanCong
            // 
            this.NgayPhanCong.DataPropertyName = "NgayPhanCong";
            this.NgayPhanCong.HeaderText = "Ngày Phân Công";
            this.NgayPhanCong.Name = "NgayPhanCong";
            this.NgayPhanCong.Width = 137;
            // 
            // btn_themphancong
            // 
            this.btn_themphancong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btn_themphancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_themphancong.Image = global::GUI.Properties.Resources.add2;
            this.btn_themphancong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themphancong.Location = new System.Drawing.Point(49, 216);
            this.btn_themphancong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_themphancong.Name = "btn_themphancong";
            this.btn_themphancong.Size = new System.Drawing.Size(105, 47);
            this.btn_themphancong.TabIndex = 111;
            this.btn_themphancong.Text = "Thêm";
            this.btn_themphancong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_themphancong.UseVisualStyleBackColor = false;
            this.btn_themphancong.Click += new System.EventHandler(this.btn_themphancong_Click);
            // 
            // txt_ngayphancong
            // 
            this.txt_ngayphancong.AcceptsReturn = true;
            this.txt_ngayphancong.Location = new System.Drawing.Point(153, 164);
            this.txt_ngayphancong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngayphancong.Name = "txt_ngayphancong";
            this.txt_ngayphancong.Size = new System.Drawing.Size(241, 22);
            this.txt_ngayphancong.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Ngày Phân Công";
            // 
            // cbb_tenlophoc
            // 
            this.cbb_tenlophoc.FormattingEnabled = true;
            this.cbb_tenlophoc.Location = new System.Drawing.Point(153, 15);
            this.cbb_tenlophoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenlophoc.Name = "cbb_tenlophoc";
            this.cbb_tenlophoc.Size = new System.Drawing.Size(241, 24);
            this.cbb_tenlophoc.TabIndex = 71;
            // 
            // cbb_tengiaovien
            // 
            this.cbb_tengiaovien.FormattingEnabled = true;
            this.cbb_tengiaovien.Location = new System.Drawing.Point(153, 113);
            this.cbb_tengiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tengiaovien.Name = "cbb_tengiaovien";
            this.cbb_tengiaovien.Size = new System.Drawing.Size(241, 24);
            this.cbb_tengiaovien.TabIndex = 70;
            // 
            // cbb_tenmonhoc
            // 
            this.cbb_tenmonhoc.FormattingEnabled = true;
            this.cbb_tenmonhoc.Location = new System.Drawing.Point(153, 63);
            this.cbb_tenmonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenmonhoc.Name = "cbb_tenmonhoc";
            this.cbb_tenmonhoc.Size = new System.Drawing.Size(241, 24);
            this.cbb_tenmonhoc.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tên Lớp Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tên Môn Học";
            // 
            // rb_PhanCongGiangDay
            // 
            this.rb_PhanCongGiangDay.AutoSize = true;
            this.rb_PhanCongGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_PhanCongGiangDay.Location = new System.Drawing.Point(46, 43);
            this.rb_PhanCongGiangDay.Margin = new System.Windows.Forms.Padding(4);
            this.rb_PhanCongGiangDay.Name = "rb_PhanCongGiangDay";
            this.rb_PhanCongGiangDay.Size = new System.Drawing.Size(189, 21);
            this.rb_PhanCongGiangDay.TabIndex = 76;
            this.rb_PhanCongGiangDay.Text = "Phân Công Giảng Dạy";
            this.rb_PhanCongGiangDay.UseVisualStyleBackColor = true;
            this.rb_PhanCongGiangDay.CheckedChanged += new System.EventHandler(this.rb_PhanCongGiangDay_CheckedChanged);
            // 
            // rad_tenlophoc
            // 
            this.rad_tenlophoc.AutoSize = true;
            this.rad_tenlophoc.Location = new System.Drawing.Point(25, 39);
            this.rad_tenlophoc.Margin = new System.Windows.Forms.Padding(4);
            this.rad_tenlophoc.Name = "rad_tenlophoc";
            this.rad_tenlophoc.Size = new System.Drawing.Size(111, 21);
            this.rad_tenlophoc.TabIndex = 58;
            this.rad_tenlophoc.TabStop = true;
            this.rad_tenlophoc.Text = "Tên Lớp Học";
            this.rad_tenlophoc.UseVisualStyleBackColor = true;
            this.rad_tenlophoc.CheckedChanged += new System.EventHandler(this.rad_tenlophoc_CheckedChanged);
            // 
            // cbb_tenmonhoc2
            // 
            this.cbb_tenmonhoc2.FormattingEnabled = true;
            this.cbb_tenmonhoc2.Location = new System.Drawing.Point(162, 83);
            this.cbb_tenmonhoc2.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenmonhoc2.Name = "cbb_tenmonhoc2";
            this.cbb_tenmonhoc2.Size = new System.Drawing.Size(228, 24);
            this.cbb_tenmonhoc2.TabIndex = 55;
            // 
            // rad_tengiaovien
            // 
            this.rad_tengiaovien.AutoSize = true;
            this.rad_tengiaovien.Location = new System.Drawing.Point(25, 137);
            this.rad_tengiaovien.Margin = new System.Windows.Forms.Padding(4);
            this.rad_tengiaovien.Name = "rad_tengiaovien";
            this.rad_tengiaovien.Size = new System.Drawing.Size(120, 21);
            this.rad_tengiaovien.TabIndex = 60;
            this.rad_tengiaovien.TabStop = true;
            this.rad_tengiaovien.Text = "Tên Giáo Viên";
            this.rad_tengiaovien.UseVisualStyleBackColor = true;
            this.rad_tengiaovien.CheckedChanged += new System.EventHandler(this.rad_tengiaovien_CheckedChanged);
            // 
            // cbb_tengiaovien2
            // 
            this.cbb_tengiaovien2.FormattingEnabled = true;
            this.cbb_tengiaovien2.Location = new System.Drawing.Point(162, 134);
            this.cbb_tengiaovien2.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tengiaovien2.Name = "cbb_tengiaovien2";
            this.cbb_tengiaovien2.Size = new System.Drawing.Size(228, 24);
            this.cbb_tengiaovien2.TabIndex = 56;
            // 
            // rad_tenmonhoc
            // 
            this.rad_tenmonhoc.AutoSize = true;
            this.rad_tenmonhoc.Location = new System.Drawing.Point(25, 87);
            this.rad_tenmonhoc.Margin = new System.Windows.Forms.Padding(4);
            this.rad_tenmonhoc.Name = "rad_tenmonhoc";
            this.rad_tenmonhoc.Size = new System.Drawing.Size(114, 21);
            this.rad_tenmonhoc.TabIndex = 59;
            this.rad_tenmonhoc.TabStop = true;
            this.rad_tenmonhoc.Text = "Tên Môn Học";
            this.rad_tenmonhoc.UseVisualStyleBackColor = true;
            this.rad_tenmonhoc.CheckedChanged += new System.EventHandler(this.rad_tenmonhoc_CheckedChanged);
            // 
            // cbb_tenlophoc2
            // 
            this.cbb_tenlophoc2.FormattingEnabled = true;
            this.cbb_tenlophoc2.Location = new System.Drawing.Point(162, 35);
            this.cbb_tenlophoc2.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_tenlophoc2.Name = "cbb_tenlophoc2";
            this.cbb_tenlophoc2.Size = new System.Drawing.Size(228, 24);
            this.cbb_tenlophoc2.TabIndex = 57;
            // 
            // btn_inbangphancong
            // 
            this.btn_inbangphancong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(126)))));
            this.btn_inbangphancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inbangphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inbangphancong.Image = global::GUI.Properties.Resources.print;
            this.btn_inbangphancong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inbangphancong.Location = new System.Drawing.Point(171, 204);
            this.btn_inbangphancong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_inbangphancong.Name = "btn_inbangphancong";
            this.btn_inbangphancong.Size = new System.Drawing.Size(230, 47);
            this.btn_inbangphancong.TabIndex = 77;
            this.btn_inbangphancong.Text = "In Bảng Phân Công";
            this.btn_inbangphancong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_inbangphancong.UseVisualStyleBackColor = false;
            this.btn_inbangphancong.Click += new System.EventHandler(this.btn_inbangphancong_Click);
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hienthi.Image = global::GUI.Properties.Resources.search3;
            this.btn_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthi.Location = new System.Drawing.Point(25, 207);
            this.btn_hienthi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(131, 41);
            this.btn_hienthi.TabIndex = 103;
            this.btn_hienthi.Text = "Hiển thị ";
            this.btn_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_hienthi_Click);
            // 
            // rb_XemInPhanCongGiangDay
            // 
            this.rb_XemInPhanCongGiangDay.AutoSize = true;
            this.rb_XemInPhanCongGiangDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_XemInPhanCongGiangDay.Location = new System.Drawing.Point(524, 43);
            this.rb_XemInPhanCongGiangDay.Margin = new System.Windows.Forms.Padding(4);
            this.rb_XemInPhanCongGiangDay.Name = "rb_XemInPhanCongGiangDay";
            this.rb_XemInPhanCongGiangDay.Size = new System.Drawing.Size(243, 21);
            this.rb_XemInPhanCongGiangDay.TabIndex = 70;
            this.rb_XemInPhanCongGiangDay.Text = "Xem/In Phân Công Giảng Dạy";
            this.rb_XemInPhanCongGiangDay.UseVisualStyleBackColor = true;
            this.rb_XemInPhanCongGiangDay.CheckedChanged += new System.EventHandler(this.rb_XemInPhanCongGiangDay_CheckedChanged);
            // 
            // groupboxXemPCGD
            // 
            this.groupboxXemPCGD.Controls.Add(this.rad_tenlophoc);
            this.groupboxXemPCGD.Controls.Add(this.cbb_tenlophoc2);
            this.groupboxXemPCGD.Controls.Add(this.btn_inbangphancong);
            this.groupboxXemPCGD.Controls.Add(this.btn_hienthi);
            this.groupboxXemPCGD.Controls.Add(this.rad_tenmonhoc);
            this.groupboxXemPCGD.Controls.Add(this.cbb_tengiaovien2);
            this.groupboxXemPCGD.Controls.Add(this.cbb_tenmonhoc2);
            this.groupboxXemPCGD.Controls.Add(this.rad_tengiaovien);
            this.groupboxXemPCGD.Location = new System.Drawing.Point(524, 72);
            this.groupboxXemPCGD.Margin = new System.Windows.Forms.Padding(4);
            this.groupboxXemPCGD.Name = "groupboxXemPCGD";
            this.groupboxXemPCGD.Padding = new System.Windows.Forms.Padding(4);
            this.groupboxXemPCGD.Size = new System.Drawing.Size(416, 274);
            this.groupboxXemPCGD.TabIndex = 79;
            this.groupboxXemPCGD.TabStop = false;
            // 
            // btn_suaphancong
            // 
            this.btn_suaphancong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_suaphancong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suaphancong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_suaphancong.Image = global::GUI.Properties.Resources.edit2;
            this.btn_suaphancong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_suaphancong.Location = new System.Drawing.Point(191, 216);
            this.btn_suaphancong.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suaphancong.Name = "btn_suaphancong";
            this.btn_suaphancong.Size = new System.Drawing.Size(100, 47);
            this.btn_suaphancong.TabIndex = 112;
            this.btn_suaphancong.Text = "Sửa";
            this.btn_suaphancong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_suaphancong.UseVisualStyleBackColor = false;
            this.btn_suaphancong.Click += new System.EventHandler(this.btn_suaphancong_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.Image = global::GUI.Properties.Resources.delete1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(337, 216);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 47);
            this.button1.TabIndex = 114;
            this.button1.Text = "Xóa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBoxPCGD
            // 
            this.groupBoxPCGD.Controls.Add(this.button1);
            this.groupBoxPCGD.Controls.Add(this.txt_ngayphancong);
            this.groupBoxPCGD.Controls.Add(this.btn_themphancong);
            this.groupBoxPCGD.Controls.Add(this.btn_suaphancong);
            this.groupBoxPCGD.Controls.Add(this.label2);
            this.groupBoxPCGD.Controls.Add(this.cbb_tenlophoc);
            this.groupBoxPCGD.Controls.Add(this.label3);
            this.groupBoxPCGD.Controls.Add(this.cbb_tenmonhoc);
            this.groupBoxPCGD.Controls.Add(this.cbb_tengiaovien);
            this.groupBoxPCGD.Controls.Add(this.label4);
            this.groupBoxPCGD.Controls.Add(this.label1);
            this.groupBoxPCGD.Location = new System.Drawing.Point(31, 71);
            this.groupBoxPCGD.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxPCGD.Name = "groupBoxPCGD";
            this.groupBoxPCGD.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxPCGD.Size = new System.Drawing.Size(470, 275);
            this.groupBoxPCGD.TabIndex = 79;
            this.groupBoxPCGD.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_reset.Image = global::GUI.Properties.Resources.retype3;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reset.Location = new System.Drawing.Point(971, 84);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(147, 47);
            this.btn_reset.TabIndex = 109;
            this.btn_reset.Text = "Nhập lại";
            this.btn_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(51, 371);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 18);
            this.label5.TabIndex = 110;
            this.label5.Text = "Danh sách phân công ";
            // 
            // Form_UC3_PhanCongGiangDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1145, 675);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupboxXemPCGD);
            this.Controls.Add(this.groupBoxPCGD);
            this.Controls.Add(this.rb_PhanCongGiangDay);
            this.Controls.Add(this.rb_XemInPhanCongGiangDay);
            this.Controls.Add(this.dtg_phancong);
            this.Controls.Add(this.btn_reset);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC3_PhanCongGiangDay";
            this.Text = "Form_UC3_PhanCongGiangDay";
            this.Load += new System.EventHandler(this.Form_UC3_PhanCongGiangDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_phancong)).EndInit();
            this.groupboxXemPCGD.ResumeLayout(false);
            this.groupboxXemPCGD.PerformLayout();
            this.groupBoxPCGD.ResumeLayout(false);
            this.groupBoxPCGD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_phancong;
        private System.Windows.Forms.Button btn_themphancong;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_ngayphancong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_tenlophoc;
        private System.Windows.Forms.ComboBox cbb_tengiaovien;
        private System.Windows.Forms.ComboBox cbb_tenmonhoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_PhanCongGiangDay;
        private System.Windows.Forms.RadioButton rad_tenlophoc;
        private System.Windows.Forms.ComboBox cbb_tenmonhoc2;
        private System.Windows.Forms.RadioButton rad_tengiaovien;
        private System.Windows.Forms.ComboBox cbb_tengiaovien2;
        private System.Windows.Forms.RadioButton rad_tenmonhoc;
        private System.Windows.Forms.ComboBox cbb_tenlophoc2;
        private System.Windows.Forms.GroupBox groupboxXemPCGD;
        private System.Windows.Forms.RadioButton rb_XemInPhanCongGiangDay;
        private System.Windows.Forms.Button btn_inbangphancong;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_suaphancong;
        private System.Windows.Forms.GroupBox groupBoxPCGD;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayPhanCong;
    }
}