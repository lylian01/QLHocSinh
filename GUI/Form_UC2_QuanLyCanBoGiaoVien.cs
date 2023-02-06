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
    public partial class Form_UC2_QuanLyCanBoGiaoVien : Form
    {
        public Form_UC2_QuanLyCanBoGiaoVien()
        {
            InitializeComponent();
        }
        DTO_UC2_QuanLyCanBoGiaoVien L = new DTO_UC2_QuanLyCanBoGiaoVien();
        BUS_UC2_QuanLyCanBoGiaoVien cbgvh = new BUS_UC2_QuanLyCanBoGiaoVien();


        private void Form_QuanLyCanBoGiaoVien_Load(object sender, EventArgs e)
        {
            dgv_CBGV.DataSource = cbgvh.ShowCanBoGiaoVien();


            cbo_TrinhDo.DataSource = cbgvh.ShowTrinhDo();
            cbo_TrinhDo.DisplayMember = "TenTD";
            cbo_TrinhDo.ValueMember = "MaTD";

            cbo_LoaiTK.DataSource = cbgvh.ShowLoaiTaiKhoan();
            cbo_LoaiTK.DisplayMember = "LoaiTaiKhoan";
            cbo_LoaiTK.ValueMember = "LoaiTaiKhoan";


        }

        private void btn_Xem_Click(object sender, EventArgs e)
        {
            dgv_CBGV.DataSource = cbgvh.ShowCanBoGiaoVien();
        }

        private void dgv_CBGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            int dong = e.RowIndex;
            if (dgv_CBGV != null)
            {
                txt_MaCBGV.Text = dgv_CBGV.Rows[dong].Cells[0].Value.ToString();
                txt_TenCBGV.Text = dgv_CBGV.Rows[dong].Cells[1].Value.ToString();
                txt_DiaChi.Text = dgv_CBGV.Rows[dong].Cells[2].Value.ToString();
                txt_SoDienThoai.Text = dgv_CBGV.Rows[dong].Cells[3].Value.ToString();
                txt_TaiKhoan.Text = dgv_CBGV.Rows[dong].Cells[4].Value.ToString();
                txt_MatKhau.Text = dgv_CBGV.Rows[dong].Cells[5].Value.ToString();
                cbo_LoaiTK.Text = dgv_CBGV.Rows[dong].Cells[6].Value.ToString();
                cbo_TrinhDo.Text = dgv_CBGV.Rows[dong].Cells[7].Value.ToString();
            }
            else { }
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txt_MaCBGV.Clear();
            txt_TenCBGV.Clear();
            txt_DiaChi.Clear();
            txt_SoDienThoai.Clear();
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
            cbo_LoaiTK.Text = "";
            cbo_TrinhDo.Text = "";

            txt_MaCBGV.Focus();
        }
        

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (txt_MaCBGV.TextLength == 0)
                MessageBox.Show("Mã CBGV không được để trống!");
            else if (txt_TenCBGV.TextLength == 0)
                MessageBox.Show("Tên CBGV không được để trống!");
            else if (txt_DiaChi.TextLength == 0)
                MessageBox.Show("Địa Chỉ không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (txt_TaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được để trống!");
            else if (txt_MatKhau.TextLength == 0)
                MessageBox.Show("Mật khẩu không được để trống!");

            else
            {
                try
                {
                    L.Macbgv_ = txt_MaCBGV.Text;
                    L.Tencbgv_ = txt_TenCBGV.Text;
                    L.Diachi_ = txt_DiaChi.Text;
                    L.Sodienthoai_ = txt_SoDienThoai.Text;
                    L.Taikhoan_ = txt_TaiKhoan.Text;
                    L.Matkhau_ = txt_MatKhau.Text;
                    L.Loaitaikhoan_ = cbo_LoaiTK.SelectedValue.ToString();
                    L.Matrinhdo_ = cbo_TrinhDo.SelectedValue.ToString();//cho nhay cam

                    //MessageBox.Show("cec");

                    cbgvh.InsertCanBoGiaoVien(L.Macbgv_, L.Tencbgv_, L.Diachi_, L.Sodienthoai_, L.Taikhoan_, L.Matkhau_, L.Loaitaikhoan_, L.Matrinhdo_);

                    MessageBox.Show("Thêm thành công!");
                    Form_QuanLyCanBoGiaoVien_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗiiiiiiiiiiiiiiiiiiiiii!");
                }
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (txt_MaCBGV.TextLength == 0)
                MessageBox.Show("Mã CBGV không được để trống!");
            else if (txt_TenCBGV.TextLength == 0)
                MessageBox.Show("Tên CBGV không được để trống!");
            else if (txt_DiaChi.TextLength == 0)
                MessageBox.Show("Địa Chỉ không được để trống!");
            else if (txt_SoDienThoai.TextLength == 0)
                MessageBox.Show("SDT không được để trống!");
            else if (txt_TaiKhoan.TextLength == 0)
                MessageBox.Show("Tài khoản không được để trống!");
            else if (txt_MatKhau.TextLength == 0)
                MessageBox.Show("Mật khẩu không được để trống!");
            else
            {
                try
                {
                    L.Macbgv_ = txt_MaCBGV.Text;
                    L.Tencbgv_ = txt_TenCBGV.Text;
                    L.Diachi_ = txt_DiaChi.Text;
                    MessageBox.Show(" dc ");
                    L.Sodienthoai_ = txt_SoDienThoai.Text;
                    L.Taikhoan_ = txt_TaiKhoan.Text;
                    L.Matkhau_ = txt_MatKhau.Text;
                    MessageBox.Show("S mk ");
                    L.Loaitaikhoan_ = cbo_LoaiTK.SelectedValue.ToString();
                    MessageBox.Show(" tk ");
                    L.Matrinhdo_ = cbo_TrinhDo.SelectedValue.ToString();//cho nhay cam
                    MessageBox.Show("S td! ");


                    cbgvh.UpdateCanBoGiaoVien(L.Macbgv_, L.Tencbgv_, L.Diachi_, L.Sodienthoai_, L.Taikhoan_, L.Matkhau_, L.Loaitaikhoan_, L.Matrinhdo_);
                    MessageBox.Show("Sửa Thành Công ! ");
                    Form_QuanLyCanBoGiaoVien_Load(sender, e);
                }
                catch { MessageBox.Show("Có lỗi!"); }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (txt_MaCBGV.TextLength == 0)
                MessageBox.Show("Bạn cần nhập mã CBGV để xóa");
            else
            {
                DialogResult traloi;
                traloi = MessageBox.Show("Bạn chắc chắn muốn Xoá ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (traloi == DialogResult.OK)
                {
                    L.Macbgv_ = txt_MaCBGV.Text;
                    cbgvh.DeleteCanBoGiaoVien(L.Macbgv_);
                    MessageBox.Show("Đã Xóa THành CÔng");
                    Form_QuanLyCanBoGiaoVien_Load(sender, e);
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
                dgv_CBGV.DataSource = cbgvh.LookCanBoGiaoVien(txt_TimKiem.Text);
            }
        }


    }
}
