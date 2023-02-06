using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class BUS_UC2_CaiDat
    {
        Data da = new Data();
        public void DoiMatKhau(string taikhoan, string matkhaumoi)
        {
            string sql = "update CanBoGiaoVien set MatKhau='" + matkhaumoi + "' where TaiKhoan = '" + taikhoan + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable ShowQuyDinh()
        {
            string sql = "select * from ThamSo";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void SuaQuyDinh(int ttd, int ttt, int sstd, int sstt, int ddm)
        {
            string sql = "update ThamSo set TuoiToiDa=N'" + ttd + "', TuoiToiThieu=N'" + ttt + "', SiSoToiDa=N'" + sstd + "', SiSoToiThieu=N'" + sstt + "', DiemDatMon=N'" + ddm + "' ";
            da.ExcuteNonQuery(sql);
        }
    }
}
