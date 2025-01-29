using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Generics_c_.Generic
{
    internal class non_repeated
    {
        public void nonrepeated(string  value) 
        {
            if (value == null)
            {
                Console.WriteLine("Input string cannot be null or empty.");
                return ;

            }
            else 
            { 
                Dictionary<char,int > dict = new Dictionary<char,int>();
                for (int i = 0; i < value.Length; i++) 
                {
                    if (!dict.ContainsKey(value[i])) dict.Add(value[i], 1);
                    else dict[value[i]]++;
                }
                bool flage = false;
                foreach (char c in value)
                {
                    if (dict[c] == 1)
                    {
                        Console.WriteLine($"the Character is {c}");
                        flage = true;
                        return;
                    }
                }
                if (!flage)
                    Console.WriteLine("No non-repeated character found");
            
            }
        }
    }
}
