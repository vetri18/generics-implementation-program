using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximumProblem
{
    public class MaxGenericRefactor1
    {
        public void Compare<T>(T first_Value, T second_Value, T third_Value) where T : IComparable
        {
            if (first_Value.CompareTo(second_Value) >= 0 && first_Value.CompareTo(third_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + first_Value);
            else if (second_Value.CompareTo(first_Value) >= 0 && second_Value.CompareTo(third_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + second_Value);
            else if (third_Value.CompareTo(second_Value) >= 0 && third_Value.CompareTo(first_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + third_Value);
            else
                Console.WriteLine("Greatest Word is = " + first_Value);
        }

    }
}