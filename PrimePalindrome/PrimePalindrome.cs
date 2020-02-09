using System;

namespace PrimePalindrome
{
    class PrimePalindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primePalindrome(10000));
        }

        static bool isPrime(int num)
        {
            if(num<2 || num % 2 == 0)
            {
                return num == 2;
            }

            for(int i = 3; i*i<= num; i += 2)
            {
                if(num%i == 0)
                {
                    return false;
                }
            }

            return true;

        }

        static int primePalindrome(int N)
        {
            if(8<=N && N <= 11)
            {
                return 11;
            }

            for( int x = 1; x < 100000; ++x)
            {
                string s = x.ToString();
                char[] buffer = s.ToCharArray();
                Array.Reverse(buffer);

                var tmp = new string(buffer).Substring(1);
                int y = Int32.Parse(s + tmp);

                if(y >=N && isPrime(y) == true)
                {
                    return y;
                }

            }

            return -1;
        }

    }
}
