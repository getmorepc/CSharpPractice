using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser
{
    public class Program
    {
        //Create a function that takes an array of numbers. Return the largest number in the array.

        public static int FindLargestNum(int[] arr)
        {
            int index = 0;
            int firstNumber;
            int biggest = 0;

            while (index < arr.Length)
            {
                firstNumber = arr[index];

                if (firstNumber > biggest)
                {
                    biggest = firstNumber;
                }
                index++;

            }
            return biggest;
        }
    }
}
