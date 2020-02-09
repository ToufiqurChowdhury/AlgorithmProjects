using System;

namespace SortArrayByParity
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 2, 4 };

            var res = SortArrayByParity(A);

            PrintArray(res);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\n---------------------\n");
        }

        //
        static int[] SortArrayByParity(int[] A) {

            int first = 0;
            int last = A.Length - 1;

            while(first < last)
            {
                //First odd
                if(A[first] % 2 != 0)
                {
                    //Last even
                    if(A[last] %2 == 0)
                    {
                        swap(A, first, last);

                        first++;
                        last--;
                    }
                    else //Last odd
                    {
                        last--;
                    }
                }
                else //Last even
                {
                    first++;
                }

            }

            return A;
        }


        public static void swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;

        }

    }
}
