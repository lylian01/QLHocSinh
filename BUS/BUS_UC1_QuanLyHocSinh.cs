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
    public class BUS_UC1_QuanLyHocSinh
    {
        Data da = new Data();
        DTO_UC1_QuanLyHocSinh L = new DTO_UC1_QuanLyHocSinh();

        public DataTable ShowHocSinh()
        {
            string sql = "select hs.MaHS,HoTenHS,NgaySinh,GioiTinh,DiaChi,Email,TenLop, hs.MaLop from HoSoHocSinh hs inner join Lop lp	on hs.MaLop = lp.MaLop ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTenLop()
        {
            string sql = "select * from Lop";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertHocSinh(string mhs, string ths, string ns, string gt, string dc, string eml, string ml)
        {

            string sql = "insert into HoSoHocSinh values(N'" + mhs + "',N'" + ths + "',N'" + ns + "',N'" + gt + "',N'" + dc + "',N'" + eml + "',N'" + ml + "')";
            //MessageBox.Show(sql);
            da.ExcuteNonQuery(sql);

        }
        
        public void UpdateHocSinh(string mhs, string ths, string ns, string gt, string dc, string eml, string ml)
        {
            string sql = "update HoSoHocSinh set HoTenHS=N'" + ths + "', NgaySinh=N'" + ns + "', GioiTinh=N'" + gt + "', DiaChi=N'" + dc + "', Email=N'" + eml + "', MaLop=N'" + ml + "' where MaHS=N'" + mhs + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteHocSinh(string mhs)
        {
            string sql = "delete HoSoHocSinh where MaHS = N'" + mhs + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookHocSinh(string dk)
        {
            string sql = "select MaHS,HoTenHS,NgaySinh,GioiTinh,DiaChi,Email,TenLop, HoSoHocSinh.MaLop from HoSoHocSinh inner join Lop on HoSoHocSinh.MaLop = Lop.MaLop where MaHS like N'%" + dk +"%' OR HoTenHS like N'%" + dk + "%' OR HoSoHocSinh.MaLop like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
