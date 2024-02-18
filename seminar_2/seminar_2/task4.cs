using System.Text;

namespace seminar_2
{
    internal class Task4
    {
        public static void Run(string s)
        {
            var sb = new StringBuilder("");
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                {
                    sb.Append(item);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
