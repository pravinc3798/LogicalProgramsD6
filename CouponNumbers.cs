namespace LogicalPractiseProblems
{
    class CouponNumbers
    {
        public static void GenerateRandomCoupons()
        {
            Console.WriteLine("Question 5 : How many random numbers are needed to be generated for N distinct coupon numbers \n");
            
            try
            {
                Console.Write("Enter How many coupons are required : ");
                var num = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coupon numbers start point : ");
                var start = Convert.ToInt32(Console.ReadLine());

                Console.Write("Coupon numbers end point : ");
                var end = Convert.ToInt32(Console.ReadLine());

                if (start < 1 || end < 1 || num < 1)
                    throw new Exception();

                var distinctnums = new List<int>();

                var random = new Random();
                distinctnums.Add(random.Next(start, end));

                var count = 1;

                while (distinctnums.Count < num)
                {
                    var chknum = random.Next(start, end);
                    foreach (var item in distinctnums)
                    {
                        if (chknum == item)
                            chknum = 0;
                    }
                    if (chknum != 0)
                        distinctnums.Add(chknum);
                    count++;
                }
                Console.WriteLine("\nCoupon Numbers are : {0}", String.Join(",",distinctnums));
                Console.WriteLine("\n\n >>>> {0} random generations were required for {1} unique coupon numbers between {2} and {3}.", count, num,start,end);
            }
            catch (Exception)
            {
                Console.WriteLine("\n !!!! INVALID INPUT !!!! ");
                GenerateRandomCoupons();
            }
        }

    }
}
