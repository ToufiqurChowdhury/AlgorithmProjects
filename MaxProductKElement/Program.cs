using System;

namespace MaxProductKElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max Product K Element!");

            //int[] nums = { 11, 3, 5, 7, 1, 4, 2, 8, 6, 9 };
            int[] nums = { -11, -9, -6, -4, -3, 1, 4, 5, 6, 7, 8 };

            var prod = MaxProduct(nums, 3);

            Console.WriteLine(prod);

        }

        public static int MaxProduct(int[] nums, int k)
        {

            int result = 1;


            Array.Sort(nums);

            var right = nums.Length - 1;
            var left = 0;

            for (int i = 0; i < k; i++)
            {
                // Even Case
                if (k % 2 == 0) 
                {
                    if (Math.Abs(nums[left]) < nums[right])
                    {
                        result *= nums[right--];
                    }
                    else
                    {
                        result *= nums[left++];
                    }

                }
                else // Odd case
                {
                    // Last digit need to be positive
                    if (i == (k - 1))
                    {
                        result *= nums[right--];
                    }
                    else if (Math.Abs(nums[(left - i) + (k - 2)]) > nums[(right + i) - (k - 2)])
                    {
                        result *= nums[left++];
                    }                     
                
                }


            }


            return result;
        }

    }
}
