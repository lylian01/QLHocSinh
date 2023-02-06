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
    public partial class Form_UC1_QuanLyMonHoc : Form
    {
        public Form_UC1_QuanLyMonHoc()
        {
            InitializeComponent();
        }
        DTO_UC1_QuanLyMonHoc L = new DTO_UC1_QuanLyMonHoc();
        BUS_UC1_QuanLyMonHoc monhoch = new BUS_UC1_QuanLyMonHoc();
        private void Form_QuanLyMonHoc_Load(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = monhoch.ShowMonHoc();
        }

        private void dgv_MonHoc_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaMoHoc.Text = dgv_MonHoc.Rows[dong].Cells[0].Value.ToString();
            txt_TenMonHoc.Text = dgv_MonHoc.Rows[dong].Cells[1].Value.ToString();
            txt_SoTiet.Text = dgv_MonHoc.Rows[dong].Cells[2].Value.ToString();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_MonHoc.DataSource = monhoch.ShowMonHoc();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_MaMoHoc.Clear(); 
            txt_TenMonHoc.Clear();
            txt_SoTiet.Clear();
            txt_TimKiem.Clear();
            txt_MaMoHoc.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaMoHoc.TextLength == 0)
                MessageBox.Show("Mã Môn Học không được để trống!");
            else if (txt_TenMonHoc.TextLength == 0)
                MessageBox.Show("Tên Môn Học không được để trống!");
            else if(txt_SoTiet.TextLength == 0)
                MessageBox.Show("Số Tiết không được để trống!");
            else
            {
                try
                {
                    L.Mamonhoc_ = txt_MaMoHoc.Text;
                    L.Tenmonhoc_ = txt_TenMonHoc.Text;
                    L.Sotiet_ = Int32.Parse(txt_SoTiet.Text);
                    monhoch.InsertMonHoc(L.Mamonhoc_, L.Tenmonhoc_, L.Sotiet_);
                    MessageBox.Show("Thêm thành công!");
                    Form_QuanLyMonHoc_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaMoHoc.TextLength == 0)
                MessageBox.Show("Mã Môn Học không được để trống!");
            else if (txt_TenMonHoc.TextLength == 0)
                MessageBox.Show("Tên Môn Học không được để trống!");
            else if (txt_SoTiet.TextLength == 0)
                MessageBox.Show("Số Tiết không được để trống!");
            else
            {
                try
                {
                    L.Mamonhoc_ = txt_MaMoHoc.Text;
                    L.Tenmonhoc_ = txt_TenMonHoc.Text;
                    L.Sotiet_ = Int32.Parse(txt_SoTiet.Text);

                    
                    monhoch.UpdateMonHoc(L.Mamonhoc_, L.Tenmonhoc_, L.Sotiet_);
                    MessageBox.Show("Sửa thành Công ! ");
                    Form_QuanLyMonHoc_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaMoHoc.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã môn học để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Mamonhoc_ = txt_MaMoHoc.Text;
                    monhoch.DeleteMonHoc(L.Mamonhoc_);
                    MessageBox.Show("Đã Xóa Thành Công");
                    Form_QuanLyMonHoc_Load(sender, e);
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
                dgv_MonHoc.DataSource = monhoch.LookMonHoc(txt_TimKiem.Text);
            }
        }

    }
}
