namespace GenericsMaximumProblem
{
    class ProgramUC5
    {
        public static void Main()
        {
            PrintMaximumUC5 printMaximumUC5 = new PrintMaximumUC5();

            //Calling Generic Method for Integer value
            Console.Write("Enter First Integer Value = ");
            int first_Int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Integer  Value = ");
            int second_Int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Integer Value = ");
            int third_Int = Convert.ToInt32(Console.ReadLine());
            printMaximumUC5.TestMaximum(first_Int, second_Int, third_Int);

            //Calling Generic Method for Float Value
            Console.Write("Enter First Decimal Value = ");
            float first_Float = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Decimal Value = ");
            float second_Float = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Decimal Value = ");
            float third_Float = Convert.ToInt32(Console.ReadLine());
            printMaximumUC5.TestMaximum(first_Float, second_Float, third_Float);

            //Calling Generic Method for String Value
            Console.Write("Enter First Word = ");
            string first_Value = Console.ReadLine();
            Console.Write("Enter Second Word = ");
            string second_Value = Console.ReadLine();
            Console.Write("Enter Third Word = ");
            string third_Value = Console.ReadLine();
            printMaximumUC5.TestMaximum(first_Value, second_Value, third_Value);
        }
    }
}