using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_UC3_PhanCongGiangDay
    {
        Data da = new Data();
        DTO_UC3_PhanCongGiangDay L = new DTO_UC3_PhanCongGiangDay();


        //lam cuoi
        public DataTable ShowPCGD()
        {
            string sql = "select TenLop,TenMH,HoTenGV,NgayPhanCong from PhanCongGiangDay pc inner join Lop lp on pc.MaLop = lp.MaLop inner join MonHoc mh on pc.MaMH = mh.MaMH inner join CanBoGiaoVien gv on pc.MaCanBoGV = gv.MaCanBoGV";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLopHoc()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenMonHoc()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenCBGV()
        {
            string sql = "select * from CanBoGiaoVien";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }


        public void InsertPhanCongGiangDay(string ml, string mmh, string mgv, string ngay)
        {
            string sql = "insert PhanCongGiangDay values(N'" + ml + "',N'" + mmh + "',N'" + mgv + "',N'" + ngay + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdatePhanCongGiangDay(string ml, string mmh, string mgv, string ngay)
        {
            string sql = "update PhanCongGiangDay set NgayPhanCong = '" + ngay +  "' where MaLop = N'" + ml + "' and MaMH = N'" + mmh + "' and MaCanBoGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeletePhanCongGiangDay(string ml, string mmh, string mgv)
        {
            string sql = "delete PhanCongGiangDay where MaLop = N'" + ml + "' and MaMH = N'" + mmh + "' and MaCanBoGV = N'" + mgv + "'";
            da.ExcuteNonQuery(sql);
        }
       
        
        public DataTable LookXemPhanCongGiangDay(string dk1,string dk2)
        {
            string sql = "select TenLop, TenMH, HoTenGV, NgayPhanCong from PhanCongGiangDay inner join Lop on PhanCongGiangDay.MaLop = Lop.MaLop inner join MonHoc on PhanCongGiangDay.MaMH = MonHoc.MaMH inner join CanBoGiaoVien on PhanCongGiangDay.MaCanBoGV = CanBoGiaoVien.MaCanBoGV where PhanCongGiangDay." + dk1 + " = N'" + dk2 + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
