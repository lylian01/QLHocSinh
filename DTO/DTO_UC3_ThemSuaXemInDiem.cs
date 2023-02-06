using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC3_ThemSuaXemInDiem
    {
        string tenlop_, tenmonhoc_, tenhocky_, datmon_, mahocsinh_, tenhocsinh_;
        float diem15phut_, diem1tiet_, diemtbm_;

        public string Tenlop_ { get => tenlop_; set => tenlop_ = value; }
        public string Tenhocky_ { get => tenhocky_; set => tenhocky_ = value; }

        public string Mahocsinh_ { get => mahocsinh_; set => mahocsinh_ = value; }
        public string Tenmonhoc_ { get => tenmonhoc_; set => tenmonhoc_ = value; }
        public string Tenhocsinh_ { get => tenhocsinh_; set => tenhocsinh_ = value; }

        public float Diem15phut_ { get => diem15phut_; set => diem15phut_ = value; }
        public float Diem1tiet_ { get => diem1tiet_; set => diem1tiet_ = value; }
        public float DiemTBMon_ { get => diemtbm_; set => diemtbm_ = value; }
        public string Datmon_ { get => datmon_; set => datmon_ = value; }
    }
}
