using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FunctionContainer
    {
        public static string Main(string[] args)
        {
            IsEvenOrOdd(int num)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine("odd");
                }
                else
                    Console.WriteLine("even");
            }

            return IsEvenOrOdd(15);
        }
    }
}
