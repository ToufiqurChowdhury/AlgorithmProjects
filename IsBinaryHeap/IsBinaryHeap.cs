using System;

namespace IsBinaryHeap
{
    class IsBinaryHeap
    {
        public static void Main(string[] args)
        {
            int[] arr = { 14, 15, 10, 7, 12, 2, 7, 3 };

            int n = arr.Length - 1;

            if (isHeap(arr, 0, n))
            {

                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }

        static bool isHeap(int[] arr, int i, int n)
        {

            if(i > (n - 2) / 2)
            {
                return true;
            }

            if(arr[i] >= arr[2*i+1] && arr[i] >= arr[2*i + 2] && isHeap(arr, 2*1+1, n) && isHeap(arr, 2*2+1, n))
            {
                return true;
            }

            return false;
        }
    }
}
