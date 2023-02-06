using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC3_PhanCongGiangDay
    {
        string tenlophoc_, tenmonhoc_, tencbgv_, ngayphancong_;

        public string Tenlophoc_ { get => tenlophoc_; set => tenlophoc_ = value; }
        public string Tenmonhoc_ { get => tenmonhoc_; set => tenmonhoc_ = value; }
        public string Tencbgv_ { get => tencbgv_; set => tencbgv_ = value; }
        public string Ngayphancong_ { get => ngayphancong_; set => ngayphancong_ = value; }
    }
}
