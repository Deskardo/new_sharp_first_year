using System.Text;

namespace seminar_2
{
    internal class Task5
    {
        public static void Run()
        {
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            var temp = 0;

            for (var i = 0; i < a.GetLength(0); i++)
            {
                for (var j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
