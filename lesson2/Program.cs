using System.Text;

namespace lesson2
{
    /*    enum Colors:byte // enumerate нумерация значений
        {
            Red,
            Green,
            White=11
        }
    */

/*    [Flags]
    enum Colors : byte // enumerate нумерация значений
    {
        Red = 0,
        Green = 1,
        White = 2,
        Black = 4,
        BlackAndWhite = 6
    }*/

/*    struct Point
    {
        public float x;
        public float y;
    }*/
    internal class Program
    {

/*        static int Fibonacci(int n)
        {
            int[] numbers = new int[n];
            numbers[0] = 1;
            numbers[1] = 1;

            for (int i = 2; i < n; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2];               
            }
            return numbers[n - 1];

            */
/*            if (n == 1) return 1;
                        if (n == 2) return 1;

                        return Fibonacci(n - 1) + Fibonacci(n - 2);*//*
        }*/
/*        class SomeClass
        {
            public int SomeVariable;
        }*/
        static void Main(string[] args)
        {
            /*            int a = 10;
                        int b = a;
                        a = 20;
                        Console.WriteLine($"a={a}, b={b}");*/

            /*            SomeClass a = new SomeClass();
                        a.SomeVariable = 10;

                        SomeClass b = a;
                        a.SomeVariable = 20;

                        Console.WriteLine($"a={a.SomeVariable}, b={b.SomeVariable}");*/

            /*            Console.WriteLine($"red={(int)Colors.Red}");
                        Console.WriteLine($"green={(int)Colors.Green}");
                        Console.WriteLine($"white={(int)Colors.White}");*/

            /*            Colors blackAndWhite = Colors.Black | Colors.White;
                        Console.WriteLine(blackAndWhite);*/

            /*            Point point = new Point();
                        Console.WriteLine($"{point.x}, {point.y}");*/

            /*(int, string) t = (1, "Maxim"); // Кортеж
            Console.WriteLine(t.Item2);*/
            /*            (int, int, int) triple = (1, 2, 3); // не именованный кортеж
                        (int a, int b, int c) triple1 = (1, 2, 3); // именованный кортеж

                        Console.WriteLine($"{triple == triple1}"); // вывод True, несмотря на разную форму кортежей они равны

                        int? a = null; // налэбл переменные, позволяют устанавливать в качестве значения по умолчанию null*/

            /*            byte b = 20;
                        int a = 10; // C# позволяет не явно приводить значение к типу, если тип значения содержится в приводимом типе

                        a = b;*/

            /*            object obj = null;
                        obj = 1; // упаковка Int в object
                        int i = (int)obj; // распаковка в int

                        Console.WriteLine(i);*/

            /*            string a = "123";
                        a = a + "4";*/

            /*            string s1 = "aaa";
                        string s2 = "AAA";

                        Console.WriteLine(s1.CompareTo(s2));*/

            /*            int i = 10;
                        string s = "string";

                        string template = "{0} {1}";

                        string result = String.Format(template, i, s);

                        Console.WriteLine(result);*/

            /*            string s1 = "1234567890";

                        StringBuilder sb = new StringBuilder();

                        for(int i = 0; i < s1.Length; i += 2)
                        {
                            sb.Append(s1[i]);
                        }

                        Console.WriteLine(sb.ToString());*/

            /*            int[] arr = new int[5];
                        int[,] arr1 = new int[5, 5];
                        int[][] arr2 = new int[5][];

                        for(int i = 0; i < arr.Length; i++)
                            Console.WriteLine(arr[i] + " ");
                        Console.WriteLine();

                        for (int i = 0; i < arr1.GetLength(0); i++)
                        {
                            for(int j = 0; j < arr1.GetLength(1); j++)
                                Console.WriteLine(arr1[i, j] + " ");
                            Console.WriteLine();
                        }
                        Console.WriteLine();


                        for (int i = 0; i < arr2.Length; i++)
                        {
                            arr2[i] = new int[i];
                        }

                        for (int i = 0; i < arr2.Length; i++)
                        {
                            for (int j = 0; j < arr2[i].Length; j++)
                                Console.WriteLine(arr2[i][j] + " ");
                            Console.WriteLine();
                        }
                        Console.WriteLine();*/

            /*            int[] arr = { 1, 2, 3, 4 };
                        arr[^1] = 0;

                        foreach (int i in arr)
                        {
                            Console.Write(i + " ");
                        }*/

            // Console.WriteLine(Fibonacci(30));
/*
            int[] arr = { 1, 2, 3, 4, 5, 6, 1, 2, 3, 5 };
            int[] arr1 = new int[arr.Length];

            Array.Copy(arr, arr1, arr.Length);

            Array.Sort(arr);

            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            foreach (int i in arr1)
            {
                Console.Write(i + " ");
            }*/

            
        }
    }
}
