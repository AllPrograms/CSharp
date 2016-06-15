using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selection Sort");
            int[] arr = { 7, 8, 3, 1, 20, 4 };
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = 0;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
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

