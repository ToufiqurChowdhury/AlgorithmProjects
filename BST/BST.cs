using System;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BST!");

            int[] arr = { 8, 9, 10, 11, 12, 14, 15, 16 };

            Console.WriteLine(BinarySearch(arr, 12));


        }

        public static bool BinarySearch(int[] array, int x)
        {
            //return BinarySearchRecursive(array, x, 0, array.Length - 1);
            return BinarySearchIterative(array, x);
        }

        public static bool BinarySearchRecursive(int[] array, int x, int left, int right)
        {
            if(left > right)
            {
                return false;
            }

            int mid = left + (( right - left) / 2);

            if(array[mid] == x)
            {
                return true;

            }else if( x < array[mid])
            {
                return BinarySearchRecursive(array, x, left, mid - 1);
            }
            else
            {
                return BinarySearchRecursive(array, x, mid + 1, right);
            }

        }

        public static bool BinarySearchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if(array[mid] == x)
                {
                    return true;
                }
                else if (x < array[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return false;
        }

    }
}
