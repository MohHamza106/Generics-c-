using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Generics_c_.Generic
{
    internal class Range<T> where T:IComparable<T>, INumber<T>
    {
        public T minimum { get; set; }
        public T maximum { get; set; }
        public Range(T minimum, T maximum)
        {
            this.minimum = minimum;
            this.maximum = maximum;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo (minimum) >= 0 && value.CompareTo(maximum) <= 0;
        }
        public T Length()
        {
            return maximum -minimum; 
        }


    }
}
