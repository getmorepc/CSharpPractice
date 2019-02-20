using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        //Create a function that takes a number as its only argument and 
        //returns true if it's less than or equal to zero, otherwise return false.
        public static bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
            {
                return true;
            }
            else return false;
        }
    }
}
