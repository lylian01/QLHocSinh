namespace GUI
{
    partial class Form_UC2_QuanLyCanBoGiaoVien
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
            this.dgv_CBGV = new System.Windows.Forms.DataGridView();
            this.MaCanBoGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiTK = new System.Windows.Forms.ComboBox();
            this.cbo_TrinhDo = new System.Windows.Forms.ComboBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label_SoDienThoai = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.label_LoaiTK = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.txt_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_TrinhDo = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_TenCBGV = new System.Windows.Forms.TextBox();
            this.txt_MaCBGV = new System.Windows.Forms.TextBox();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_HoTen = new System.Windows.Forms.Label();
            this.label_MaCanBoGV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CBGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_CBGV
            // 
            this.dgv_CBGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CBGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCanBoGV,
            this.HoTen,
            this.DiaChi,
            this.SoDienThoai,
            this.TaiKhoan,
            this.MatKhau,
            this.LoaiTaiKhoan,
            this.TenTD});
            this.dgv_CBGV.Location = new System.Drawing.Point(21, 392);
            this.dgv_CBGV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_CBGV.Name = "dgv_CBGV";
            this.dgv_CBGV.AutoGenerateColumns = false;
            this.dgv_CBGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CBGV.Size = new System.Drawing.Size(1089, 241);
            this.dgv_CBGV.TabIndex = 132;
            this.dgv_CBGV.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CBGV_RowEnter);
            // 
            // MaCanBoGV
            // 
            this.MaCanBoGV.DataPropertyName = "MaCanBoGV";
            this.MaCanBoGV.HeaderText = "Mã cán bộ gv";
            this.MaCanBoGV.Name = "MaCanBoGV";
            this.MaCanBoGV.Width = 95;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTenGV";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.Width = 126;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 125;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TaiKhoan.Width = 75;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 75;
            // 
            // LoaiTaiKhoan
            // 
            this.LoaiTaiKhoan.DataPropertyName = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.HeaderText = "Loại tài khoản";
            this.LoaiTaiKhoan.Name = "LoaiTaiKhoan";
            this.LoaiTaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiTaiKhoan.Width = 75;
            // 
            // TenTD
            // 
            this.TenTD.DataPropertyName = "TenTD";
            this.TenTD.HeaderText = "Trình độ";
            this.TenTD.Name = "TenTD";
            this.TenTD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenTD.Width = 85;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(671, 60);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(200, 22);
            this.txt_TimKiem.TabIndex = 129;
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btnnhaplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhaplai.Image = global::GUI.Properties.Resources.retype3;
            this.btnnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaplai.Location = new System.Drawing.Point(262, 43);
            this.btnnhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(132, 47);
            this.btnnhaplai.TabIndex = 109;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaplai.UseVisualStyleBackColor = false;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search1;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(904, 50);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(132, 41);
            this.btn_TimKiem.TabIndex = 103;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_LoaiTK);
            this.groupBox1.Controls.Add(this.cbo_TrinhDo);
            this.groupBox1.Controls.Add(this.txt_SoDienThoai);
            this.groupBox1.Controls.Add(this.label_SoDienThoai);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.label_LoaiTK);
            this.groupBox1.Controls.Add(this.label_MatKhau);
            this.groupBox1.Controls.Add(this.txt_TaiKhoan);
            this.groupBox1.Controls.Add(this.label_TaiKhoan);
            this.groupBox1.Controls.Add(this.label_TrinhDo);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_TenCBGV);
            this.groupBox1.Controls.Add(this.txt_MaCBGV);
            this.groupBox1.Controls.Add(this.label_NgaySinh);
            this.groupBox1.Controls.Add(this.label_HoTen);
            this.groupBox1.Controls.Add(this.label_MaCanBoGV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(21, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 317);
            this.groupBox1.TabIndex = 149;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên ";
            // 
            // cbo_LoaiTK
            // 
            this.cbo_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_LoaiTK.FormattingEnabled = true;
            this.cbo_LoaiTK.Location = new System.Drawing.Point(194, 267);
            this.cbo_LoaiTK.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_LoaiTK.Name = "cbo_LoaiTK";
            this.cbo_LoaiTK.Size = new System.Drawing.Size(101, 24);
            this.cbo_LoaiTK.TabIndex = 164;
            // 
            // cbo_TrinhDo
            // 
            this.cbo_TrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_TrinhDo.FormattingEnabled = true;
            this.cbo_TrinhDo.Location = new System.Drawing.Point(372, 266);
            this.cbo_TrinhDo.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_TrinhDo.Name = "cbo_TrinhDo";
            this.cbo_TrinhDo.Size = new System.Drawing.Size(141, 24);
            this.cbo_TrinhDo.TabIndex = 163;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SoDienThoai.Location = new System.Drawing.Point(194, 148);
            this.txt_SoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(319, 22);
            this.txt_SoDienThoai.TabIndex = 162;
            // 
            // label_SoDienThoai
            // 
            this.label_SoDienThoai.AutoSize = true;
            this.label_SoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_SoDienThoai.Location = new System.Drawing.Point(48, 156);
            this.label_SoDienThoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoDienThoai.Name = "label_SoDienThoai";
            this.label_SoDienThoai.Size = new System.Drawing.Size(91, 17);
            this.label_SoDienThoai.TabIndex = 161;
            this.label_SoDienThoai.Text = "Số điện thoại";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MatKhau.Location = new System.Drawing.Point(194, 222);
            this.txt_MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(319, 22);
            this.txt_MatKhau.TabIndex = 160;
            // 
            // label_LoaiTK
            // 
            this.label_LoaiTK.AutoSize = true;
            this.label_LoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_LoaiTK.Location = new System.Drawing.Point(48, 272);
            this.label_LoaiTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LoaiTK.Name = "label_LoaiTK";
            this.label_LoaiTK.Size = new System.Drawing.Size(97, 17);
            this.label_LoaiTK.TabIndex = 159;
            this.label_LoaiTK.Text = "Loại tài khoản";
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MatKhau.Location = new System.Drawing.Point(48, 230);
            this.label_MatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(66, 17);
            this.label_MatKhau.TabIndex = 158;
            this.label_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TaiKhoan
            // 
            this.txt_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TaiKhoan.Location = new System.Drawing.Point(194, 185);
            this.txt_TaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TaiKhoan.Name = "txt_TaiKhoan";
            this.txt_TaiKhoan.Size = new System.Drawing.Size(319, 22);
            this.txt_TaiKhoan.TabIndex = 157;
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TaiKhoan.Location = new System.Drawing.Point(48, 193);
            this.label_TaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(71, 17);
            this.label_TaiKhoan.TabIndex = 156;
            this.label_TaiKhoan.Text = "Tài khoản";
            // 
            // label_TrinhDo
            // 
            this.label_TrinhDo.AutoSize = true;
            this.label_TrinhDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_TrinhDo.Location = new System.Drawing.Point(303, 272);
            this.label_TrinhDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TrinhDo.Name = "label_TrinhDo";
            this.label_TrinhDo.Size = new System.Drawing.Size(61, 17);
            this.label_TrinhDo.TabIndex = 155;
            this.label_TrinhDo.Text = "Trình độ";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DiaChi.Location = new System.Drawing.Point(194, 110);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(319, 22);
            this.txt_DiaChi.TabIndex = 154;
            // 
            // txt_TenCBGV
            // 
            this.txt_TenCBGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenCBGV.Location = new System.Drawing.Point(194, 68);
            this.txt_TenCBGV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenCBGV.Name = "txt_TenCBGV";
            this.txt_TenCBGV.Size = new System.Drawing.Size(319, 22);
            this.txt_TenCBGV.TabIndex = 153;
            // 
            // txt_MaCBGV
            // 
            this.txt_MaCBGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaCBGV.Location = new System.Drawing.Point(194, 31);
            this.txt_MaCBGV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaCBGV.Name = "txt_MaCBGV";
            this.txt_MaCBGV.Size = new System.Drawing.Size(319, 22);
            this.txt_MaCBGV.TabIndex = 152;
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_NgaySinh.Location = new System.Drawing.Point(48, 118);
            this.label_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(51, 17);
            this.label_NgaySinh.TabIndex = 151;
            this.label_NgaySinh.Text = "Địa chỉ";
            // 
            // label_HoTen
            // 
            this.label_HoTen.AutoSize = true;
            this.label_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_HoTen.Location = new System.Drawing.Point(48, 76);
            this.label_HoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HoTen.Name = "label_HoTen";
            this.label_HoTen.Size = new System.Drawing.Size(50, 17);
            this.label_HoTen.TabIndex = 150;
            this.label_HoTen.Text = "Họ tên";
            // 
            // label_MaCanBoGV
            // 
            this.label_MaCanBoGV.AutoSize = true;
            this.label_MaCanBoGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_MaCanBoGV.Location = new System.Drawing.Point(48, 39);
            this.label_MaCanBoGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_MaCanBoGV.Name = "label_MaCanBoGV";
            this.label_MaCanBoGV.Size = new System.Drawing.Size(135, 17);
            this.label_MaCanBoGV.TabIndex = 149;
            this.label_MaCanBoGV.Text = "Mã cán bộ giáo viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btnnhaplai);
            this.groupBox2.Controls.Add(this.btn_Xem);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(642, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 208);
            this.groupBox2.TabIndex = 150;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::GUI.Properties.Resources.delete1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(344, 126);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 47);
            this.btnxoa.TabIndex = 118;
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
            this.btnsua.Location = new System.Drawing.Point(192, 126);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 47);
            this.btnsua.TabIndex = 117;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(231)))), ((int)(((byte)(164)))));
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Xem.ForeColor = System.Drawing.Color.Black;
            this.btn_Xem.Image = global::GUI.Properties.Resources.see2;
            this.btn_Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xem.Location = new System.Drawing.Point(96, 43);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xem.Size = new System.Drawing.Size(100, 47);
            this.btn_Xem.TabIndex = 115;
            this.btn_Xem.Text = "Xem";
            this.btn_Xem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.UseWaitCursor = true;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btnthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthem.Image = global::GUI.Properties.Resources.add2;
            this.btnthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthem.Location = new System.Drawing.Point(29, 127);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 47);
            this.btnthem.TabIndex = 116;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(27, 365);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 151;
            this.label1.Text = "Danh sách giáo viên ";
            // 
            // Form_UC1_QuanLyCanBoGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_CBGV);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC1_QuanLyCanBoGiaoVien";
            this.Text = "Form_UC1_QuanLyCanBoGiaoVien";
            this.Load += new System.EventHandler(this.Form_QuanLyCanBoGiaoVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CBGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_CBGV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbo_LoaiTK;
        private System.Windows.Forms.ComboBox cbo_TrinhDo;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.Label label_SoDienThoai;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label label_LoaiTK;
        private System.Windows.Forms.Label label_MatKhau;
        private System.Windows.Forms.TextBox txt_TaiKhoan;
        private System.Windows.Forms.Label label_TaiKhoan;
        private System.Windows.Forms.Label label_TrinhDo;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_TenCBGV;
        private System.Windows.Forms.TextBox txt_MaCBGV;
        private System.Windows.Forms.Label label_NgaySinh;
        private System.Windows.Forms.Label label_HoTen;
        private System.Windows.Forms.Label label_MaCanBoGV;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnthem;
        public System.Windows.Forms.Button btnnhaplai;
        public System.Windows.Forms.Button btnxoa;
        public System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCanBoGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTD;
    }
}