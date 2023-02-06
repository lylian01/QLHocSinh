using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC1_QuanLyLopHoc
    {
        string malop_, tenlop_, makhoi_, mank_, macanbogv_;
        int siso_;

        public string Malop_ { get => malop_; set => malop_ = value; }
        public string Tenlop_ { get => tenlop_; set => tenlop_ = value; }
        public string Makhoi_ { get => makhoi_; set => makhoi_ = value; }
        public string Nienkhoa_ { get => mank_; set => mank_ = value; }
        public string Giaovienchunhiem_ { get => macanbogv_; set => macanbogv_ = value; }
        public int Siso_ { get => siso_; set => siso_ = value; }
    }
}
