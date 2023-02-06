using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using BUS;
using DAL;
using System.Data;

namespace BUS
{
    public class BUS_UC2_QuanLyTrinhDo
    {
        Data da = new Data();
        DTO_UC2_QuanLyTrinhDo L = new DTO_UC2_QuanLyTrinhDo();

        public DataTable ShowTrinhDO()
        {
            string sql = "select * from TrinhDo9";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        public void InsertTrinhDo(string mtd, string ttd)
        {
            string sql = "insert TrinhDo9 values(N'" + mtd + "',N'" + ttd + "',N'" +  "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateTrinhDO(string mtd, string ttd)
        {
            string sql = "update TrinhDo9 set TenTD=N'" + ttd  + "' where MaTD=N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
        public void DeleteTrinhDo(string mtd)
        {
            string sql = "delete TrinhDo9 where MaTD = N'" + mtd + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookTrinhDo(string dk)
        {
            string sql = "select * from TrinhDo9 where MaTD like N'%" + dk + "%' OR TenTD like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
