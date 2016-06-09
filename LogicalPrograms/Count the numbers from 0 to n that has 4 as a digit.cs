 static void Main(string[] args)
        {
            Console.WriteLine("Count the numbers from 0 to n that has 4 as a digit");
            int n = Convert.ToInt32(Console.ReadLine());
            checkIfContainsFour(n);
            Console.ReadLine();
        }
        static void checkIfContainsFour(int n)
        {
            List<int> outPut = new List<int>();
            int count = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i.ToString().Contains("4"))
                {
                    var splitToChar = i.ToString();
                    for (int j = 0; j < splitToChar.Length; j++)
                    {
                        if (splitToChar[j] == '4')
                        {
                            count++;
                        }
                    }
                    outPut.Add(i);

                }
            }
            Console.WriteLine("The total Fours between given number is {0}", count);
            Console.WriteLine("The elements are");
            foreach (var item in outPut)
            {
                Console.WriteLine(item);
            }
        }