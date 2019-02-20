using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser
{
    public class Program
    {
        //Create a function that takes two strings and returns true if 
        //the first argument ends with the second argument; otherewise return false

        public static bool CheckEnding(string str1, string str2)
        {
            if (str1.EndsWith(str2))
                {
                return true;
            }
            else return false;
        }
    }
}
