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
    public partial class Form_UC2_QuanLyTrinhDo : Form
    {
        public Form_UC2_QuanLyTrinhDo()
        {
            InitializeComponent();
        }
        DTO_UC2_QuanLyTrinhDo L = new DTO_UC2_QuanLyTrinhDo();
        BUS_UC2_QuanLyTrinhDo trinhdoh = new BUS_UC2_QuanLyTrinhDo();
        private void Form_QuanLyTrinhDo_Load(object sender, EventArgs e)
        {
            dgv_TrinhDo.DataSource = trinhdoh.ShowTrinhDO();
        }

        private void dgv_TrinhDo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txt_MaTrinhDo.Text = dgv_TrinhDo.Rows[dong].Cells[0].Value.ToString();
            txt_TenTrinhDo.Text = dgv_TrinhDo.Rows[dong].Cells[1].Value.ToString();
        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_TrinhDo.DataSource = trinhdoh.ShowTrinhDO();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_MaTrinhDo.Clear();
            txt_TenTrinhDo.Clear();
            txt_TimKiem.Clear();
            txt_MaTrinhDo.Focus();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaTrinhDo.TextLength == 0)
                MessageBox.Show("Mã Trình Độ không được để trống!");
            else if (txt_TenTrinhDo.TextLength == 0)
                MessageBox.Show("Tên Trình Độ không được để trống!");
            else
            {
                try
                {
                    L.Matrinhdo_ = txt_MaTrinhDo.Text;
                    L.Tentrinhdo_ = txt_TenTrinhDo.Text;
                    trinhdoh.InsertTrinhDo(L.Matrinhdo_, L.Tentrinhdo_);
                    MessageBox.Show("Thêm thành công!");
                    Form_QuanLyTrinhDo_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_MaTrinhDo.TextLength == 0)
                MessageBox.Show("Mã Trình Độ không được để trống!");
            else if (txt_TenTrinhDo.TextLength == 0)
                MessageBox.Show("Tên Trình Độ không được để trống!");
            else
            {
                try
                {
                    L.Matrinhdo_ = txt_MaTrinhDo.Text;
                    L.Tentrinhdo_ = txt_TenTrinhDo.Text;


                    trinhdoh.UpdateTrinhDO(L.Matrinhdo_, L.Tentrinhdo_);
                    MessageBox.Show("Sửa Thành Công ! ");
                    Form_QuanLyTrinhDo_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (txt_MaTrinhDo.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã Trình Độ để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Matrinhdo_ = txt_MaTrinhDo.Text;
                    trinhdoh.DeleteTrinhDo(L.Matrinhdo_);
                    MessageBox.Show("Đã Xóa THành CÔng");
                    Form_QuanLyTrinhDo_Load(sender, e);
                }

            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            if (txt_TimKiem.TextLength == 0)
            {
                MessageBox.Show("Bạn cần nhập từ khóa để tìm kiếm.");

            }
            else
            {
                dgv_TrinhDo.DataSource = trinhdoh.LookTrinhDo(txt_TimKiem.Text);
            }
        }

          }
}
