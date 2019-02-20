using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Class1
    {
        public static bool TimeForMilkAndCookies(int year, int month, int day)
        {
            if (month == 12 && day == 24)
            {
                return true;
            }
            else return false;
        }
    }
}
