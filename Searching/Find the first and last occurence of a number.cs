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
            Console.WriteLine("Find the first and last occurence of a number");
            int[] arr = { 1, 1, 1, 1, 4 };
            PrintArray(arr);
            Console.WriteLine("Enter the element to search");
            int search = Convert.ToInt32(Console.ReadLine());
            int start = BinarySearch(arr, search, "start");
            int end = BinarySearch(arr, search, "end");
            if (start != -1 && end != -1)
            {
                Console.WriteLine("Element starting pos  {0} and element end pos {1}", start, end);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] arr, int search, string order)
        {
            int low = 0;
            int high = arr.Length - 1;
            int result = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;

                if (arr[mid] == search)
                {
                    if (order == "start")
                    {
                        result = mid;
                        high = mid - 1;
                    }
                    else
                    {

                        result = mid;
                        low = mid + 1;
                    }
                }
                else if (search > arr[mid])
                {
                    low = mid + 1;
                }
                else if (search < arr[mid])
                {
                    high = mid - 1;
                }
            }
            return result;
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

