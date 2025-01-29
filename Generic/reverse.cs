using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_c_.Generic
{
    internal  class reverse1
    {
        //int  [] arr = { };

        //public  int []  reverse( )
        //{
        //    if(arr.Length == 0) return arr;

        //    int[] reversedArr = new int [arr.Length];
        //    for (int i = 0; i < arr.Length; i++)
        //        {
        //             reversedArr[i] = arr[arr.Length - 1 - i];
        //        }
        //    return reversedArr;
        //}
        public void swap(ArrayList arr)
        {
            int i = 0;
            int j = arr.Count - 1;
            int size = arr.Count;
            while (i < j)
            {

                object temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }

        }


    }
}
