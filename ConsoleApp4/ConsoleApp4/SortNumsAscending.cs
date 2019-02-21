using System.Linq;
public class Program
{
    //Create a function that takes an array of numbers and returns 
    //a new array, sorted in ascending order(smallest to biggest)
    //Sort numbers array in ascending order.
    //If functions argument is null, an empty array or undefined, return an empty array.
    //Return new array of sorted numbers.

    public static int[] SortNumsAscending(int[] arr)
    {
        //sort the int array
        Array.Sort<int>(arr);
        return arr;
    }
}