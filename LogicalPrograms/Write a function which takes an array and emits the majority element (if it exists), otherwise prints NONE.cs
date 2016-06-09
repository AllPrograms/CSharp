 static void Main(string[] args)
        {
            Console.WriteLine("Write a function which takes an array and emits the majority element (if it exists), otherwise prints NONE .");
            int[] arr = { 1, 1, 7, 0, 2, 3, 4 };//Number which occurs more than n/2 of the size of the element
            Dictionary<int, int> storeElementSize = new Dictionary<int, int>();
            int count = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (storeElementSize.Keys.Contains(arr[i]))
                {
                    int value = storeElementSize[arr[i]];
                    storeElementSize[arr[i]] = value + 1;
                }
                else
                {
                    storeElementSize.Add(arr[i], count);
                }
            }
            int result = storeElementSize.Where(x => x.Value > (arr.Length) / 2).Select(x => x.Key).FirstOrDefault();
            if (result == 0)
            {
                Console.WriteLine("None");
            }
            else {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
