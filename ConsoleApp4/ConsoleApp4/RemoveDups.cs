using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        //Create a function that takes an array of items, removes all duplicate items and 
        //returns a new array in the same sequential order as the old array (minus duplicates).

        static void Main(string[] args)
        {
            object[] RemoveDups(object[] str)
            {
                int index = 0;
                var nonDups = new List<object>();
                nonDups.Add(str.Distinct());
                object[] answer = new object[str.Distinct().Count()];

                if (index != str.Distinct().Count())
                {
                    answer[index] = nonDups[index];
                    index++;
                }
                return answer[];
            }
            RemoveDups(["John", "Taylor", "John"]);
            Console.ReadLine();
        }
    }
}
