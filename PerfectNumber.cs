namespace LogicalPractiseProblems
{
    class PerfectNumber
    {
        public static void CheckPerfect()
        {
            Console.WriteLine("Question 2 : Check Whether the number is Perfect or Not \n");
            Console.Write("Enter a number : ");

            try
            {
                var input = Convert.ToInt32(Console.ReadLine());

                if (input < 1)
                    throw new Exception();

                var divisors = new List<int>();
                for (var i = 1; i < input/2; i++)
                {
                    if (input%i == 0)
                        divisors.Add(i);
                }
                var sum = 0;
                foreach (var div in divisors)
                    sum += div;

                var result = (sum == input/2) ? string.Format("{0} is a PERFECT number", input) : string.Format("{0} is NOT a PERFECT number", input);

                Console.WriteLine("\n >>>> {0} as the sum of divisors is : {1}",result,sum*2);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!! ");
                CheckPerfect();
            }
        }

    }
}
