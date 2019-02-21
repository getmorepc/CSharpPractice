using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReducePattern
{
    public class Class1
    {
        //Take an array of integers (positive or negative or both) 
        //and return the sum of the absolute value of each element.

        public static int GetAbsSum(int[] arr)
        {
            int index = 0;
            int total = 0;

            do
            {
                arr[index] = Math.Abs(arr[index]);
                total = total + arr[index];
                index++;
            } while (index != arr.Length);
            return total;
        }
    }
}
