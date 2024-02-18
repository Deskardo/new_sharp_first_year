namespace seminar_2
{
    internal class Task2
    {
        public static void Run()
        {
            Console.WriteLine("Введите число");
            var num = byte.Parse(Console.ReadLine());
            var count = 0;
            while (num > 0)
            {
                if (num % 2 == 1)
                    count++;
                num /= 2;
            }

            Console.WriteLine(count);
        }
    }
}
