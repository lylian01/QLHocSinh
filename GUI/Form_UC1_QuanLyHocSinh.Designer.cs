namespace GUI
{
    partial class Form_UC1_QuanLyHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UC1_QuanLyHocSinh));
            this.dgv_HocSinh = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_Nu = new System.Windows.Forms.RadioButton();
            this.rb_Nam = new System.Windows.Forms.RadioButton();
            this.cbo_TenLop = new System.Windows.Forms.ComboBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label_MaLop = new System.Windows.Forms.Label();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label_DiaChi = new System.Windows.Forms.Label();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.txt_NgaySinh = new System.Windows.Forms.TextBox();
            this.txt_TenHocSinh = new System.Windows.Forms.TextBox();
            this.txt_MaHocSinh = new System.Windows.Forms.TextBox();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_MaHS = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_indshs = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocSinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_HocSinh
            // 
            this.dgv_HocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTenHS,
            this.NgaySinh,
            this.GioiTinh,
            this.DiaChi,
            this.Email,
            this.TenLop});
            this.dgv_HocSinh.Location = new System.Drawing.Point(29, 401);
            this.dgv_HocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_HocSinh.MultiSelect = false;
            this.dgv_HocSinh.AutoGenerateColumns = false;
            this.dgv_HocSinh.Name = "dgv_HocSinh";
            this.dgv_HocSinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_HocSinh.Size = new System.Drawing.Size(1019, 232);
            this.dgv_HocSinh.TabIndex = 105;
            this.dgv_HocSinh.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopHoc_RowEnter);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã học sinh";
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 75;
            // 
            // HoTenHS
            // 
            this.HoTenHS.DataPropertyName = "HoTenHS";
            this.HoTenHS.HeaderText = "Họ tên";
            this.HoTenHS.Name = "HoTenHS";
            this.HoTenHS.Width = 132;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 75;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 120;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(660, 63);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(200, 22);
            this.txt_TimKiem.TabIndex = 102;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Nu);
            this.groupBox1.Controls.Add(this.rb_Nam);
            this.groupBox1.Controls.Add(this.cbo_TenLop);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.label_MaLop);
            this.groupBox1.Controls.Add(this.label_SoDienThoai);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.label_DiaChi);
            this.groupBox1.Controls.Add(this.label_GioiTinh);
            this.groupBox1.Controls.Add(this.txt_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_TenHocSinh);
            this.groupBox1.Controls.Add(this.txt_MaHocSinh);
            this.groupBox1.Controls.Add(this.label_NgaySinh);
            this.groupBox1.Controls.Add(this.label_HoTen);
            this.groupBox1.Controls.Add(this.label_MaHS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(28, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 317);
            this.groupBox1.TabIndex = 125;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin học sinh ";
            // 
            // rb_Nu
            // 
            this.rb_Nu.AutoSize = true;
            this.rb_Nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rb_Nu.Location = new System.Drawing.Point(348, 143);
            this.rb_Nu.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Nu.Name = "rb_Nu";
            this.rb_Nu.Size = new System.Drawing.Size(47, 21);
            this.rb_Nu.TabIndex = 139;
            this.rb_Nu.TabStop = true;
            this.rb_Nu.Text = "Nữ";
            this.rb_Nu.UseVisualStyleBackColor = true;
            // 
            // rb_Nam
            // 
            this.rb_Nam.AutoSize = true;
            this.rb_Nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rb_Nam.Location = new System.Drawing.Point(194, 143);
            this.rb_Nam.Margin = new System.Windows.Forms.Padding(4);
            this.rb_Nam.Name = "rb_Nam";
            this.rb_Nam.Size = new System.Drawing.Size(58, 21);
            this.rb_Nam.TabIndex = 138;
            this.rb_Nam.TabStop = true;
            this.rb_Nam.Text = "Nam";
            this.rb_Nam.UseVisualStyleBackColor = true;
            // 
            // cbo_TenLop
            // 
            this.cbo_TenLop.DisplayMember = "TenLop";
            this.cbo_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_TenLop.FormattingEnabled = true;
            this.cbo_TenLop.Location = new System.Drawing.Point(194, 263);
            this.cbo_TenLop.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TenLop.Name = "cbo_TenLop";
            this.cbo_TenLop.Size = new System.Drawing.Size(319, 24);
            this.cbo_TenLop.TabIndex = 137;
            this.cbo_TenLop.ValueMember = "MaLop";
            // 
            // txt_Email
            // 
            this.txt_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_Email.Location = new System.Drawing.Point(194, 222);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(319, 22);
            this.txt_Email.TabIndex = 136;
            // 
            // label_MaLop
            // 
            this.label_MaLop.AutoSize = true;
            this.label_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaLop.Location = new System.Drawing.Point(49, 271);
            this.label_MaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaLop.Name = "label_MaLop";
            this.label_MaLop.Size = new System.Drawing.Size(56, 17);
            this.label_MaLop.TabIndex = 135;
            this.label_MaLop.Text = "Tên lớp";
            // 
            // label_SoDienThoai
            // 
            this.label_SoDienThoai.AutoSize = true;
            this.label_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SoDienThoai.Location = new System.Drawing.Point(49, 229);
            this.label_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoDienThoai.Name = "label_SoDienThoai";
            this.label_SoDienThoai.Size = new System.Drawing.Size(42, 17);
            this.label_SoDienThoai.TabIndex = 134;
            this.label_SoDienThoai.Text = "Email";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChi.Location = new System.Drawing.Point(194, 180);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(319, 22);
            this.txt_DiaChi.TabIndex = 133;
            // 
            // label_DiaChi
            // 
            this.label_DiaChi.AutoSize = true;
            this.label_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DiaChi.Location = new System.Drawing.Point(49, 186);
            this.label_DiaChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_DiaChi.Name = "label_DiaChi";
            this.label_DiaChi.Size = new System.Drawing.Size(51, 17);
            this.label_DiaChi.TabIndex = 132;
            this.label_DiaChi.Text = "Địa chỉ";
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_GioiTinh.Location = new System.Drawing.Point(49, 148);
            this.label_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(60, 17);
            this.label_GioiTinh.TabIndex = 131;
            this.label_GioiTinh.Text = "Giới tính";
            // 
            // txt_NgaySinh
            // 
            this.txt_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_NgaySinh.Location = new System.Drawing.Point(194, 104);
            this.txt_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NgaySinh.Name = "txt_NgaySinh";
            this.txt_NgaySinh.Size = new System.Drawing.Size(319, 22);
            this.txt_NgaySinh.TabIndex = 130;
            // 
            // txt_TenHocSinh
            // 
            this.txt_TenHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenHocSinh.Location = new System.Drawing.Point(194, 63);
            this.txt_TenHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenHocSinh.Name = "txt_TenHocSinh";
            this.txt_TenHocSinh.Size = new System.Drawing.Size(319, 22);
            this.txt_TenHocSinh.TabIndex = 129;
            // 
            // txt_MaHocSinh
            // 
            this.txt_MaHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaHocSinh.Location = new System.Drawing.Point(194, 28);
            this.txt_MaHocSinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaHocSinh.Name = "txt_MaHocSinh";
            this.txt_MaHocSinh.Size = new System.Drawing.Size(319, 22);
            this.txt_MaHocSinh.TabIndex = 128;
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NgaySinh.Location = new System.Drawing.Point(49, 113);
            this.label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(71, 17);
            this.label_NgaySinh.TabIndex = 127;
            this.label_NgaySinh.Text = "Ngày sinh";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_HoTen.Location = new System.Drawing.Point(49, 71);
            this.label_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(50, 17);
            this.label_HoTen.TabIndex = 126;
            this.label_HoTen.Text = "Họ tên";
            // 
            // label_MaHS
            // 
            this.label_MaHS.AutoSize = true;
            this.label_MaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaHS.Location = new System.Drawing.Point(48, 36);
            this.label_MaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaHS.Name = "label_MaHS";
            this.label_MaHS.Size = new System.Drawing.Size(84, 17);
            this.label_MaHS.TabIndex = 125;
            this.label_MaHS.Text = "Mã học sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_indshs);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btn_Xem);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(642, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 208);
            this.groupBox2.TabIndex = 126;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_indshs
            // 
            this.btn_indshs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(126)))));
            this.btn_indshs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_indshs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indshs.Image = global::GUI.Properties.Resources.print;
            this.btn_indshs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indshs.Location = new System.Drawing.Point(312, 41);
            this.btn_indshs.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indshs.Name = "btn_indshs";
            this.btn_indshs.Size = new System.Drawing.Size(151, 47);
            this.btn_indshs.TabIndex = 121;
            this.btn_indshs.Text = "In DS HS";
            this.btn_indshs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indshs.UseVisualStyleBackColor = false;
            this.btn_indshs.Click += new System.EventHandler(this.btn_indshs_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::GUI.Properties.Resources.delete1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(348, 127);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 47);
            this.btnxoa.TabIndex = 114;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btnsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsua.Image = global::GUI.Properties.Resources.edit2;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsua.Location = new System.Drawing.Point(192, 127);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 47);
            this.btnsua.TabIndex = 112;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
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
            this.btn_Xem.Location = new System.Drawing.Point(18, 41);
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
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::GUI.Properties.Resources.add2;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(30, 127);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 47);
            this.btnthem.TabIndex = 111;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.Image = global::GUI.Properties.Resources.retype3;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(149, 41);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 47);
            this.button4.TabIndex = 109;
            this.button4.Text = "Nhập lại";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(25, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 18);
            this.label1.TabIndex = 127;
            this.label1.Text = "Danh sách học sinh ";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search3;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(882, 50);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(131, 41);
            this.btn_TimKiem.TabIndex = 103;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // printDocument1
            //
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(500, 400);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_UC1_QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1144, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_HocSinh);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC1_QuanLyHocSinh";
            this.Text = "Form_UC1_QuanLyHocSinh";
            this.Load += new System.EventHandler(this.Form_QuanLyHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocSinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgv_HocSinh;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Nu;
        private System.Windows.Forms.RadioButton rb_Nam;
        private System.Windows.Forms.ComboBox cbo_TenLop;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label_MaLop;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label label_DiaChi;
        private System.Windows.Forms.Label label_GioiTinh;
        private System.Windows.Forms.TextBox txt_NgaySinh;
        private System.Windows.Forms.TextBox txt_TenHocSinh;
        private System.Windows.Forms.TextBox txt_MaHocSinh;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.Button btn_indshs;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}