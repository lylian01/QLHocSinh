using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_UC2_CaiDat
    {
        int tuoitd_, tuoitt_, sisotd_, sisott_, diemdm_;

        public int TuoiTD_ { get => tuoitd_; set => tuoitd_ = value; }
        public int TuoiTT_ { get => tuoitt_; set => tuoitt_ = value; }
        public int SiSoTD_ { get => sisotd_; set => sisotd_ = value; }
        public int SiSoTT_ { get => sisott_; set => sisott_ = value; }
        public int DiemDM_ { get => diemdm_; set => diemdm_ = value; }
    }
}
