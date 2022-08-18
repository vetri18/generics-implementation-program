namespace GenericsMaximumProblem
{
    class ProgramUC4
    {
        public static void Main()
        {
            ExtendMaxUC4 extendMaxUC4 = new ExtendMaxUC4();

            //Calling Generic Method for Integer value
            Console.Write("Enter First Integer Value = ");
            int first_Int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Integer  Value = ");
            int second_Int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Integer Value = ");
            int third_Int = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fourth Integer Value = ");
            int fourth_Int = Convert.ToInt32(Console.ReadLine());
            extendMaxUC4.TestMaximum<int>(first_Int, second_Int, third_Int, fourth_Int);

            //Calling Generic Method for Float Value
            Console.Write("Enter First Decimal Value = ");
            float first_Float = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Decimal Value = ");
            float second_Float = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Decimal Value = ");
            float third_Float = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Fourth Decimal Value = ");
            float fourth_Float = Convert.ToInt32(Console.ReadLine());
            extendMaxUC4.TestMaximum<float>(first_Float, second_Float, third_Float, fourth_Float);

            //Calling Generic Method for String Value
            Console.Write("Enter First Word = ");
            string first_Value = Console.ReadLine();
            Console.Write("Enter Second Word = ");
            string second_Value = Console.ReadLine();
            Console.Write("Enter Third Word = ");
            string third_Value = Console.ReadLine();
            Console.Write("Enter Fourth Word = ");
            string fourth_Value = Console.ReadLine();
            extendMaxUC4.TestMaximum<string>(first_Value, second_Value, third_Value, fourth_Value);
        }
    }
}