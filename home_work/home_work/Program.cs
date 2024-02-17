namespace home_work
{
    internal class Program
    {
        public static void Calc(string[] args)
        {
            if (args.Length == 3)
            { 
                if (int.TryParse(args[0], out int a) && int.TryParse(args[2], out int b)) 
                { 
                    switch (args[1]){
                        case "+":
                            Console.WriteLine($"Сумма {a} и {b} = {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"Разность {a} и {b} = {a - b}");
                            break;
                        case "/":
                            if (b != 0)
                            {
                                float c = (float)a / (float)b;
                                Console.WriteLine($"Частное от деления {a} на {b} = {c}");
                            }
                            else Console.WriteLine("На ноль делить нельзя");
                            break;
                        case "*":
                            Console.WriteLine($"Произведение {a} и {b} = {a * b}");
                            break;
                        default: 
                            Console.WriteLine("Введены некореектные данные, выражение должно быть в формате a operator b, где operator +, -, /, *"); 
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Введены некореектные данные, выражение должно быть в формате a operator b, где operator +, -, /, *");
                }
            }
        }

        static void Main(string[] args)
        {
            Calc(args);
        }
    }
}
