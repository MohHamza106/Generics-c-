using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_c_.Generic
{
    internal class list_of_even
    {
        public int[] even(int[] arr )
        {
            List<int> evenNumbers = new List<int>();
            if (arr != null) 
            {
                for (int i = 0; i < arr.Length; i++)
                { 
                    if( arr[i] %2==0)
                    evenNumbers.Add(arr[i]);
                }
            }
            return evenNumbers.ToArray();
        }
    }
}
