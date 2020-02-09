using System;

namespace MergeSort
{
    class MergeSort
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };

            Console.WriteLine("Given Array");
            PrintArray(arr);

            MergeSortRecursive(arr, 0, arr.Length-1);

            Console.WriteLine("Sorted Array");
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\n---------------------\n");
        }

        public static void MergeSortRecursive(int[] arr, int l, int r)
        {

            if (l < r)
            {
                var mid = (l + (r-1)) / 2;

                MergeSortRecursive(arr, l, mid);
                MergeSortRecursive(arr, mid+1, r);

                MergeArrays(arr, l, mid, r);
            }
        }

        public static void MergeArrays(int[] arr, int l, int m, int r)
        {
            int i, j, k;

            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for(i =0; i<n1; i++)
            {
                L[i] = arr[l + i];
            }

            for(j=0; j<n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;

            k = l;   // Initial index of marged subarray to low or l
            while(i < n1 && j < n2)
            {
                if(L[i]< R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }

                k++;
            }

            while(i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while(j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }

        }

    }
}
