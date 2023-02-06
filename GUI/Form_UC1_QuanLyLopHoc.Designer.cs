namespace GUI
{
    partial class Form_UC1_QuanLyLopHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_UC1_QuanLyLopHoc));
            this.dgv_LopHoc = new System.Windows.Forms.DataGridView();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNienKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_khoi = new System.Windows.Forms.ComboBox();
            this.lblTK = new System.Windows.Forms.Label();
            this.cbb_nienkhoa = new System.Windows.Forms.ComboBox();
            this.cbb_gvcn = new System.Windows.Forms.ComboBox();
            this.txt_SiSo = new System.Windows.Forms.TextBox();
            this.lblGV = new System.Windows.Forms.Label();
            this.lblSiSo = new System.Windows.Forms.Label();
            this.txt_TenLop = new System.Windows.Forms.TextBox();
            this.txt_MaLop = new System.Windows.Forms.TextBox();
            this.lblNK = new System.Windows.Forms.Label();
            this.lblTL = new System.Windows.Forms.Label();
            this.lblML = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_indsgv1lop = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_LopHoc
            // 
            this.dgv_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Malop,
            this.TenLop,
            this.TenKhoi,
            this.TenNienKhoa,
            this.SiSo,
            this.HoTenGV});
            this.dgv_LopHoc.Location = new System.Drawing.Point(26, 399);
            this.dgv_LopHoc.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_LopHoc.Name = "dgv_LopHoc";
            this.dgv_LopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LopHoc.Size = new System.Drawing.Size(1008, 234);
            this.dgv_LopHoc.TabIndex = 75;
            this.dgv_LopHoc.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopHoc_RowEnter);
            // 
            // Malop
            // 
            this.Malop.DataPropertyName = "MaLop";
            this.Malop.HeaderText = "Mã lớp";
            this.Malop.Name = "Malop";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.Width = 104;
            // 
            // TenKhoi
            // 
            this.TenKhoi.DataPropertyName = "TenKhoi";
            this.TenKhoi.HeaderText = "Khối";
            this.TenKhoi.Name = "TenKhoi";
            this.TenKhoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TenNienKhoa
            // 
            this.TenNienKhoa.DataPropertyName = "TenNienKhoa";
            this.TenNienKhoa.HeaderText = "Niên khóa";
            this.TenNienKhoa.Name = "TenNienKhoa";
            this.TenNienKhoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenNienKhoa.Width = 120;
            // 
            // SiSo
            // 
            this.SiSo.DataPropertyName = "SiSo";
            this.SiSo.HeaderText = "Sĩ số";
            this.SiSo.Name = "SiSo";
            // 
            // HoTenGV
            // 
            this.HoTenGV.DataPropertyName = "HoTenGV";
            this.HoTenGV.HeaderText = "Giáo viên chủ nhiệm";
            this.HoTenGV.Name = "HoTenGV";
            this.HoTenGV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.HoTenGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.HoTenGV.Width = 171;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(644, 60);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(173, 22);
            this.txt_TimKiem.TabIndex = 115;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_khoi);
            this.groupBox1.Controls.Add(this.lblTK);
            this.groupBox1.Controls.Add(this.cbb_nienkhoa);
            this.groupBox1.Controls.Add(this.cbb_gvcn);
            this.groupBox1.Controls.Add(this.txt_SiSo);
            this.groupBox1.Controls.Add(this.lblGV);
            this.groupBox1.Controls.Add(this.lblSiSo);
            this.groupBox1.Controls.Add(this.txt_TenLop);
            this.groupBox1.Controls.Add(this.txt_MaLop);
            this.groupBox1.Controls.Add(this.lblNK);
            this.groupBox1.Controls.Add(this.lblTL);
            this.groupBox1.Controls.Add(this.lblML);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(26, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 317);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin lớp ";
            // 
            // cbo_khoi
            // 
            this.cbo_khoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbo_khoi.FormattingEnabled = true;
            this.cbo_khoi.Location = new System.Drawing.Point(194, 123);
            this.cbo_khoi.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_khoi.Name = "cbo_khoi";
            this.cbo_khoi.Size = new System.Drawing.Size(323, 24);
            this.cbo_khoi.TabIndex = 98;
            // 
            // lblTK
            // 
            this.lblTK.AutoSize = true;
            this.lblTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTK.Location = new System.Drawing.Point(48, 126);
            this.lblTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTK.Name = "lblTK";
            this.lblTK.Size = new System.Drawing.Size(40, 17);
            this.lblTK.TabIndex = 97;
            this.lblTK.Text = "Khối ";
            // 
            // cbb_nienkhoa
            // 
            this.cbb_nienkhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_nienkhoa.FormattingEnabled = true;
            this.cbb_nienkhoa.Location = new System.Drawing.Point(194, 162);
            this.cbb_nienkhoa.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_nienkhoa.Name = "cbb_nienkhoa";
            this.cbb_nienkhoa.Size = new System.Drawing.Size(323, 24);
            this.cbb_nienkhoa.TabIndex = 96;
            // 
            // cbb_gvcn
            // 
            this.cbb_gvcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbb_gvcn.FormattingEnabled = true;
            this.cbb_gvcn.Location = new System.Drawing.Point(194, 251);
            this.cbb_gvcn.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_gvcn.Name = "cbb_gvcn";
            this.cbb_gvcn.Size = new System.Drawing.Size(323, 24);
            this.cbb_gvcn.TabIndex = 95;
            // 
            // txt_SiSo
            // 
            this.txt_SiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_SiSo.Location = new System.Drawing.Point(194, 207);
            this.txt_SiSo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SiSo.Name = "txt_SiSo";
            this.txt_SiSo.Size = new System.Drawing.Size(323, 22);
            this.txt_SiSo.TabIndex = 94;
            // 
            // lblGV
            // 
            this.lblGV.AutoSize = true;
            this.lblGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGV.Location = new System.Drawing.Point(48, 254);
            this.lblGV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGV.Name = "lblGV";
            this.lblGV.Size = new System.Drawing.Size(137, 17);
            this.lblGV.TabIndex = 93;
            this.lblGV.Text = "Giáo viên chủ nhiệm";
            // 
            // lblSiSo
            // 
            this.lblSiSo.AutoSize = true;
            this.lblSiSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSiSo.Location = new System.Drawing.Point(48, 210);
            this.lblSiSo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSiSo.Name = "lblSiSo";
            this.lblSiSo.Size = new System.Drawing.Size(39, 17);
            this.lblSiSo.TabIndex = 92;
            this.lblSiSo.Text = "Sĩ số";
            // 
            // txt_TenLop
            // 
            this.txt_TenLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_TenLop.Location = new System.Drawing.Point(194, 79);
            this.txt_TenLop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenLop.Name = "txt_TenLop";
            this.txt_TenLop.Size = new System.Drawing.Size(323, 22);
            this.txt_TenLop.TabIndex = 90;
            // 
            // txt_MaLop
            // 
            this.txt_MaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_MaLop.Location = new System.Drawing.Point(194, 35);
            this.txt_MaLop.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaLop.Name = "txt_MaLop";
            this.txt_MaLop.Size = new System.Drawing.Size(323, 22);
            this.txt_MaLop.TabIndex = 89;
            // 
            // lblNK
            // 
            this.lblNK.AutoSize = true;
            this.lblNK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNK.Location = new System.Drawing.Point(48, 165);
            this.lblNK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNK.Name = "lblNK";
            this.lblNK.Size = new System.Drawing.Size(72, 17);
            this.lblNK.TabIndex = 88;
            this.lblNK.Text = "Niên khóa";
            // 
            // lblTL
            // 
            this.lblTL.AutoSize = true;
            this.lblTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTL.Location = new System.Drawing.Point(48, 82);
            this.lblTL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTL.Name = "lblTL";
            this.lblTL.Size = new System.Drawing.Size(56, 17);
            this.lblTL.TabIndex = 87;
            this.lblTL.Text = "Tên lớp";
            // 
            // lblML
            // 
            this.lblML.AutoSize = true;
            this.lblML.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblML.Location = new System.Drawing.Point(48, 40);
            this.lblML.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblML.Name = "lblML";
            this.lblML.Size = new System.Drawing.Size(50, 17);
            this.lblML.TabIndex = 86;
            this.lblML.Text = "Mã lớp";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_indsgv1lop);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnsua);
            this.groupBox2.Controls.Add(this.btn_Xem);
            this.groupBox2.Controls.Add(this.btnthem);
            this.groupBox2.Controls.Add(this.btnnhaplai);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.Location = new System.Drawing.Point(644, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 177);
            this.groupBox2.TabIndex = 117;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_indsgv1lop
            // 
            this.btn_indsgv1lop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(197)))), ((int)(((byte)(126)))));
            this.btn_indsgv1lop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_indsgv1lop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_indsgv1lop.Image = global::GUI.Properties.Resources.print;
            this.btn_indsgv1lop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_indsgv1lop.Location = new System.Drawing.Point(313, 33);
            this.btn_indsgv1lop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_indsgv1lop.Name = "btn_indsgv1lop";
            this.btn_indsgv1lop.Size = new System.Drawing.Size(151, 47);
            this.btn_indsgv1lop.TabIndex = 120;
            this.btn_indsgv1lop.Text = "In DS Lớp";
            this.btn_indsgv1lop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_indsgv1lop.UseVisualStyleBackColor = false;
            this.btn_indsgv1lop.Click += new System.EventHandler(this.btn_indsgv1lop_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(92)))), ((int)(((byte)(88)))));
            this.btnxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoa.Image = global::GUI.Properties.Resources.delete1;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(349, 113);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 47);
            this.btnxoa.TabIndex = 119;
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
            this.btnsua.Location = new System.Drawing.Point(194, 113);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 47);
            this.btnsua.TabIndex = 118;
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
            this.btn_Xem.Image = global::GUI.Properties.Resources.see6;
            this.btn_Xem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Xem.Location = new System.Drawing.Point(23, 33);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Xem.Size = new System.Drawing.Size(112, 47);
            this.btn_Xem.TabIndex = 116;
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
            this.btnthem.Location = new System.Drawing.Point(35, 113);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(105, 47);
            this.btnthem.TabIndex = 117;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(178)))));
            this.btnnhaplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnhaplai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnhaplai.Image = global::GUI.Properties.Resources.retype1;
            this.btnnhaplai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnhaplai.Location = new System.Drawing.Point(152, 33);
            this.btnnhaplai.Margin = new System.Windows.Forms.Padding(4);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(142, 47);
            this.btnnhaplai.TabIndex = 115;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnhaplai.UseVisualStyleBackColor = false;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(30, 364);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 118;
            this.label6.Text = "Danh sách lớp ";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(242)))), ((int)(((byte)(202)))));
            this.btn_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_TimKiem.Image = global::GUI.Properties.Resources.search1;
            this.btn_TimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_TimKiem.Location = new System.Drawing.Point(829, 48);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(137, 41);
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
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Form_UC1_QuanLyLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 646);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_LopHoc);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.txt_TimKiem);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_UC1_QuanLyLopHoc";
            this.Text = "Form_UC1_QuanLyLopHoc";
            this.Load += new System.EventHandler(this.Form_QuanLyLopHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_LopHoc;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_gvcn;
        private System.Windows.Forms.TextBox txt_SiSo;
        private System.Windows.Forms.Label lblGV;
        private System.Windows.Forms.Label lblSiSo;
        private System.Windows.Forms.TextBox txt_TenLop;
        private System.Windows.Forms.TextBox txt_MaLop;
        private System.Windows.Forms.Label lblNK;
        private System.Windows.Forms.Label lblTL;
        private System.Windows.Forms.Label lblML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btnnhaplai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_nienkhoa;
        private System.Windows.Forms.ComboBox cbo_khoi;
        private System.Windows.Forms.Label lblTK;
        private System.Windows.Forms.Button btn_indsgv1lop;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNienKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SiSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenGV;
        public System.Windows.Forms.Button btnxoa;
        public System.Windows.Forms.Button btnsua;
        public System.Windows.Forms.Button btnthem;
    }
}