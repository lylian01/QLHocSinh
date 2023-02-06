using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using DAL;


namespace GUI
{
    public partial class Form_UC3_ThemSuaXemInDiem : Form
    {
        

        public Form_UC3_ThemSuaXemInDiem()
        {
            InitializeComponent();
        }
        DTO_UC3_ThemSuaXemInDiem L = new DTO_UC3_ThemSuaXemInDiem();
        BUS_UC3_ThemSuaXemInDiem themsuaxemindiemh = new BUS_UC3_ThemSuaXemInDiem();

        private void Form_UC2_ThemSuaXemInDiem_Load(object sender, EventArgs e)
        {
            
            cbb_lop.DataSource = themsuaxemindiemh.ShowTenLop();
            cbb_lop.DisplayMember = "TenLop";
            cbb_lop.ValueMember = "MaLop";

            cbb_hocky.DataSource = themsuaxemindiemh.ShowTenHocKy();
            cbb_hocky.DisplayMember = "TenHKy";
            cbb_hocky.ValueMember = "MaHKy";

            cbb_mon.DataSource = themsuaxemindiemh.ShowTenMon();
            cbb_mon.DisplayMember = "TenMH";
            cbb_mon.ValueMember = "MaMH";

            cbb_mahs.DataSource = themsuaxemindiemh.ShowHSLop(cbb_lop.SelectedValue.ToString() );
            cbb_mahs.ValueMember = "MaHS";

            this.grbThongTin.Enabled = false;
            this.grbTV.Enabled = false;
        }

        private void btn_HienThi_Click(object sender, EventArgs e) // nút hiển thị 
        {
            dtg_BangDiem.DataSource = themsuaxemindiemh.ShowDiem(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());

            this.grbHienThi.Enabled = false;

            this.grbThongTin.Enabled = true;
            this.grbTV.Enabled = true;
            
            
        }
        private void dtg_BangDiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (this.grbThongTin.Enabled == true)
            {
                int dong = e.RowIndex;
                cbb_mahs.Text = dtg_BangDiem.Rows[dong].Cells[0].Value.ToString();
                cbb_mon.Text = dtg_BangDiem.Rows[dong].Cells[2].Value.ToString();
                txt_diem15p.Text = dtg_BangDiem.Rows[dong].Cells[3].Value.ToString();
                txt_diem1tiet.Text = dtg_BangDiem.Rows[dong].Cells[4].Value.ToString();
                txt_diemTBM.Text = dtg_BangDiem.Rows[dong].Cells[5].Value.ToString();
                txt_DM.Text = dtg_BangDiem.Rows[dong].Cells[6].Value.ToString();
            }
            else { }

        }


        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            cbb_lop.Text = "";
            cbb_hocky.Text = "";

            cbb_mahs.Text = "";
            cbb_mon.Text = "";
            txt_diem15p.Clear();
            txt_diem1tiet.Clear();
            txt_diemTBM.Clear();
            txt_DM.Clear();

            this.grbHienThi.Enabled = true;  // tìm kiếm 
            this.grbTV.Enabled = false; // nút tác vụ 
            this.grbThongTin.Enabled = false;  // nhập thông tin 

        }
        public float tinhDiem(float d15p, float d1t)
        {
            float dtb = 0;
            double dm15p = d15p * 1;
            double dm1t = d1t * 2;
            dtb = (float)((dm15p + dm1t)/3);
            return  dtb;
        }
        public void btnDTB_Click(object sender, EventArgs e)
        {
            if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 15 phút từ 0 - 10");
            else if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 1 tiết từ 0 - 10");
            else
            {
                float d15p = Utility.ConvertToFloat(txt_diem15p.Text);
                float d1t = Utility.ConvertToFloat(txt_diem1tiet.Text);
                float dtb = tinhDiem(d15p, d1t);
                txt_diemTBM.Text = dtb.ToString(Utility.myCultureInfo);

                MessageBox.Show(txt_diemTBM.Text);

                if(dtb >= 5)
                {
                    txt_DM.Text = "Dat";
                }
                else
                {
                    txt_DM.Text = "KhongDat";
                }

            }
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (cbb_mahs.SelectedValue.ToString() == "")
                MessageBox.Show("Mã Học Sinh không được để trống!");
            else if (cbb_mon.SelectedValue.ToString() == "")
                MessageBox.Show("Môn học không được để trống!");
            else if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 15 phút từ 0 - 10");
            else if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 1 tiết từ 0 - 10");
            else if (txt_diemTBM.TextLength == 0) 
                MessageBox.Show("Vui lòng bấm nút tính điểm ");
            else
            {
                try
                {
                    L.Mahocsinh_ = cbb_mahs.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_mon.SelectedValue.ToString();
                    L.Tenhocky_ = cbb_hocky.SelectedValue.ToString();
                    MessageBox.Show("ok ");
                    L.Diem15phut_ = float.Parse(txt_diem15p.Text);
                    L.Diem1tiet_ = float.Parse(txt_diem1tiet.Text);
                    L.DiemTBMon_ = Utility.ConvertToFloat(txt_diemTBM.Text);
                    L.Datmon_ = txt_DM.Text;
                    

                    MessageBox.Show(L.DiemTBMon_.ToString());

                    themsuaxemindiemh.InsertDiem(L.Mahocsinh_, L.Tenmonhoc_, L.Tenhocky_, L.Diem15phut_, L.Diem1tiet_, L.DiemTBMon_, L.Datmon_);

                    MessageBox.Show("Thêm thành công!");
                    dtg_BangDiem.DataSource = themsuaxemindiemh.ShowDiem(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }
        
        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (cbb_mahs.SelectedValue.ToString() == null)
                MessageBox.Show("Mã Học Sinh không được để trống!");
            else if (cbb_mon.SelectedValue.ToString() == null)
                MessageBox.Show("Môn học không được để trống!");
            else if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 15 phút từ 0 - 10");
            else if (0 > L.Diem15phut_ || L.Diem15phut_ > 10)
                MessageBox.Show("Vui lòng nhập điểm 1 tiết từ 0 - 10");
            else if (txt_diemTBM.TextLength == 0)
                MessageBox.Show("Vui lòng bấm nút tính điểm ");
            else
            {
                try
                {
                    L.Mahocsinh_ = cbb_mahs.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_mon.SelectedValue.ToString();
                    L.Tenhocky_ = cbb_hocky.SelectedValue.ToString();

                    L.Diem15phut_ = float.Parse(txt_diem15p.Text);
                    L.Diem1tiet_ = float.Parse(txt_diem1tiet.Text);
                    L.DiemTBMon_ = float.Parse(txt_diemTBM.Text);
                    L.Datmon_ = txt_DM.Text;

                   
                    themsuaxemindiemh.UpdateDiem(L.Mahocsinh_, L.Tenmonhoc_, L.Tenhocky_, L.Diem15phut_, L.Diem1tiet_, L.DiemTBMon_, L.Datmon_);

                    MessageBox.Show("Sửa thành công!");
                    dtg_BangDiem.DataSource = themsuaxemindiemh.ShowDiem(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
            
        }
        private void btnxoa_Click(object sender, EventArgs e)
        {
             if (cbb_mahs.SelectedValue.ToString() == null)
                MessageBox.Show("Mã Học Sinh không được để trống!");
            else if (cbb_mon.SelectedValue.ToString() == null)
                MessageBox.Show("Môn học không được để trống!");
            else
            {
                try
                {
                    L.Mahocsinh_ = cbb_mahs.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_mon.SelectedValue.ToString();
                    L.Tenhocky_ = cbb_hocky.SelectedValue.ToString();
                   
                    themsuaxemindiemh.DeleteDiem(L.Mahocsinh_, L.Tenmonhoc_, L.Tenhocky_);

                    MessageBox.Show("Xóa thành công!");
                    dtg_BangDiem.DataSource = themsuaxemindiemh.ShowDiem(cbb_lop.SelectedValue.ToString(), cbb_hocky.SelectedValue.ToString());
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btn_indiem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH ĐIỂM HỌC SINH", new Font("Times New Roman", 24, FontStyle.Regular), Brushes.Black, new PointF(210, 80));
            e.Graphics.DrawString("Tên Lớp:", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(200, 140));
            e.Graphics.DrawString(cbb_lop.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(400, 140));
            e.Graphics.DrawString("Học Kỳ :", new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(200, 170));
            e.Graphics.DrawString(cbb_hocky.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new PointF(400, 170));

            Bitmap bm = new Bitmap(this.dtg_BangDiem.Width, this.dtg_BangDiem.Height);
            dtg_BangDiem.DrawToBitmap(bm, new Rectangle(0, 0, this.dtg_BangDiem.Width, this.dtg_BangDiem.Height));
            e.Graphics.DrawImage(bm, 60, 300);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 600));
            e.Graphics.DrawString("Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 640));
            e.Graphics.DrawString("Nguyễn Ngọc Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 680));
        }

        
    }
}
