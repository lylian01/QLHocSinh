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

namespace GUI
{
    public partial class Form_UC3_DangNhap : Form
    {
        public Form_UC3_DangNhap()
        {
            InitializeComponent();
        }
        BUS_UC0_DangNhap bus_dangnhap = new BUS_UC0_DangNhap();
        public static bool isAdmin;
        public static string hoTenCBGV;
        public static string taikhoan;
        public static string matkhau;

        private void Form_UC3_DangNhap_Load(object sender, EventArgs e)
        {
            txt_TaiKhoan.Focus();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (txt_TaiKhoan.Text.Length == 0)
            {
                MessageBox.Show("Tài khoản không được bỏ trống", "Đăng nhập không thành công");
                return;
            }

            if (txt_MatKhau.Text.Length == 0)
            {
                MessageBox.Show("Mật khẩu không được bỏ trống", "Đăng nhập không thành công");
                return;
            }
            if (!bus_dangnhap.checkLogin(txt_TaiKhoan.Text, txt_MatKhau.Text))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Đăng nhập không thành công");
                return;
            }
            if (!bus_dangnhap.isAdmin(txt_TaiKhoan.Text, txt_MatKhau.Text))
                isAdmin = false;
            else isAdmin = true;
            {
                timer1.Enabled = true;
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes) Application.Exit();
        }

        private void chkShowpass_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowpass.Checked)
                txt_MatKhau.UseSystemPasswordChar = false;
            else
                txt_MatKhau.UseSystemPasswordChar = true;

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //hiển thị label chờ đơi
            lbChoidoi.Visible = true;
            progressBar1.Value = progressBar1.Value + 5;
            if (progressBar1.Value > 99)
            {
                taikhoan = txt_TaiKhoan.Text;
                matkhau = txt_MatKhau.Text;
                Form_UC3_TrangChu frmain = new Form_UC3_TrangChu();
                frmain.Show();
                this.Hide();
                timer1.Enabled = false;
            }
        }
    }
}
