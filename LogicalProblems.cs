using System;

namespace LogicalPractiseProblems
{
    class LogicalProblems
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(" 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n 4. REVERSE \n 5. Random Number \n 6. Stop Watch\n");
            Console.Write("Input a number corresponding to desired program : ");

            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1: FibonacciSeries.GetSeries(); break;
                case 2: PerfectNumber.CheckPerfect(); break;
                case 3: PrimeNumber.CheckPrime(); break;
                case 4: Reversion.GetReversed(); break;
                case 5: CouponNumbers.GenerateRandomCoupons(); break;
                case 6: StopWatch.StartStop(); break;
                default: Console.WriteLine("INVALID INPUT!!"); break;
            }
        }
    }
}
