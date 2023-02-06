using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form_UC3_TrangChu : Form
    {
        public Form_UC3_TrangChu()
        {
            InitializeComponent();
        }
        private void Form_UC3_TrangChu_Load(object sender, EventArgs e)
        {
            bool isAdmin = Form_UC3_DangNhap.isAdmin;
            if (!isAdmin)
            {
                phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.Enabled = false;
            }
        }

        private void quảnLýMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC1_QuanLyMonHoc frm = new Form_UC1_QuanLyMonHoc() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            bool isAdmin = Form_UC3_DangNhap.isAdmin;
            if (!isAdmin)
            {
                frm.btn_Them.Enabled = false;
                frm.btn_Sua.Enabled = false;
                frm.btn_Xoa.Enabled = false;
            }

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.AliceBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_UC1_QuanLyHocSinh frm = new Form_UC1_QuanLyHocSinh() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.AliceBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }

        private void quảnLýLớpHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC1_QuanLyLopHoc frm = new Form_UC1_QuanLyLopHoc() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            bool isAdmin = Form_UC3_DangNhap.isAdmin;
            if (!isAdmin)
            {
                frm.btnthem.Enabled = false;
                frm.btnsua.Enabled = false;
                frm.btnxoa.Enabled = false;
            }

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.AliceBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }

        private void quảnLýCánBộGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC1_QuanLyCanBoGiaoVien frm = new Form_UC1_QuanLyCanBoGiaoVien() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            // Không phải là admin thì ko dc them xóa sửa
            bool isAdmin = Form_UC3_DangNhap.isAdmin;
            if (!isAdmin)
            {
                this.quảnLýCánBộGiáoViênToolStripMenuItem.Text = "Chi tiết giáo viên";
                frm.btnthem.Enabled = false;
                frm.btnsua.Enabled = false;
                frm.btnxoa.Enabled = false;
            }

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.AliceBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }

        private void quảnLýĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC2_ThemSuaXemInDiem frm = new Form_UC2_ThemSuaXemInDiem() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.AliceBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }

        private void phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC3_PhanCongGiangDay frm = new Form_UC3_PhanCongGiangDay() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 


            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.AliceBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.LightSkyBlue;
        }
        
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_UC2_CaiDat frm = new Form_UC2_CaiDat() { Dock = DockStyle.Fill /*vị trí*/, TopLevel = false, TopMost = true /*nằm trên*/};
            panel3.Controls.Clear();  // xóa form trên panel
            panel3.Controls.Add(frm);//thêm vào fORM
            frm.Show(); //Hiển thị Form
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; //ẩn các dấu thu phóng 

            bool isAdmin = Form_UC3_DangNhap.isAdmin;
            if (!isAdmin)
            {
                frm.btnThayDoi.Enabled = false;
            }

            //Điều chinh màu cho các button
            quảnLýHọcSinhToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýCánBộGiáoViênToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýMônHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýLớpHọcToolStripMenuItem.BackColor = Color.LightSkyBlue;
            quảnLýĐiểmToolStripMenuItem.BackColor = Color.LightSkyBlue;
            phânCôngGiảngDạyXemInPhânCôngToolStripMenuItem.BackColor = Color.LightSkyBlue;
            đổiMậtKhẩuToolStripMenuItem.BackColor = Color.AliceBlue;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dlr == DialogResult.Yes)
            {
                Form frm = new Form_UC3_DangNhap();
                Form_UC3_DangNhap.taikhoan = null;
                Form_UC3_DangNhap.matkhau = null;
                Form_UC3_DangNhap.hoTenCBGV = null;
                this.Close();
                frm.Show();
            }
        }

        private void thoátToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (traloi == DialogResult.OK)
                this.Close();

        }
    }
}
