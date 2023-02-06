using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using DAL;

namespace GUI
{
    public partial class Form_UC1_QuanLyLopHoc : Form
    {
        public Form_UC1_QuanLyLopHoc()
        {
            InitializeComponent();
        }
        DTO_UC1_QuanLyLopHoc L = new DTO_UC1_QuanLyLopHoc();
        BUS_UC1_QuanLyLopHoc lophoch = new BUS_UC1_QuanLyLopHoc();

        private void Form_QuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dgv_LopHoc.DataSource = lophoch.ShowLopHoc();

            cbo_khoi.DataSource = lophoch.ShowKhoi();
            cbo_khoi.DisplayMember = "TenKhoi";
            cbo_khoi.ValueMember = "MaKhoi";

            cbb_nienkhoa.DataSource = lophoch.ShowNienKhoa();
            cbb_nienkhoa.DisplayMember = "TenNienKhoa";
            cbb_nienkhoa.ValueMember = "MaNK";

            cbb_gvcn.DataSource = lophoch.ShowGiaoVien();
            cbb_gvcn.DisplayMember = "HoTenGV";
            cbb_gvcn.ValueMember = "MaCanBoGV";
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_LopHoc.DataSource = lophoch.ShowLopHoc();
        }

        private void dgv_LopHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaLop.Text = dgv_LopHoc.Rows[dong].Cells[0].Value.ToString();
            txt_TenLop.Text = dgv_LopHoc.Rows[dong].Cells[1].Value.ToString();
            cbo_khoi.Text = dgv_LopHoc.Rows[dong].Cells[2].Value.ToString();
            cbb_nienkhoa.Text = dgv_LopHoc.Rows[dong].Cells[3].Value.ToString();
            txt_SiSo.Text = dgv_LopHoc.Rows[dong].Cells[4].Value.ToString();
            cbb_gvcn.Text = dgv_LopHoc.Rows[dong].Cells[5].Value.ToString();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txt_MaLop.Clear();
            txt_TenLop.Clear();
            cbo_khoi.Text = "";
            cbb_nienkhoa.Text = "";
            txt_SiSo.Clear();
            cbb_gvcn.Text = "";

            txt_MaLop.Focus();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            L.Siso_ = Int32.Parse(txt_SiSo.Text);
            if (txt_MaLop.TextLength == 0)
                MessageBox.Show("Mã Lớp không được để trống!");
            else if (txt_TenLop.TextLength == 0)
                MessageBox.Show("Tên Lớp không được để trống!");
            else if (cbo_khoi.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn khối ");
            else if (txt_SiSo.TextLength == 0)
                MessageBox.Show("Sĩ số không được để trống!");
            else if (L.Siso_ > 40)
                MessageBox.Show("Sĩ số không được quá 40 !");
            else
            {
                try
                {
                    L.Malop_ = txt_MaLop.Text;
                    L.Tenlop_ = txt_TenLop.Text;
                    L.Makhoi_ = cbo_khoi.SelectedValue.ToString();
                    L.Nienkhoa_ = cbb_nienkhoa.SelectedValue.ToString();
                    // lay o tren L.Siso_ = Int32.Parse(txt_SiSo.Text);
                    L.Giaovienchunhiem_ = cbb_gvcn.SelectedValue.ToString();//cho nhay cam

                    //MessageBox.Show("cec");

                    lophoch.InsertLopHoc(L.Malop_, L.Tenlop_, L.Makhoi_, L.Nienkhoa_, L.Siso_, L.Giaovienchunhiem_);

                    MessageBox.Show("Thêm thành công!");
                    Form_QuanLyLopHoc_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗiiiiiiiiiiiiiiiiiii!");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_MaLop.TextLength == 0)
                MessageBox.Show("Mã Lớp không được để trống!");
            else if (txt_TenLop.TextLength == 0)
                MessageBox.Show("Tên Lớp không được để trống!");
            else if (cbo_khoi.SelectedItem == null)
                MessageBox.Show("Vui lòng chọn khối ");
            else if (txt_SiSo.TextLength == 0)
                MessageBox.Show("Sĩ số không được để trống!");
            else if (0 < L.Siso_ && L.Siso_ < 40 )
                MessageBox.Show("Sĩ số không được quá 40 !");
            else
            {
                try
                {
                    L.Malop_ = txt_MaLop.Text;
                    L.Tenlop_ = txt_TenLop.Text;
                    L.Makhoi_ = cbo_khoi.SelectedValue.ToString();
                    L.Nienkhoa_ = cbb_nienkhoa.SelectedValue.ToString();
                    L.Siso_ = Int32.Parse(txt_SiSo.Text);
                    L.Giaovienchunhiem_ = cbb_gvcn.SelectedValue.ToString();//cho nhay cam

                    lophoch.UpdateLopHoc(L.Malop_, L.Tenlop_, L.Makhoi_, L.Nienkhoa_, L.Siso_, L.Giaovienchunhiem_);
                    MessageBox.Show("Sửa thành công ! ");
                    Form_QuanLyLopHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaLop.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã lớp để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Nienkhoa_ = cbb_nienkhoa.SelectedValue.ToString();
                    L.Giaovienchunhiem_ = cbb_gvcn.SelectedValue.ToString();
                    L.Malop_ = txt_MaLop.Text;
                    L.Makhoi_ = cbo_khoi.SelectedValue.ToString();
                    lophoch.DeleteLopHoc(L.Malop_, L.Makhoi_ , L.Nienkhoa_, L.Giaovienchunhiem_);
                    MessageBox.Show("Đã xóa thành công !");
                    Form_QuanLyLopHoc_Load(sender, e);
                }
            }
        }
      
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm.");
            }
            else
            {
                dgv_LopHoc.DataSource = lophoch.LookLopHoc(txt_TimKiem.Text);
            }
        }

        private void btn_indsgv1lop_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("DANH SÁCH LỚP", new Font("Times New Roman", 24, FontStyle.Bold), Brushes.Black, new PointF(256, 80));
            
            Bitmap bm = new Bitmap(this.dgv_LopHoc.Width, this.dgv_LopHoc.Height);
            dgv_LopHoc.DrawToBitmap(bm, new Rectangle(0, 0, this.dgv_LopHoc.Width, this.dgv_LopHoc.Height));
            e.Graphics.DrawImage(bm, 30, 230);

            e.Graphics.DrawString("Người Lập Phiếu", new Font("Times New Roman", 14, FontStyle.Italic), Brushes.Black, new PointF(565, 500));
            e.Graphics.DrawString("Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(600, 540));
            e.Graphics.DrawString("Nguyễn Ngọc Thi", new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new PointF(550, 580));
        }
    }
}
