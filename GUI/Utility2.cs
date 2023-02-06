using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SqlClient;
using System.Threading;

namespace GUI
{
    class Utility2
    {
        public static CultureInfo myCultureInfo = (CultureInfo)CultureInfo.CurrentCulture.Clone();
        static Utility2()
        {

            myCultureInfo.NumberFormat.NumberDecimalSeparator = ".";
        }
        public static float ConvertToFloat(string s)
        {
            CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            ci.NumberFormat.NumberDecimalSeparator = ".";

            float value = float.Parse(s, ci);
            return value;
        }

        // NumberStyles.Float,
    }
}
