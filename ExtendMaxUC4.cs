using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximumProblem
{
    public class ExtendMaxUC4
    {
        public void TestMaximum<T>(T first_Value, T second_Value, T third_Value, T fourth_Value) where T : IComparable
        {
            if (first_Value.CompareTo(second_Value) >= 0 && first_Value.CompareTo(third_Value) >= 0 && first_Value.CompareTo(fourth_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + first_Value);
            else if (second_Value.CompareTo(first_Value) >= 0 && second_Value.CompareTo(third_Value) >= 0 && second_Value.CompareTo(fourth_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + second_Value);
            else if (third_Value.CompareTo(second_Value) >= 0 && third_Value.CompareTo(first_Value) >= 0 && third_Value.CompareTo(fourth_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + third_Value);
            else if (fourth_Value.CompareTo(second_Value) >= 0 && fourth_Value.CompareTo(first_Value) >= 0 && fourth_Value.CompareTo(third_Value) >= 0)
                Console.WriteLine("Greatest Value is = " + fourth_Value);
            else
                Console.WriteLine("Greatest Word is = " + first_Value);
        }

    }
}