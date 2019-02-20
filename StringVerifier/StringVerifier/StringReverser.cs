using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayValues
{
    public class StringReverser
    {
        //Create a function that takes a string as its argument and returns the string in reversed order.

        public static string Reverse(string str)
        {
            char[] backwards = str.ToCharArray();
            Array.Reverse(backwards);
            return backwards.ToString();
        }
    }
}
