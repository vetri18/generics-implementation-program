using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximumProblem
{
    public class MaximumInt
    {
        int first_Number, second_Number, third_Number;
        public void GetInput()                      //Input for 3 numbers
        {
            Console.Write("Enter First Number = ");
            first_Number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number = ");
            second_Number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number = ");
            third_Number = Convert.ToInt32(Console.ReadLine());
        }
        public void Compare()                        //comparing between numbers
        {
            if (first_Number.CompareTo(second_Number) >= 0 && first_Number.CompareTo(third_Number) >= 0)
                Console.WriteLine("Greatest Number is = " + first_Number);
            else if (second_Number.CompareTo(first_Number) >= 0 && second_Number.CompareTo(third_Number) >= 0)
                Console.WriteLine("Greatest Number is = " + second_Number);
            else if (third_Number.CompareTo(second_Number) >= 0 && third_Number.CompareTo(first_Number) >= 0)
                Console.WriteLine("Greatest Number is = " + third_Number);
            else
                Console.WriteLine("Greatest Number is = " + first_Number);
        }

    }
}