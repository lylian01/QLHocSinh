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
    public class BUS_UC3_ThemSuaXemInDiem
    {
        Data da = new Data();
        DTO_UC3_ThemSuaXemInDiem L = new DTO_UC3_ThemSuaXemInDiem();

        public DataTable ShowTenLop()
        {
            string sql = "select * from Lop9";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenHocKy()
        {
            string sql = "select * from HocKy";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenMon()
        {
            string sql = "select * from MonHoc9";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowHSLop(string ml)
        {
            string sql = "select hs.MaHS from Lop9 lp inner join HoSoHocSinh9 hs on lp.MaLop = hs.MaLop  where lp.MaLop = '" + ml + "' ";
            DataTable dt = new DataTable();
            dt.Clear();
            dt = da.GetTable(sql);
            return dt;
        }


        public DataTable ShowDiem(string ml, string mhk)
        {
            string sql = "select hs.MaHS,HoTenHS,TenMH,Diem15p,Diem1tiet,DiemTBMon,DatMon  from HoSoHocSinh9 hs inner join DiemMon dm on hs.MaHS = dm.MaHS inner join MonHoc9 mh on dm.MaMH = mh.MaMH inner join HocKy hk on dm.MaHKy = hk.MaHKy where dm.MaHKy = '" + mhk + "' and hs.MaLop = N'" + ml + "' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertDiem(string mhs, string mm,string mhk , float d15p, float d1t,float dtb , string dm)
        {
            string sql = "insert into DiemMon values(N'" + mhs + "',N'" + mm + "',N'" + mhk + "','" + d15p + "','" + d1t + "','" + dtb + "',N'" + dm + "')";
            MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);
        }
        public void UpdateDiem(string mhs, string mm, string mhk, float d15p, float d1t, float dtb, string dm)
        {
            string sql = "update DiemMon set Diem15p = '" + d15p + "', Diem1tiet = '" + d1t + "', DiemTBMon = '" + dtb + "', DatMon = N'" + dm + "' where MaHS = '" + mhs + "' and MaMH = '" + mm + "' and MaHKy = '" + mhk + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteDiem(string mhs, string mm, string mhk)
        {
            string sql = "delete DiemMon where MaHS ='" + mhs + "' and MaMH = '" + mm + "' and MaHKy = '" + mhk + "' ";
            da.ExcuteNonQuery(sql);
        }
    }
}
