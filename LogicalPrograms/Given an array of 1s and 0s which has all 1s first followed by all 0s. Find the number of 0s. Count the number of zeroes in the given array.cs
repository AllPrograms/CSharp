  static void Main(string[] args)
        {
            Console.WriteLine("Given an array of 1s and 0s which has all 1s first followed by all 0s. Find the number of 0s. Count the number of zeroes in the given array.");
            int[] arr = { 0, 0, 1, 1, 1 };
            findZeros(arr);
            Console.ReadLine();
        }
        public static void findZeros(int[] arr)
        {
            int low = 0;
            int n = arr.Length;
            int high = (low + (n - 1));
            int r = findZerosBySearch(arr, n, low, high, 0);
            Console.WriteLine(r);
        }
        static int findZerosBySearch(int[] arr, int n, int low, int high, int count)
        {
            int mid = 0;
            if(arr[low]==0 && arr[high]==0)
            {
                return n;
            }
            while (low <= high)
            {
                mid = (low + high) / 2;
                if (arr[mid] == 1 && arr[mid + 1] == 1)
                {
                    high = high - 1;
                }
                else if (arr[mid] == 0 && arr[mid + 1] == 1)
                {
                    high = mid;
                    count++;
                }
                else if (arr[mid] == 0 && arr[mid + 1] == 0)
                {
                    high = high - 1;
                    low = low + 1;
                    count++;
                }
               
            }
            return count;

        }