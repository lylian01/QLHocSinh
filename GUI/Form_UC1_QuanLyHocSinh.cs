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
    public partial class Form_UC1_QuanLyHocSinh : Form
    {
        public Form_UC1_QuanLyHocSinh()
        {
            InitializeComponent();
        }

        DTO_UC1_QuanLyHocSinh L = new DTO_UC1_QuanLyHocSinh();
        BUS_UC1_QuanLyHocSinh hocsinhh = new BUS_UC1_QuanLyHocSinh();

        private void Form_QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            dgv_HocSinh.DataSource = hocsinhh.ShowHocSinh();

            cbo_TenLop.DataSource = hocsinhh.ShowTenLop();
            cbo_TenLop.DisplayMember = "TenLop";
            cbo_TenLop.ValueMember = "MaLop";
        }
        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_HocSinh.DataSource = hocsinhh.ShowHocSinh();
        }

        private void dgv_LopHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaHocSinh.Text = dgv_HocSinh.Rows[dong].Cells[0].Value.ToString();
            txt_TenHocSinh.Text = dgv_HocSinh.Rows[dong].Cells[1].Value.ToString();
            txt_NgaySinh.Text = dgv_HocSinh.Rows[dong].Cells[2].Value.ToString();

            string gt = this.dgv_HocSinh.Rows[dong].Cells[3].Value.ToString();
            if (gt.Trim() == "Nam")
            {
                rb_Nam.Checked = true;
                
            }
            else
            {
                rb_Nu.Checked = true;
            }

            txt_DiaChi.Text = dgv_HocSinh.Rows[dong].Cells[4].Value.ToString();
            txt_Email.Text = dgv_HocSinh.Rows[dong].Cells[5].Value.ToString();
            cbo_TenLop.Text = dgv_HocSinh.Rows[dong].Cells[6].Value.ToString();
            
        }
        
        // nut nhập lại 
        private void button4_Click(object sender, EventArgs e)
        {
            txt_MaHocSinh.Clear();
            txt_TenHocSinh.Clear();
            txt_NgaySinh.Clear();

            rb_Nam.Checked = false;
            rb_Nu.Checked = false;

            txt_DiaChi.Clear();
            txt_Email.Clear();
            cbo_TenLop.Text = "";

            txt_MaHocSinh.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt_MaHocSinh.TextLength == 0)
                MessageBox.Show("Mã Học Sinh không được để trống!");
            else if (txt_TenHocSinh.TextLength == 0)
                MessageBox.Show("Tên Học Sinh không được để trống!");
            else if (txt_NgaySinh.TextLength == 0)
                MessageBox.Show("Ngày Sinh không được để trống!");
            else if (rb_Nam.Checked == false && rb_Nu.Checked == false)
                MessageBox.Show("Bạn phải chọn giới tính!");
            else if (txt_DiaChi.TextLength == 0)
                MessageBox.Show("Địa chỉ không được để trống!");
            else if (txt_Email.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else
            {
                try
                {
                    L.Mahocsinh_ = txt_MaHocSinh.Text;
                    L.Tenhocsinh_ = txt_TenHocSinh.Text;
                    L.Ngaysinh_ = txt_NgaySinh.Text;
                    

                    if (rb_Nam.Checked)
                    {
                        L.Gioitinh_ = "Nam";
                    }
                    else
                    {
                        L.Gioitinh_ = "Nu";
                    }

                    L.Diachi_ = txt_DiaChi.Text;
                    L.Email_ = txt_Email.Text;
                    L.TenLop_ = cbo_TenLop.SelectedValue.ToString();//cho nhay cam

                    hocsinhh.InsertHocSinh(L.Mahocsinh_, L.Tenhocsinh_, L.Ngaysinh_, L.Gioitinh_, L.Diachi_, L.Email_, L.TenLop_);

                    MessageBox.Show("Thêm thành công !");

                    Form_QuanLyHocSinh_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi !");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_MaHocSinh.TextLength == 0)
                MessageBox.Show("Mã Học Sinh không được để trống!");
            else if (txt_TenHocSinh.TextLength == 0)
                MessageBox.Show("Tên Học Sinh không được để trống!");
            else if (txt_NgaySinh.TextLength == 0)
                MessageBox.Show("Ngày Sinh không được để trống!");
            else if (rb_Nam.Checked == false && rb_Nu.Checked == false)
                MessageBox.Show("Bạn phải chọn giới tính!");
            else if (txt_DiaChi.TextLength == 0)
                MessageBox.Show("Địa chỉ không được để trống!");
            else if (txt_Email.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else
            {
                try
                {
                    L.Mahocsinh_ = txt_MaHocSinh.Text;
                    L.Tenhocsinh_ = txt_TenHocSinh.Text;
                    L.Ngaysinh_ = txt_NgaySinh.Text;

                    if (rb_Nam.Checked)
                    {
                        L.Gioitinh_ = "Nam";
                    }
                    else
                    {
                        L.Gioitinh_ = "Nu";
                    }

                    L.Diachi_ = txt_DiaChi.Text;
                    L.Email_ = txt_Email.Text;
                    L.TenLop_ = cbo_TenLop.SelectedValue.ToString();


                    hocsinhh.UpdateHocSinh(L.Mahocsinh_, L.Tenhocsinh_, L.Ngaysinh_, L.Gioitinh_, L.Diachi_, L.Email_, L.TenLop_);
                    MessageBox.Show("Sửa thành công ! ");
                    Form_QuanLyHocSinh_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗiiiiiiiiii!"); }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaHocSinh.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã học sinh để xóa ");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Mahocsinh_ = txt_MaHocSinh.Text;
                    hocsinhh.DeleteHocSinh(L.Mahocsinh_);

                    MessageBox.Show("Đã xóa thành công !");

                    Form_QuanLyHocSinh_Load(sender, e);
                }
            }
        }
       

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm !");
            }
            else
            {
                dgv_HocSinh.DataSource = hocsinhh.LookHocSinh(txt_TimKiem.Text);
            }
        }

        private void btn_indshs_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH HỌC SINH", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, new PointF(250, 80));


            Bitmap bm = new Bitmap(this.dgv_HocSinh.Width, this.dgv_HocSinh.Height);
            dgv_HocSinh.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv_HocSinh.Width, this.dgv_HocSinh.Height));
            e.Graphics.DrawImage(bm, 30, 230);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 600));
            e.Graphics.DrawString("Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 640));
            e.Graphics.DrawString("Nguyễn Ngọc Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 680));
        }

        
    }
}
