using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximumProblem
{
    public class PrintMaximumUC5
    {
        public void TestMaximum<T>(T first_Value, T second_Value, T third_Value) where T : IComparable
        {
            if (first_Value.CompareTo(second_Value) >= 0 && first_Value.CompareTo(third_Value) >= 0)
                PrintMax<T>(first_Value);
            else if (second_Value.CompareTo(first_Value) >= 0 && second_Value.CompareTo(third_Value) >= 0)
                PrintMax<T>(second_Value);
            else if (third_Value.CompareTo(second_Value) >= 0 && third_Value.CompareTo(first_Value) >= 0)
                PrintMax<T>(second_Value);
            else
                Console.WriteLine("Greatest Word is = " + first_Value);
        }
        public void PrintMax<T>(T max)
        {
            Console.WriteLine("Greatest Value is = " + max);
        }
    }
}