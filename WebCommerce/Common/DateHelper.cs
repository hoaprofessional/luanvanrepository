using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class DateHelper
    {
        public static String DateStr(DateTime time)
        {
            return String.Format("{0:dd/MM/yy HH:mm}",
                time
            );

        }
    }
}
