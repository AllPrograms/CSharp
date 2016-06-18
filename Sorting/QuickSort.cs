using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class QuickSortPgm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quick Sort");
            int[] arr = { 9, 6, 5, 0, 8, 2, 4, 7 };
            QuickSort(arr, 0, arr.Length);
            PrintSortedArray(arr);
            Console.ReadLine();
        }
        public static void QuickSort(int[] arr, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(arr, p, r);
                QuickSort(arr, p, q - 1);
                QuickSort(arr, q + 1, r);
            }
        }
        public static int Partition(int[] arr, int p, int q)
        {
            q = (q == arr.Length) ? q - 1 : q;
            int x = arr[q];
            int i = p - 1;
            for (int j = p; j <= q; j++)
            {
                if (arr[j] < x)
                {
                    i = i + 1;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            i = i + 1;
            int temp1 = arr[i];
            arr[i] = x;
            arr[q] = temp1;
            return i;
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

