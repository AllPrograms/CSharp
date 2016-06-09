 static void Main(string[] args)
        {
            Console.WriteLine("Replace every element with the greatest element on right side.");
            int[] arr = { 16, 17, 4, 3, 5, 7, 2 };
            arr= ReplaceElement(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

        static int[] ReplaceElement(int[] arr)
        {
            int maxElement = arr[arr.Length - 1];
            arr[arr.Length - 1] = -1;
            for (int i = arr.Length-2; i >= 0; i--)
            {
                int temp = arr[i];
                arr[i] = maxElement;
                if(maxElement<temp)
                {
                    maxElement =temp ;
                }
            }
            return arr;
        }
       