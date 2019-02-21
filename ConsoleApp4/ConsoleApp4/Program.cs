using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Reverser(string str)
            {
                int length = str.Length;
                char[] backwards = new char[length];  //creates a char array of the length of the string
                backwards = str.ToCharArray(); //turns the string into a char array and stores it in the backwards char array
                Array.Reverse(backwards); //reverses the backwards char array

                foreach (char val in backwards)
                {
                    Console.Write(val);
                }
                return backwards;
                //                Array.Reverse(backwards);
                //                return backwards.ToString();
            }
            Reverser("Forescore and seven years ago");
            Console.ReadLine();
        }
    }
}
