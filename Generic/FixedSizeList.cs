using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_c_.Generic
{
    internal class FixedSizeList<T>
    {
        public T  [] list;
        public int index=0;
        public int size;
        public FixedSizeList( int size) 
        {
            list = new T [size];
            index = 0;
            this.size = size;

        }
        public bool add(T value) 
        {
            if (list != null && index < size)
            {
                list[index] = value;
                index++;
                return true;
            }
            else
            { 
                return false;
            }            
        }
         public T Get(int Index)
         {
            if (Index < 0 || Index >= index)  
            {
                Console.WriteLine("Index is out of range.");
                
            }
            return list[Index];      
         }
    }
}
