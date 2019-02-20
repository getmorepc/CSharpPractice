using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static string IsEvenOrOdd(int num)
    {
        num = 15;

        if (num % 2 != 0)
        {
            return ("odd");
        }
        else return ("even");
    }
}