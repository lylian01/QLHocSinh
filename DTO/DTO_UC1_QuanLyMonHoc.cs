using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC1_QuanLyMonHoc
    {
        string mamonhoc_, tenmonhoc_;
        int sotiet_;

        public string Mamonhoc_ { get => mamonhoc_; set => mamonhoc_ = value; }
        public string Tenmonhoc_ { get => tenmonhoc_; set => tenmonhoc_ = value; }
        public int Sotiet_ { get => sotiet_; set => sotiet_ = value; }
    }
}
