using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestBiggestNumbersFromArray
{
    public class Class1
    {
        //Create a function that takes an array of numbers and 
        //return both the minimum and maximum numbers, in that order.

        public static double[] FindMinMax(double[] values)
        {
            double[] answer = new double[2];

            answer[0] = values.Min();
            answer[1] = values.Max();

            return answer;
        }

    }
}
