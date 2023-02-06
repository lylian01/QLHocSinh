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

namespace TrangChu
{
    public partial class Form_CaiDat : Form
    {
        public Form_CaiDat()
        {
            InitializeComponent();
        }
        BUS_UC3_CaiDat BUS_doiMK = new BUS_UC3_CaiDat();

        private void Form_CaiDat_Load(object sender, EventArgs e)
        {
            dt
        }
        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            string mk = Form_DangNhap.matkhau;
            string tk = Form_DangNhap.taikhoan;
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
            BUS_doiMK.DoiMatKhau(tk, txt_MatKhauMoi.Text);
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
            Form_DangNhap.matkhau = txt_MatKhauMoi.Text;
            txt_MatKhauCu.Clear();
            txt_MatKhauMoi.Clear();
            txt_XacNhanMatKhau.Clear();
            txt_MatKhauCu.Focus();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eyehide1_Click(object sender, EventArgs e)
        {
            if(txt_MatKhauMoi.PasswordChar == '*')
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

       
        //////////


    }
}
