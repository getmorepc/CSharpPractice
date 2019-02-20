using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayValues
{
    public class ArrayValuesManipulator
    {
        //Create a function that takes an array of numbers and returns the following statistics:
        //Minimum Value
        //Maximum Value
        //Sequence Length
        //Average Value

        public static double[] MinMaxLengthAverage(double[] arr)
        {
            double[] answer = new double[4];
            double min = arr.Min();
            double max = arr.Max();
            double length = arr.Length;
            double average = arr.Average();

            answer[0] = min;
            answer[1] = max;
            answer[2] = length;
            answer[3] = average;

            return answer;
        }
    }
}
