using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class MergeSortPgm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge Sort");
            int[] arr = { 7, 8, 3, 1, 20, 4 };
            MergeSort(arr);
            PrintSortedArray(arr);
            Console.ReadLine();
        }
        public static void MergeSort(int[] arr)
        {
            int mid = (arr.Length) / 2;
            if (arr.Length < 2)
            {
                return;
            }
            else {
                int[] left = new int[mid];
                int[] right = new int[arr.Length - mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = arr[i];
                }
                for (int i = mid; i < arr.Length; i++)
                {
                    right[i - mid] = arr[i];
                }
                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }
        public static void Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0, j = 0, k = 0;
            int nl = left.Length;
            int rl = right.Length;

            while (i < nl && j < rl)
            {
                if (left[i] < right[j])
                {
                    arr[k] = left[i];
                    i++;
                    k++;
                }
                else if (right[j] < left[i])
                {
                    arr[k] = right[i];
                    j++;
                    k++;
                }
            }
            while (i < nl)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < rl)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }

        public static void PrintSortedArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }

}

