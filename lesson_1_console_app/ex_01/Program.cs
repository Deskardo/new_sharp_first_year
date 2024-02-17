using System.Diagnostics.CodeAnalysis;

namespace ex_01
/*    модифицировать программу-калькулятор таким образом, чтобы она проверяла количество введенных аргументов и, в случае если оно равно 2, 
    выводила в консоль результат их сложения; если же количество аргументов отличается, выводила инструкцию по использованию программы.*/
{
    internal class Program
    {

        public static void Calc(string[] args)
        {
            int sum = 0;
            if (args.Length != null)
            {
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        sum += num;
                    }
                }
                Console.WriteLine(sum);
            }
        }

        public static void Average(string[] args)
        {
            int sum = 0;
            int count = 0;
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        sum += num;
                        count += 1;
                    }
                }
                if (count == 0) 
                {
                    Console.WriteLine("На ноль делить нельзя");
                }
                else
                {
                    Console.WriteLine($"Среднее арифметическое: {sum / count}");
                }
                
            }
            else
            {
                Console.WriteLine("Вы забыли добавить числа");
            }
        }

        public static void MinValue(string[] args)
        {
            int min = int.MaxValue;
            if (args.Length > 0)
            {
                foreach (string arg in args)
                {
                    if (int.TryParse(arg, out int num))
                    {
                        if (num < min)
                        {
                            min = num;
                        }
                    }
                }
                    Console.WriteLine($"Минимальное значение: {min}");
            }
        }

        static void Main(string[] args)
        {
            /*if (args.Length == 2)
            {
                if (int.TryParse(args[0], out int num1) && int.TryParse(args[0], out int num2))
                {
                    int sum = num1 + num2;
                    Console.WriteLine($"Сумма введенных чисел = {sum}");
                }
                else
                {
                    Console.WriteLine("Ошибка значение должно быть числом");
                }
            }
            else
            {
                Console.WriteLine("Введите два числа");
            }*/

            // Calc(args);

            // Average(args);

            MinValue(args);
        }
    }
}
