namespace seminar_2
{
    internal class Task3
    {
        private static int[] RandomArray(int size)
        {
            var arr = new int[size];
            var rand = new Random();
            for (var i = 0; i < size; i++)
            {
                arr[i] = rand.Next(size);
            }

            return arr;
        }

        public static void Run()
        {
            var arr = RandomArray(10);
            var arr2 = RandomArray(20);
            var arr3 = new int[arr.Length + arr2.Length];

            for (var i = 0; i < arr3.Length; i++)
            {
                if (i <= arr2.Length - 1)
                {
                    arr3[i] = arr2[i];
                }
                else
                {
                    arr3[i] = arr[i-arr2.Length];
                }
                    
            }

            Array.Sort(arr3);
            foreach (var i in arr3)
            {
                Console.WriteLine(i);
            }

        }
    }
}
