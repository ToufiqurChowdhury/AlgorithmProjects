using System;

namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Climbing Stairs");

            var climb = climbStairs(5);

            Console.WriteLine(climb.ToString());
        }

        // Dynamic programming by Bottom Up approach

        public static int climbStairs(int n)
        {
            int[] dp = new int[n + 1];

            dp[0] = 1;
            dp[1] = 1;
            
            for(int i=2; i<=n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        public static int fibonacci(int n)
        {
            if(n==0 || n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 2) + fibonacci(n - 1);
            }
        }
    }
}
