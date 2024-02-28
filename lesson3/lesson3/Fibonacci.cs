using lesson3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class Fibonacci
    {
        public int Value { get; private set; } = 1;
        private int valuePrev = 0;

        public static Fibonacci operator ++(Fibonacci f)
        {
            var temp = f.Value;
            f.Value = f.Value + f.valuePrev;
            f.valuePrev = temp;
            return f;
        }

        public static Fibonacci operator +(Fibonacci f, int count)
        {
            for (int i = 0; i < count; i++)
            {
                f++;
            }

            return f;
        } 

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}

/*var a = new Fibonacci() + 8;

Console.WriteLine(a);*/

/*            for (int i = 0; i <= 8; i++)
            {
                Console.Write($"{a} ");
                a++;
            }*/
