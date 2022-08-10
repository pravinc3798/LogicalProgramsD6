namespace LogicalPractiseProblems
{
    class StopWatch
    {
        public static void StartStop()
        {
            Console.WriteLine("Question 6 : Stopwatch Program \n");
            Console.WriteLine("\n >>>> Press Enter to START <<<<");

            Console.ReadLine();
            var start = DateTime.Now;

            Console.WriteLine("\n >>>> Press Enter to Stop <<<<");
            Console.ReadLine();

            var end = DateTime.Now;

            var timeElapsed = end - start;

            Console.WriteLine("Time Elapsed : {0} Minutes and {1} Seconds and {2} Milliseconds", timeElapsed.Minutes, timeElapsed.Seconds, timeElapsed.Milliseconds);
        }
    }
}
