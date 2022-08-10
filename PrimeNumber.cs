namespace LogicalPractiseProblems
{
    class PrimeNumber
    {
        public static void CheckPrime()
        {
            Console.WriteLine("Question 3 : Prime Number check \n");
            Console.Write("Enter a Number : ");

            try
            {
                var input = Convert.ToInt32(Console.ReadLine());
                var result = string.Format(" >>>> {0} is a PRIME number !",input);

                if (input < 1)
                    throw new Exception();

                for (var i = 2; i < input/2; i++)
                {
                    if (input % i == 0)
                        result = string.Format(">>>> {0} is NOT a prime number", input); break;
                }
                Console.WriteLine("\n {0}",result);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!! ");
                CheckPrime();
            }
        }
    }
}
