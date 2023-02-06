using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using BUS;
using System.Data;

namespace BUS
{
    public class BUS_UC1_QuanLyMonHoc
    {
        Data da = new Data();
        DTO_UC1_QuanLyMonHoc L = new DTO_UC1_QuanLyMonHoc();

        public DataTable ShowMonHoc()
        {
            string sql = "select * from MonHoc";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertMonHoc(string mmh, string tmh, int st)
        {
            string sql = "insert MonHoc values(N'" + mmh + "',N'" + tmh + "',N'" + st + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateMonHoc(string mmh, string tmh, int st)
        {
            string sql = "update MonHoc set TenMH=N'" + tmh + "', SoTiet=N'" + st + "' where MaMH=N'" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteMonHoc(string mmh)
        {
            string sql = "delete MonHoc where MaMH = N'" + mmh + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookMonHoc(string dk)
        {
            string sql = "select * from MonHoc where MaMH like N'%" + dk + "%' OR TenMH like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
