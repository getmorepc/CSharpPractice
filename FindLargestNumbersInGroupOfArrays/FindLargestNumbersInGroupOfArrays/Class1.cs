using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindLargestNumbersInGroupOfArrays
{
    public class Class1
    {
        //Create a function that takes an array of arrays with numbers. 
        //Return a new (single) array with the largest numbers of each.

        public static double[] FindLargest(double[][] values)
        {
            int index = 0;
            int answerIndex = 0;
            double[] answer = new double[values.Length];

            do
            {
                answer[answerIndex] = values[index].Max();
                index++;
                answerIndex++;
            } while (index != values.Length);

            return answer;
        }
    }
}
