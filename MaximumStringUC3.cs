using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaximumProblem
{
    public class MaximumStringUC3
    {
        string first_String, second_String, third_String;
        public void GetInput()                      //Input for 3 numbers
        {
            Console.Write("Enter First String = ");
            first_String = Console.ReadLine();
            Console.Write("Enter Second String = ");
            second_String = Console.ReadLine();
            Console.Write("Enter Third String = ");
            third_String = Console.ReadLine();
        }
        public void Compare()                        //comparing between numbers
        {
            if (first_String.CompareTo(second_String) >= 0 && first_String.CompareTo(third_String) >= 0)
                Console.WriteLine("Greatest String is = " + first_String);
            else if (second_String.CompareTo(first_String) >= 0 && second_String.CompareTo(third_String) >= 0)
                Console.WriteLine("Greatest String is = " + second_String);
            else if (third_String.CompareTo(second_String) >= 0 && third_String.CompareTo(first_String) >= 0)
                Console.WriteLine("Greatest String is = " + third_String);
            else
                Console.WriteLine("Greatest String is = " + first_String);
        }

    }
}