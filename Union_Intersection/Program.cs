using System;
using System.Collections.Generic;

namespace Union_Intersection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = {1, 3, 4, 5, 7, 9 };

            int[] arr2 = { 2, 5, 6, 7, 8, 10 };

            var union = GetUnion(arr1, arr2);

            var intersection = GetIntersection(arr1, arr2);

            PrintArray(union);
            PrintArray(intersection);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("\n---------------------\n");
        }

        public static int[] GetUnion(int[] arr1, int[] arr2)
        {
            List<int> union = new List<int>();

            int i = 0;
            int j = 0;

            int m = arr1.Length;
            int n = arr2.Length;


            while(i < m && j < n)
            {

                if(arr1[i] < arr2[j])
                {
                    union.Add(arr1[i++]);
                }else if(arr1[i] > arr2[j])
                {
                    union.Add(arr2[j++]);
                }else
                {
                    union.Add(arr2[j++]);
                    i++;
                }

            }

            while(i < m)
            {
                union.Add(arr1[i++]);
            }

            while(j < n)
            {
                union.Add(arr2[j++]);
            }


            return union.ToArray();

        }

        public static int[] GetIntersection(int[] arr1, int[] arr2)
        {
            List<int> intersection = new List<int>();

            int i = 0;
            int j = 0;

            int m = arr1.Length;
            int n = arr2.Length;


            while (i < m && j < n)
            {

                if (arr1[i] < arr2[j])
                {
                    i++;
                }
                else if (arr1[i] > arr2[j])
                {
                    j++;
                }
                else
                {
                    intersection.Add(arr2[j++]);
                    i++;
                }
            }

            return intersection.ToArray();
        }

    }
}
