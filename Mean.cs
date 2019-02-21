using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double Mean(int[] arr)
            {
                int index = 0;
                double total = 0;
                double answer = 0;

                do
                {
                    total = total + arr[index];
                    index++;
                } while (index != arr.Length);

                answer = total / arr.Length;
                //if (index != arr.Length)
                //{
                //    total = total + arr[index];
                //    index++;
                //}
                //else answer = total / arr.Length;
                return answer;
            }
            Mean([1, 0, 4, 5, 2, 4, 1, 2, 3, 3, 3]);
        }
    }
}
