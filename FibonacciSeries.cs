namespace LogicalPractiseProblems
{
    class FibonacciSeries
    {
        public static void GetSeries()
        {
            Console.WriteLine("Question 1 : Fibonacci Series \n");
            Console.Write("Enter a Number this which the series must extend : ");

            try
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (input < 1)
                    throw new Exception();

                Console.WriteLine("");
                var a = 0;
                var b = 0;
                var c = 1;
                while (c < input)
                {
                    a = b;
                    b = c;
                    c = a + b;
                    Console.Write(" {0} .", b);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!! ");
                GetSeries();
            }
        }
    }
}
