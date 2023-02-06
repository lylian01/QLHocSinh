using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;

namespace GUI
{
    class Utility
    {
        public static CultureInfo myCultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
        static Utility()
        {
            myCultureInfo.NumberFormat.NumberDecimalSeparator = ".";
        }
        public static float ConvertToFloat(string s)
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";

            float value = float.Parse(s, NumberStyles.Float, ci);
            return value;
        }
        
    }
}
