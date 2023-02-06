using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC1_QuanLyHocSinh
    {
        string mahocsinh_, tenhocsinh_, ngaysinh_, gioitinh_, diachi_, email_, tenlop_;
       
        
        public string Mahocsinh_ { get => mahocsinh_; set => mahocsinh_ = value; }
        public string Tenhocsinh_ { get => tenhocsinh_; set => tenhocsinh_ = value; }
        public string Ngaysinh_ { get => ngaysinh_; set => ngaysinh_ = value; }
        public string Gioitinh_ { get => gioitinh_; set => gioitinh_ = value; }
        public string Diachi_ { get => diachi_; set => diachi_ = value; }
        public string Email_ { get => email_; set => email_ = value; }
        public string TenLop_ { get => tenlop_; set => tenlop_ = value; }
    }
}
