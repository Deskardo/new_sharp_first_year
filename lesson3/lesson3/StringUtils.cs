using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public static class StringUtils
    {
        static StringUtils()
        {
            Console.WriteLine("Конструктор вызван");
        }
        public static string Reverse(this string s)
        {
            return new String(s.ToCharArray().Reverse().ToArray());
        }
    }
}
