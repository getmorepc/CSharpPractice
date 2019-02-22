using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnIndexofAllCapitalLetters
{
    public class Class1
    {
        //Create a function that takes a single string as argument and returns 
        //an ordered list containing the indexes of all capital letters in the string.

        public static int[] IndexOfCapitals(string str)
        {
            char[] letters = str.ToCharArray();
            int index = 0;
            int answerCount = 0;
            var upperCase = new List<int>();

            do
            {
                if (Char.IsUpper(letters[index]))
                {
                    upperCase.Add(letters[index]);
                    answerCount++;
                }

                index++;
            } while (index != letters.Length);

            return upperCase.ToArray() = new int[answerCount];
        }
    }
}
