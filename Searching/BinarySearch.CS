using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class BinarySearchPgm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search");
            int[] arr = { 1, 2, 3, 4, 6, 9, 23 };
            PrintArray(arr);
            Console.WriteLine("Enter the element to search");
            int search = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(arr, search);
            if (result != -1)
            {
                Console.WriteLine("Element found at pos {0}", result+1);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] arr, int search)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (search == arr[mid])
                {
                    return mid;
                }
                else if (search < arr[mid])
                {
                    high = mid - 1;
                }
                else if (search > arr[mid])
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        public static void PrintArray(int[] arr)
        {
            Console.WriteLine("The Array is");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }

}

