using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using DAL;

namespace GUI
{
    public partial class Form_UC3_PhanCongGiangDay : Form
    {
        public Form_UC3_PhanCongGiangDay()
        {
            InitializeComponent();
        }
        DTO_UC3_PhanCongGiangDay L = new DTO_UC3_PhanCongGiangDay();
        BUS_UC3_PhanCongGiangDay phanconggiangdayh = new BUS_UC3_PhanCongGiangDay();
        
        

        private void Form_UC3_PhanCongGiangDay_Load(object sender, EventArgs e)
        {

            cbb_tenlophoc.DataSource = phanconggiangdayh.ShowTenLopHoc();
            cbb_tenlophoc.DisplayMember = "TenLop";
            cbb_tenlophoc.ValueMember = "MaLop";

            cbb_tenmonhoc.DataSource = phanconggiangdayh.ShowTenMonHoc();
            cbb_tenmonhoc.DisplayMember = "TenMH";
            cbb_tenmonhoc.ValueMember = "MaMH";

            cbb_tengiaovien.DataSource = phanconggiangdayh.ShowTenCBGV();
            cbb_tengiaovien.DisplayMember = "HoTenGV";
            cbb_tengiaovien.ValueMember = "MaCanBoGV";

            this.groupBoxPCGD.Enabled = false;
            this.groupboxXemPCGD.Enabled = false;
            this.dtg_phancong.Enabled = false;

            cbb_tenlophoc2.DataSource = phanconggiangdayh.ShowTenLopHoc();
            cbb_tenlophoc2.DisplayMember = "TenLop";
            cbb_tenlophoc2.ValueMember = "MaLop";

            cbb_tenmonhoc2.DataSource = phanconggiangdayh.ShowTenMonHoc();
            cbb_tenmonhoc2.DisplayMember = "TenMH";
            cbb_tenmonhoc2.ValueMember = "MaMH";

            cbb_tengiaovien2.DataSource = phanconggiangdayh.ShowTenCBGV();
            cbb_tengiaovien2.DisplayMember = "HoTenGV";
            cbb_tengiaovien2.ValueMember = "MaCanBoGV";

            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;

            this.rb_PhanCongGiangDay.Checked = false;
            this.rb_XemInPhanCongGiangDay.Checked = false;
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void dtg_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            if (rb_PhanCongGiangDay.Checked == true)
            {
                cbb_tenlophoc.Text = dtg_phancong.Rows[dong].Cells[0].Value.ToString();
                cbb_tenmonhoc.Text = dtg_phancong.Rows[dong].Cells[1].Value.ToString();
                cbb_tengiaovien.Text = dtg_phancong.Rows[dong].Cells[2].Value.ToString();
                txt_ngayphancong.Text = dtg_phancong.Rows[dong].Cells[3].Value.ToString();
            }
            //else if (rb_XemInPhanCongGiangDay.Checked == true)
            //{
            //    cbb_tenlophoc2.Text = dtg_phancong.Rows[dong].Cells[0].Value.ToString();
            //    cbb_tenmonhoc2.Text = dtg_phancong.Rows[dong].Cells[1].Value.ToString();
            //    cbb_tengiaovien2.Text = dtg_phancong.Rows[dong].Cells[2].Value.ToString();

            //}
            else { }
        }


            private void btn_reset_Click(object sender, EventArgs e)
            {
                Form_UC3_PhanCongGiangDay_Load(sender, e);//goi lai form ban dau cho nhanh
            
            }

        private void btn_themphancong_Click(object sender, EventArgs e)
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Tên Lớp Học không được để trống");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Tên Môn Học không được để trống");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Tên Giáo Viên không được để trống");
            else if (txt_ngayphancong.Text == "")
                MessageBox.Show("Ngày phân công không được để trống");
            else
            {
                try
                {
                    L.Tenlophoc_ = cbb_tenlophoc.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_tenmonhoc.SelectedValue.ToString();
                    L.Tencbgv_ = cbb_tengiaovien.SelectedValue.ToString();
                    L.Ngayphancong_ = txt_ngayphancong.Text;


                    phanconggiangdayh.InsertPhanCongGiangDay(L.Tenlophoc_, L.Tenmonhoc_, L.Tencbgv_, L.Ngayphancong_);

                    MessageBox.Show("Thêm thành công!");
                    dtg_phancong.DataSource = phanconggiangdayh.ShowPCGD();
                }
                catch
                {
                    MessageBox.Show("Có lỗiiiiiiiiii!");
                }
            }
        }

        private void btn_suaphancong_Click(object sender, EventArgs e)
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Tên Lớp Học không được để trống");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Tên Môn Học không được để trống");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Tên Giáo Viên không được để trống");
            else if (txt_ngayphancong.Text == "")
                MessageBox.Show("Ngày phân công không được để trống");
            else
            {
                try
                {
                    L.Tenlophoc_ = cbb_tenlophoc.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_tenmonhoc.SelectedValue.ToString();
                    L.Tencbgv_ = cbb_tengiaovien.SelectedValue.ToString();
                    L.Ngayphancong_ = txt_ngayphancong.Text;


                    phanconggiangdayh.UpdatePhanCongGiangDay(L.Tenlophoc_, L.Tenmonhoc_, L.Tencbgv_, L.Ngayphancong_);

                    MessageBox.Show("Sửa Thành Công ! ");
                    dtg_phancong.DataSource = phanconggiangdayh.ShowPCGD();
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void button1_Click(object sender, EventArgs e)//xoa phan cong
        {
            if (cbb_tenlophoc.Text == "")
                MessageBox.Show("Tên Lớp Học không được để trống");
            else if (cbb_tenmonhoc.Text == "")
                MessageBox.Show("Tên Môn Học không được để trống");
            else if (cbb_tengiaovien.Text == "")
                MessageBox.Show("Tên Giáo Viên không được để trống");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Tenlophoc_ = cbb_tenlophoc.SelectedValue.ToString();
                    L.Tenmonhoc_ = cbb_tenmonhoc.SelectedValue.ToString();
                    L.Tencbgv_ = cbb_tengiaovien.SelectedValue.ToString();

                    phanconggiangdayh.DeletePhanCongGiangDay(L.Tenlophoc_, L.Tenmonhoc_, L.Tencbgv_);

                    MessageBox.Show("Đã Xóa Thành Công");
                    dtg_phancong.DataSource = phanconggiangdayh.ShowPCGD();
                }
            }
        }

        private void rb_PhanCongGiangDay_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxPCGD.Enabled = true;
            this.groupboxXemPCGD.Enabled = false;
            this.dtg_phancong.Enabled = true;
            dtg_phancong.DataSource = phanconggiangdayh.ShowPCGD();//chuyen di noi khac
        }

        private void rb_XemInPhanCongGiangDay_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBoxPCGD.Enabled = false;
            this.groupboxXemPCGD.Enabled = true;
            this.dtg_phancong.Enabled = true;
        }

        private void rad_tenlophoc_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = true;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void rad_tenmonhoc_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = true;
            this.cbb_tengiaovien2.Enabled = false;
        }

        private void rad_tengiaovien_CheckedChanged(object sender, EventArgs e)
        {
            this.cbb_tenlophoc2.Enabled = false;
            this.cbb_tenmonhoc2.Enabled = false;
            this.cbb_tengiaovien2.Enabled = true;
        }

        private void btn_hienthi_Click(object sender, EventArgs e)
        {
            this.dtg_phancong.Enabled = true;

            if (rad_tenlophoc.Checked)
                dtg_phancong.DataSource = phanconggiangdayh.LookXemPhanCongGiangDay("MaLop", cbb_tenlophoc2.SelectedValue.ToString());
            if (rad_tenmonhoc.Checked)
                dtg_phancong.DataSource = phanconggiangdayh.LookXemPhanCongGiangDay("MaMH", cbb_tenmonhoc2.SelectedValue.ToString());
            if (rad_tengiaovien.Checked)
                dtg_phancong.DataSource = phanconggiangdayh.LookXemPhanCongGiangDay("MaCanBoGV", cbb_tengiaovien2.SelectedValue.ToString());

        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH PHÂN CÔNG GIẢNG DẠY", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, new PointF(110, 80));

            if (rad_tenlophoc.Checked)
            {
                e.Graphics.DrawString("Tên Lớp Học:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 140));
                e.Graphics.DrawString(cbb_tenlophoc2.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(400, 140));
            }
            if (rad_tenmonhoc.Checked)
            {
                e.Graphics.DrawString("Tên Môn Học:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 170));
                e.Graphics.DrawString(cbb_tenmonhoc.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(400, 170));
            }
            if (rad_tengiaovien.Checked)
            {
                e.Graphics.DrawString("Tên Giáo Viên:", new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new PointF(190, 200));
                e.Graphics.DrawString(cbb_tengiaovien2.Text, new Font("Times New Roman", 18, FontStyle.Italic), Brushes.Black, new PointF(400, 200));
            }


            Bitmap bm = new Bitmap(this.dtg_phancong.Width, this.dtg_phancong.Height);
            dtg_phancong.DrawToBitmap(bm, new Rectangle(0, 0, this.dtg_phancong.Width, this.dtg_phancong.Height));
            e.Graphics.DrawImage(bm, 60, 330);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 600));
            e.Graphics.DrawString("Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 640));
            e.Graphics.DrawString("Nguyễn Ngọc Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 680));
        }

        private void btn_inbangphancong_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        
    }
}
