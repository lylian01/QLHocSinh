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

namespace GUI
{
    public partial class Form_UC2_CaiDat : Form
    {
        public Form_UC2_CaiDat()
        {
            InitializeComponent();
        }
        
        BUS_UC2_CaiDat caidat = new BUS_UC2_CaiDat();
        DTO_UC2_CaiDat L = new DTO_UC2_CaiDat();

        private void Form_UC2_CaiDat_Load(object sender, EventArgs e)
        {
            dtgQuyDinh.DataSource = caidat.ShowQuyDinh();
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string mk = Form_UC3_DangNhap.matkhau;
            string tk = Form_UC3_DangNhap.taikhoan;
            if (txt_MatKhauCu.Text.Length == 0 || txt_MatKhauMoi.Text.Length == 0 || txt_XacNhanMatKhau.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải điền toàn bộ các ô", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_MatKhauCu.Text != mk)
            {
                MessageBox.Show("Mật khẩu của bạn không chính xác. Hãy kiểm tra lại!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_MatKhauMoi.Text != txt_XacNhanMatKhau.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp. Hãy kiểm tra lại!", "Đổi mật khẩu không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            caidat.DoiMatKhau(tk, txt_MatKhauMoi.Text);
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            Form_UC3_DangNhap.matkhau = txt_MatKhauMoi.Text;
            txt_MatKhauCu.Clear();
            txt_MatKhauMoi.Clear();
            txt_XacNhanMatKhau.Clear();
            txt_MatKhauCu.Focus();
        }
        
        private void eyehide1_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.PasswordChar == '*')
            {
                eyeshow1.BringToFront();
                txt_MatKhauMoi.PasswordChar = '\0';
            }
        }

        private void eyeshow1_Click(object sender, EventArgs e)
        {
            if (txt_MatKhauMoi.PasswordChar == '\0')
            {
                eyehide1.BringToFront();
                txt_MatKhauMoi.PasswordChar = '*';
            }
        }

        private void eyehide2_Click(object sender, EventArgs e)
        {
            if (txt_XacNhanMatKhau.PasswordChar == '*')
            {
                eyeshow2.BringToFront();
                txt_XacNhanMatKhau.PasswordChar = '\0';
            }
        }

        private void eyeshow2_Click(object sender, EventArgs e)
        {
            if (txt_XacNhanMatKhau.PasswordChar == '\0')
            {
                eyehide2.BringToFront();
                txt_XacNhanMatKhau.PasswordChar = '*';
            }
        }
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         /*  */

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if(txtTTD.TextLength == 0) { MessageBox.Show("Không được để trống tuổi tối đa "); }
            else if (txtTTT.TextLength == 0) { MessageBox.Show("Không được để trống tuổi tối thiểu "); }
            else if (txtSSTD.TextLength == 0) { MessageBox.Show("Không được để trống sỉ số tối đa "); }
            else if (txtSSTD.TextLength == 0) { MessageBox.Show("Không được để trống sỉ số tối thiểu  "); }
            else if (txtDDM.TextLength == 0) { MessageBox.Show("Không được để trống điểm đạt môn "); }
            else
            {
                try
                {
                    L.TuoiTD_ = Int32.Parse(txtTTD.Text);
                    L.TuoiTT_ = Int32.Parse(txtTTT.Text);
                    L.SiSoTD_ = Int32.Parse(txtSSTD.Text);
                    L.SiSoTT_ = Int32.Parse(txtSSTT.Text);
                    L.DiemDM_ = Int32.Parse(txtDDM.Text);

                    caidat.SuaQuyDinh(L.TuoiTD_, L.TuoiTT_, L.SiSoTD_, L.SiSoTT_, L.DiemDM_);
                    MessageBox.Show("Sửa quy định thành công !");
                    Form_UC2_CaiDat_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("Có lỗi !!!!!!!!!!!!!");
                }
            }
        }

        private void dtgQuyDinh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtTTD.Text = dtgQuyDinh.Rows[dong].Cells[0].Value.ToString();
            txtTTT.Text = dtgQuyDinh.Rows[dong].Cells[1].Value.ToString();
            txtSSTD.Text = dtgQuyDinh.Rows[dong].Cells[2].Value.ToString();
            txtSSTT.Text = dtgQuyDinh.Rows[dong].Cells[3].Value.ToString();
            txtDDM.Text = dtgQuyDinh.Rows[dong].Cells[4].Value.ToString();
        }
    }
}
