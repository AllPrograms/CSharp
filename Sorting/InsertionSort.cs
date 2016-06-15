using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");
            int[] arr = { 7, 8, 3, 1, 20, 4 };
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
            PrintSortedArray(arr);
            Console.ReadLine();
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

