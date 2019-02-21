using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapReducePattern
{
    public class Class1
    {
        //You will be implementing a basic case of the map-reduce pattern in programming. 
        //Given a vector stored as an array of numbers, find the magnitude of the vector. 
        //Use the standard distance formula for n-dimensional Cartesian coordinates.

        public static double Magnitude(int[] arr)
        {
            int index = 0;
            int total = 0;
            double answer = 0;

            if (arr.Length == 0)
            {
                return 0;
            }

            do
            {
                total = total + (arr[index] * arr[index]);
                index++;
            } while (index != arr.Length);
            answer = Math.Sqrt(total);
            return answer;
        }
    }
}
