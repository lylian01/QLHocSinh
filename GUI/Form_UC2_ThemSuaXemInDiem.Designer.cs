namespace GUI
{
    partial class Form_UC2_ThemSuaXemInDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UC2_ThemSuaXemInDiem));
            this.lblMaHS = new System.Windows.Forms.Label();
            this.dtg_BangDiem = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemTBMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_diem1tiet = new System.Windows.Forms.TextBox();
            this.lblDiem1t = new System.Windows.Forms.Label();
            this.txt_diem15p = new System.Windows.Forms.TextBox();
            this.lblDiem15p = new System.Windows.Forms.Label();
            this.lblMaMon = new System.Windows.Forms.Label();
            this.cbb_hocky = new System.Windows.Forms.ComboBox();
            this.lblTimHK = new System.Windows.Forms.Label();
            this.cbb_lop = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.grbHienThi = new System.Windows.Forms.GroupBox();
            this.btn_hienthi = new System.Windows.Forms.Button();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.cbb_mahs = new System.Windows.Forms.ComboBox();
            this.cbb_mon = new System.Windows.Forms.ComboBox();
            this.btnDTB = new System.Windows.Forms.Button();
            this.txt_DM = new System.Windows.Forms.TextBox();
            this.lblDM = new System.Windows.Forms.Label();
            this.lblDTBM = new System.Windows.Forms.Label();
            this.txt_diemTBM = new System.Windows.Forms.TextBox();
            this.grbTV = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_indiem = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_nhaplai = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BangDiem)).BeginInit();
            this.grbHienThi.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            this.grbTV.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaHS.Location = new System.Drawing.Point(20, 39);
            this.lblMaHS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(88, 17);
            this.lblMaHS.TabIndex = 68;
            this.lblMaHS.Text = "Mã Học Sinh";
            // 
            // dtg_BangDiem
            // 
            this.dtg_BangDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dtg_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_BangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.HoTenHS,
            this.TenMH,
            this.Diem15p,
            this.Diem1tiet,
            this.DiemTBMon,
            this.DatMon});
            this.dtg_BangDiem.Location = new System.Drawing.Point(37, 316);
            this.dtg_BangDiem.Margin = new System.Windows.Forms.Padding(4);
            this.dtg_BangDiem.Name = "dtg_BangDiem";
            this.dtg_BangDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_BangDiem.Size = new System.Drawing.Size(987, 311);
            this.dtg_BangDiem.TabIndex = 65;
            this.dtg_BangDiem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_BangDiem_RowEnter);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã Học Sinh ";
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 96;
            // 
            // HoTenHS
            // 
            this.HoTenHS.DataPropertyName = "HoTenHS";
            this.HoTenHS.HeaderText = "Họ Tên HS";
            this.HoTenHS.Name = "HoTenHS";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên Môn";
            this.TenMH.Name = "TenMH";
            // 
            // Diem15p
            // 
            this.Diem15p.DataPropertyName = "Diem15p";
            this.Diem15p.HeaderText = "Điểm 15 phút";
            this.Diem15p.Name = "Diem15p";
            // 
            // Diem1tiet
            // 
            this.Diem1tiet.DataPropertyName = "Diem1tiet";
            this.Diem1tiet.HeaderText = "Điểm 1 tiết";
            this.Diem1tiet.Name = "Diem1tiet";
            // 
            // DiemTBMon
            // 
            this.DiemTBMon.DataPropertyName = "DiemTBMon";
            this.DiemTBMon.HeaderText = "Điểm TB Môn";
            this.DiemTBMon.Name = "DiemTBMon";
            // 
            // DatMon
            // 
            this.DatMon.DataPropertyName = "DatMon";
            this.DatMon.HeaderText = "Đạt Môn";
            this.DatMon.Name = "DatMon";
            // 
            // txt_diem1tiet
            // 
            this.txt_diem1tiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diem1tiet.Location = new System.Drawing.Point(135, 119);
            this.txt_diem1tiet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diem1tiet.Name = "txt_diem1tiet";
            this.txt_diem1tiet.Size = new System.Drawing.Size(160, 22);
            this.txt_diem1tiet.TabIndex = 64;
            // 
            // lblDiem1t
            // 
            this.lblDiem1t.AutoSize = true;
            this.lblDiem1t.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiem1t.Location = new System.Drawing.Point(20, 122);
            this.lblDiem1t.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiem1t.Name = "lblDiem1t";
            this.lblDiem1t.Size = new System.Drawing.Size(79, 17);
            this.lblDiem1t.TabIndex = 63;
            this.lblDiem1t.Text = "Điểm 1 tiết ";
            // 
            // txt_diem15p
            // 
            this.txt_diem15p.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diem15p.Location = new System.Drawing.Point(135, 80);
            this.txt_diem15p.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diem15p.Name = "txt_diem15p";
            this.txt_diem15p.Size = new System.Drawing.Size(160, 22);
            this.txt_diem15p.TabIndex = 62;
            // 
            // lblDiem15p
            // 
            this.lblDiem15p.AutoSize = true;
            this.lblDiem15p.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDiem15p.Location = new System.Drawing.Point(20, 83);
            this.lblDiem15p.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiem15p.Name = "lblDiem15p";
            this.lblDiem15p.Size = new System.Drawing.Size(96, 17);
            this.lblDiem15p.TabIndex = 61;
            this.lblDiem15p.Text = "Điểm 15 phút ";
            // 
            // lblMaMon
            // 
            this.lblMaMon.AutoSize = true;
            this.lblMaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblMaMon.Location = new System.Drawing.Point(318, 39);
            this.lblMaMon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaMon.Name = "lblMaMon";
            this.lblMaMon.Size = new System.Drawing.Size(66, 17);
            this.lblMaMon.TabIndex = 59;
            this.lblMaMon.Text = "Môn học ";
            // 
            // cbb_hocky
            // 
            this.cbb_hocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_hocky.FormattingEnabled = true;
            this.cbb_hocky.Location = new System.Drawing.Point(321, 24);
            this.cbb_hocky.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_hocky.Name = "cbb_hocky";
            this.cbb_hocky.Size = new System.Drawing.Size(150, 24);
            this.cbb_hocky.TabIndex = 58;
            // 
            // lblTimHK
            // 
            this.lblTimHK.AutoSize = true;
            this.lblTimHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimHK.Location = new System.Drawing.Point(260, 26);
            this.lblTimHK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimHK.Name = "lblTimHK";
            this.lblTimHK.Size = new System.Drawing.Size(53, 17);
            this.lblTimHK.TabIndex = 57;
            this.lblTimHK.Text = "Học Kỳ";
            // 
            // cbb_lop
            // 
            this.cbb_lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_lop.FormattingEnabled = true;
            this.cbb_lop.Location = new System.Drawing.Point(99, 24);
            this.cbb_lop.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_lop.Name = "cbb_lop";
            this.cbb_lop.Size = new System.Drawing.Size(129, 24);
            this.cbb_lop.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "Tên Lớp";
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
            // grbHienThi
            // 
            this.grbHienThi.Controls.Add(this.btn_hienthi);
            this.grbHienThi.Controls.Add(this.label1);
            this.grbHienThi.Controls.Add(this.cbb_hocky);
            this.grbHienThi.Controls.Add(this.cbb_lop);
            this.grbHienThi.Controls.Add(this.lblTimHK);
            this.grbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbHienThi.Location = new System.Drawing.Point(25, 32);
            this.grbHienThi.Name = "grbHienThi";
            this.grbHienThi.Size = new System.Drawing.Size(650, 73);
            this.grbHienThi.TabIndex = 81;
            this.grbHienThi.TabStop = false;
            this.grbHienThi.Text = "Tìm theo môn ";
            // 
            // btn_hienthi
            // 
            this.btn_hienthi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_hienthi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_hienthi.Image = global::GUI.Properties.Resources.search3;
            this.btn_hienthi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_hienthi.Location = new System.Drawing.Point(510, 18);
            this.btn_hienthi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hienthi.Name = "btn_hienthi";
            this.btn_hienthi.Size = new System.Drawing.Size(131, 41);
            this.btn_hienthi.TabIndex = 103;
            this.btn_hienthi.Text = "Hiển thị";
            this.btn_hienthi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_hienthi.UseVisualStyleBackColor = false;
            this.btn_hienthi.Click += new System.EventHandler(this.btn_HienThi_Click);
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.cbb_mahs);
            this.grbThongTin.Controls.Add(this.cbb_mon);
            this.grbThongTin.Controls.Add(this.btnDTB);
            this.grbThongTin.Controls.Add(this.lblMaMon);
            this.grbThongTin.Controls.Add(this.lblMaHS);
            this.grbThongTin.Controls.Add(this.txt_DM);
            this.grbThongTin.Controls.Add(this.lblDM);
            this.grbThongTin.Controls.Add(this.txt_diem1tiet);
            this.grbThongTin.Controls.Add(this.lblDiem1t);
            this.grbThongTin.Controls.Add(this.lblDiem15p);
            this.grbThongTin.Controls.Add(this.lblDTBM);
            this.grbThongTin.Controls.Add(this.txt_diem15p);
            this.grbThongTin.Controls.Add(this.txt_diemTBM);
            this.grbThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbThongTin.Location = new System.Drawing.Point(25, 111);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(726, 162);
            this.grbThongTin.TabIndex = 82;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin học sinh ";
            // 
            // cbb_mahs
            // 
            this.cbb_mahs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_mahs.FormattingEnabled = true;
            this.cbb_mahs.Location = new System.Drawing.Point(135, 36);
            this.cbb_mahs.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_mahs.Name = "cbb_mahs";
            this.cbb_mahs.Size = new System.Drawing.Size(160, 24);
            this.cbb_mahs.TabIndex = 119;
            // 
            // cbb_mon
            // 
            this.cbb_mon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_mon.FormattingEnabled = true;
            this.cbb_mon.Location = new System.Drawing.Point(432, 36);
            this.cbb_mon.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_mon.Name = "cbb_mon";
            this.cbb_mon.Size = new System.Drawing.Size(178, 24);
            this.cbb_mon.TabIndex = 118;
            // 
            // btnDTB
            // 
            this.btnDTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(217)))), ((int)(((byte)(255)))));
            this.btnDTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDTB.Image = global::GUI.Properties.Resources.calculator;
            this.btnDTB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDTB.Location = new System.Drawing.Point(575, 83);
            this.btnDTB.Margin = new System.Windows.Forms.Padding(4);
            this.btnDTB.Name = "btnDTB";
            this.btnDTB.Size = new System.Drawing.Size(105, 47);
            this.btnDTB.TabIndex = 116;
            this.btnDTB.Text = "Tính";
            this.btnDTB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDTB.UseVisualStyleBackColor = false;
            this.btnDTB.Click += new System.EventHandler(this.btnDTB_Click);
            // 
            // txt_DM
            // 
            this.txt_DM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_DM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_DM.Location = new System.Drawing.Point(432, 119);
            this.txt_DM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DM.Name = "txt_DM";
            this.txt_DM.ReadOnly = true;
            this.txt_DM.Size = new System.Drawing.Size(113, 22);
            this.txt_DM.TabIndex = 88;
            // 
            // lblDM
            // 
            this.lblDM.AutoSize = true;
            this.lblDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDM.Location = new System.Drawing.Point(316, 122);
            this.lblDM.Name = "lblDM";
            this.lblDM.Size = new System.Drawing.Size(65, 17);
            this.lblDM.TabIndex = 87;
            this.lblDM.Text = "Đạt môn ";
            // 
            // lblDTBM
            // 
            this.lblDTBM.AutoSize = true;
            this.lblDTBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblDTBM.Location = new System.Drawing.Point(316, 83);
            this.lblDTBM.Name = "lblDTBM";
            this.lblDTBM.Size = new System.Drawing.Size(93, 17);
            this.lblDTBM.TabIndex = 85;
            this.lblDTBM.Text = "Điểm TB môn";
            // 
            // txt_diemTBM
            // 
            this.txt_diemTBM.AcceptsReturn = true;
            this.txt_diemTBM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_diemTBM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diemTBM.Location = new System.Drawing.Point(432, 80);
            this.txt_diemTBM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_diemTBM.Name = "txt_diemTBM";
            this.txt_diemTBM.ReadOnly = true;
            this.txt_diemTBM.Size = new System.Drawing.Size(113, 22);
            this.txt_diemTBM.TabIndex = 86;
            // 
            // grbTV
            // 
            this.grbTV.Controls.Add(this.btnxoa);
            this.grbTV.Controls.Add(this.btn_them);
            this.grbTV.Controls.Add(this.btn_indiem);
            this.grbTV.Controls.Add(this.btn_sua);
            this.grbTV.Controls.Add(this.btn_nhaplai);
            this.grbTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grbTV.Location = new System.Drawing.Point(767, 32);
            this.grbTV.Name = "grbTV";
            this.grbTV.Size = new System.Drawing.Size(361, 241);
            this.grbTV.TabIndex = 83;
            this.grbTV.TabStop = false;
            this.grbTV.Text = "Tác vụ ";
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::GUI.Properties.Resources.delete1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(248, 101);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 47);
            this.btnxoa.TabIndex = 115;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(255)))), ((int)(((byte)(149)))));
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Image = global::GUI.Properties.Resources.add2;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(16, 101);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(105, 47);
            this.btn_them.TabIndex = 111;
            this.btn_them.Text = "Thêm";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_indiem
            // 
            this.btn_indiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(126)))));
            this.btn_indiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_indiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indiem.Image = global::GUI.Properties.Resources.print;
            this.btn_indiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indiem.Location = new System.Drawing.Point(166, 171);
            this.btn_indiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indiem.Name = "btn_indiem";
            this.btn_indiem.Size = new System.Drawing.Size(182, 47);
            this.btn_indiem.TabIndex = 77;
            this.btn_indiem.Text = "In Bảng Điểm";
            this.btn_indiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indiem.UseVisualStyleBackColor = false;
            this.btn_indiem.Click += new System.EventHandler(this.btn_indiem_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(223)))), ((int)(((byte)(255)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_sua.Image = global::GUI.Properties.Resources.edit2;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sua.Location = new System.Drawing.Point(129, 101);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 47);
            this.btn_sua.TabIndex = 112;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_nhaplai
            // 
            this.btn_nhaplai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btn_nhaplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_nhaplai.Image = global::GUI.Properties.Resources.retype3;
            this.btn_nhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhaplai.Location = new System.Drawing.Point(16, 35);
            this.btn_nhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nhaplai.Name = "btn_nhaplai";
            this.btn_nhaplai.Size = new System.Drawing.Size(136, 41);
            this.btn_nhaplai.TabIndex = 109;
            this.btn_nhaplai.Text = "Nhập lại";
            this.btn_nhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhaplai.UseVisualStyleBackColor = false;
            this.btn_nhaplai.Click += new System.EventHandler(this.btn_nhaplai_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(43, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "Bảng điểm học sinh ";
            // 
            // Form_UC2_ThemSuaXemInDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 646);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.grbTV);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.grbHienThi);
            this.Controls.Add(this.dtg_BangDiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC2_ThemSuaXemInDiem";
            this.Text = "Form_UC2_ThemSuaXemInDiem";
            this.Load += new System.EventHandler(this.Form_UC2_ThemSuaXemInDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_BangDiem)).EndInit();
            this.grbHienThi.ResumeLayout(false);
            this.grbHienThi.PerformLayout();
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.grbTV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.DataGridView dtg_BangDiem;
        private System.Windows.Forms.TextBox txt_diem1tiet;
        private System.Windows.Forms.Label lblDiem1t;
        private System.Windows.Forms.TextBox txt_diem15p;
        private System.Windows.Forms.Label lblDiem15p;
        private System.Windows.Forms.Label lblMaMon;
        private System.Windows.Forms.ComboBox cbb_hocky;
        private System.Windows.Forms.Label lblTimHK;
        private System.Windows.Forms.ComboBox cbb_lop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_nhaplai;
        private System.Windows.Forms.Button btn_indiem;
        private System.Windows.Forms.Button btn_hienthi;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.GroupBox grbHienThi;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.GroupBox grbTV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDTBM;
        private System.Windows.Forms.TextBox txt_diemTBM;
        private System.Windows.Forms.TextBox txt_DM;
        private System.Windows.Forms.Label lblDM;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnDTB;
        private System.Windows.Forms.ComboBox cbb_mahs;
        private System.Windows.Forms.ComboBox cbb_mon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15p;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemTBMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatMon;
    }
}