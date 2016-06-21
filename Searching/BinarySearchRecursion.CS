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
            Console.WriteLine("Binary Search using Recursion");
            int[] arr = { 1, 2, 3, 4, 6, 9, 23 };
            PrintArray(arr);
            Console.WriteLine("Enter the element to search");
            int search = Convert.ToInt32(Console.ReadLine());
            int low = 0;
            int high = arr.Length - 1;
            int result = BinarySearch(arr, low, high, search);
            if (result != -1)
            {
                Console.WriteLine("Element found at pos {0}", result + 1);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] arr, int low, int high, int search)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = (low + high) / 2;
            if (search == arr[mid])
            {
                return mid;
            }
            else if (search < arr[mid])
            {

              return  BinarySearch(arr, mid - 1, high, search);
            }
            else if (search > arr[mid])
            {
               return BinarySearch(arr, mid + 1, high, search);
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

