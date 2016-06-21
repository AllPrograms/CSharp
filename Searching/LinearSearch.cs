using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGitHubPgm
{
    class LinearSearchPgm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linear Search");
            int[] arr = { 8, 6, 77, 1, 5, 9, 0 };
            PrintArray(arr);
            Console.WriteLine("Enter the element to search");
            int search = Convert.ToInt32(Console.ReadLine());
            int result = LinearSearch(arr,search);
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
        public static int LinearSearch(int[] arr,int search)
        {
            int result = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==search)
                {
                    result = i;
                    break;
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

