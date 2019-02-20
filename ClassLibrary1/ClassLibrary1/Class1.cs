using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static object GetLastItem(object[] arr)
        {
            int length = arr.Length;
            object LastItem = arr[length - 1];
            return LastItem;
        }
    }
}
