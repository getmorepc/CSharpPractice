using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnFourLetterStrings
{
    public class Class1
    {
        //Create a function that takes an array of strings. 
        //Return all words in the array that are exactly four letters.

        public static string[] IsFourLetters(string[] arr)
        {
            return arr.Where(str => str.Length == 4).ToArray();
        }
    }
}
