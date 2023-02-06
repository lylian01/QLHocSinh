using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class BUS_UC1_QuanLyLopHoc
    {
        Data da = new Data();
        DTO_UC1_QuanLyLopHoc L = new DTO_UC1_QuanLyLopHoc();

        public DataTable ShowKhoi()
        {
            string sql = "select * from Khoi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowNienKhoa()
        {
            string sql = "select * from NienKhoa";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowLopHoc()
        {
            string sql = "select lp.MaLop,TenLop,TenKhoi,TenNienKhoa,SiSo,HoTenGV	from Lop lp inner join NienKhoa nk on lp.MaNK = nk.MaNK  inner join CanBoGiaoVien gv on lp.MaCanBoGV = gv.MaCanBoGV inner join Khoi kh on lp.MaKhoi = kh.MaKhoi";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowGiaoVien()
        {
            string sql = "select * from CanBoGiaoVien";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertLopHoc(string ml, string tl, string mk, string mnk, int ss, string mgv)  //them
        {
            string sql = "insert into Lop values(N'" + ml + "',N'" + tl + "',N'" + mk + "', N'" + mnk + "','" + ss + "',N'" + mgv + "')";
            //MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);
        }
        public void UpdateLopHoc(string ml, string tl, string mk, string mnk, int ss, string mgv)  //sua
        {
            string sql = "update Lop set TenLop= N'" + tl + "', SiSo='" + ss + "' where MaLop=N'" + ml + "'and MaCanBoGV=N'" + mgv + "'and MaNK=N'" + mnk + "' and MaKhoi = N'"+ mk +"' ";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteLopHoc(string ml, string mk, string mnk, string mgv)  //xoa
        {
            string sql = "delete Lop where MaLop = N'" + ml+ "' and MaKhoi = N'" + mk + "'and MaNK=N'" + mnk + "'and MaCanBoGV=N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookLopHoc(string dk)  //tim kiem
        {
            string sql = "select lp.MaLop,TenLop,TenKhoi,TenNienKhoa,SiSo,HoTenGV	from Lop lp inner join NienKhoa nk on lp.MaNK = nk.MaNK  inner join CanBoGiaoVien gv on lp.MaCanBoGV = gv.MaCanBoGV inner join Khoi kh on lp.MaKhoi = kh.MaKhoi where MaLop like N'%" + dk + "%' OR TenLop like N'%" + dk + "%' OR lp.MaCanBoGV like N'%" + dk + "%' OR lp.MaKhoi like N'%" + dk +"%' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
