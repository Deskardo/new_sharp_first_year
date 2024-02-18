namespace seminar_2
{
    internal class Task1
    {
        public void Run()
        {
            var count = 0;
            for (var i = 0; i <= 1000; i += 3)
            {
                count+= 1;
            }
            Console.WriteLine(count);
        }
    }
}
