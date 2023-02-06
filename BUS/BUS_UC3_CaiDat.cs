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
    public class BUS_UC3_CaiDat
    {
        Data da = new Data();
        

        public void DoiMatKhau(string taikhoan, string matkhaumoi)
        {
            string sql = "update CanBoGiaoVien9 set MatKhau='" + matkhaumoi + "' where TaiKhoan = '" + taikhoan + "'";
            da.ExcuteNonQuery(sql);
        }
        //public DataTable ShowQuyDinh()
        //{
        //    string sql = "select * from QuyDinh";
        //    da.ExcuteNonQuery(sql);
        //}

    }
}
