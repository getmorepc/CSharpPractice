using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class Class1
    {
        //Create a function that takes a number as an argument. 
        //Add up all the numbers from 1 to the number you passed to the function. 
        //For example, if the input is 4 then your function 
        //should return 10 because 1 + 2 + 3 + 4 = 10.
        public static int AddUp(int num)
        {
            int y = num;

            for (int i = 0; i < y; i++)
            {
                num = num + i;
            }

            return num;
        }
    }
}
