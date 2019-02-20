using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayValues
{
    public class EliminateOddNumbers
    {
        //Create a function that takes an array of numbers and returns only the even values.

        public static int[] NoOdds(int[] arr)
        {
            return Array.FindAll(arr, x => x % 2 == 0);

            //int[] answer = new int[arr.Length];
            //int answerIndex = 0; 
            //int index = arr[0];

            //foreach (int i in arr)
            //{
            //    if (index % 2 == 0)
            //    {
            //        answer[answerIndex] = index;
            //        index++;
            //        answerIndex++;
            //    }
            //}
            //return answer;
        }
    }
}
