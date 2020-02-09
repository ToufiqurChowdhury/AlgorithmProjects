using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            //int[] arr = { 10, 80, 30, 90, 40, 50, 70 };
            //PrintArray(arr);

            int[] arr = { 10, 7, 8, 9, 1,5};
            PrintArray(arr);

            DoQuickSort(arr, 0, arr.Length - 1);
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\n---------------------\n");
        }

        public static void DoQuickSort(int[] arr, int low, int high)
        {
            if(low < high)
            {
                int pi = Partition(arr, low, high);

                DoQuickSort(arr, low, pi - 1);
                DoQuickSort(arr, pi + 1, high);

            }

        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            //index of the smaller element
            int i = low-1;

            for(int j = low ; j <= high -1; j++)
            {
                // If current is smaller than pivot
                if(arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }

            swap(arr, i + 1, high);

            return i + 1;

        }

        public static void swap(int[] arr, int i, int j)
        {
            int tmp = arr[i];
            arr[i] = arr[j];
            arr[j] = tmp;

        }


    }
}
