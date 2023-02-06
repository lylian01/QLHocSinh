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
    public class BUS_UC1_QuanLyCanBoGiaoVien
    {
        Data da = new Data();
        DTO_UC1_QuanLyCanBoGiaoVien L = new DTO_UC1_QuanLyCanBoGiaoVien();

        public DataTable ShowCanBoGiaoVien()
        {
            string sql = "select gv.MaCanBoGV,HoTenGV,DiaChi,SoDienThoai,TaiKhoan,MatKhau,LoaiTaiKhoan, gv.MaTD,TenTD  from CanBoGiaoVien gv inner join TrinhDo td on gv.MaTD = td.MaTD";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowTrinhDo()
        {
            string sql = "select * from TrinhDo";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable ShowLoaiTaiKhoan()
        {
            string sql = "select distinct LoaiTaiKhoan from CanBoGiaoVien order by LoaiTaiKhoan";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public void InsertCanBoGiaoVien(string mcb, string tcb, string dc, string sdt, string tk, string mk, string ltk, string mtd)
        {
            string sql = "insert CanBoGiaoVien values(N'" + mcb + "',N'" + tcb + "',N'" + dc + "',N'" + sdt + "',N'" + tk + "','" + mk + "',N'" + ltk + "',N'" + mtd + "')";
            da.ExcuteNonQuery(sql);
        }
        public void UpdateCanBoGiaoVien(string mcb, string tcb, string dc, string sdt, string tk, string mk, string ltk, string mtd)
        {
            string sql = "update CanBoGiaoVien set HoTenGV=N'" + tcb + "', DiaChi=N'" + dc + "', SoDienThoai=N'" + sdt + "', TaiKhoan=N'" + tk + "', MatKhau='" + mk + "', LoaiTaiKhoan=N'" + ltk + "', MaTD=N'" + mtd + "' where MaCanBoGV=N'" + mcb + "'";
            da.ExcuteNonQuery(sql);//da xong
        }
        public void DeleteCanBoGiaoVien(string mcb)
        {
            string sql = "delete CanBoGiaoVien where MaCanBoGV = N'" + mcb + "'";
            da.ExcuteNonQuery(sql);
        }
        public DataTable LookCanBoGiaoVien(string dk)
        {
            string sql = "select gv.MaCanBoGV,HoTenGV,DiaChi,SoDienThoai,TaiKhoan,MatKhau,LoaiTaiKhoan,TenTD  from CanBoGiaoVien gv inner join TrinhDo td on gv.MaTD = td.MaTD where MaCanBoGV like N'%" + dk + "%' OR HoTenGV like N'%" + dk + "%' OR DiaChi like N'%" + dk + "%' OR TaiKhoan like N'%" + dk + "%' OR LoaiTaiKhoan like '%" + dk + "%' OR gv.MaTD like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

        
    }
}
