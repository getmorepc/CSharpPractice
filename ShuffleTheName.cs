using System;
public class Program
{
    //Create a function that accepts a string (of a persons first and last name) 
    //and returns a string with the first and last name swapped.

    public static string NameShuffle(string str)
    {
        string[] words = str.Split(' ');
        Array.Reverse(words);
        string answer = String.Format("{0} {1}", words[0], words[1]);
        return answer;
    }
}