using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParser
{
    public class Program
    {
        //Create a function that takes a string and 
        //returns the word count. The string will be a sentence.

        public static int CountWords(string str)
        {
            int index = 0;
            int wordCount = 0;

            while (index < str.Length)
            {
                //is this character a word?
                while (index < str.Length && !char.IsWhiteSpace(str[index]))
                    index++;

                wordCount++;

                //skip whitespace until next word
                while (index < str.Length && char.IsWhiteSpace(str[index]))
                    index++;
            }

            return wordCount;
        }
    }
}
