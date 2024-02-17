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
                    switch (args[2]){
                        case "+":
                            Console.WriteLine($"Сумма {a} и {b} = {a + b}");
                            break;
                        case "-":
                            Console.WriteLine($"Разность {a} и {b} = {a - b}");
                            break;
                        case "":
                            Console.WriteLine($"Разность {a} и {b} = {a - b}");
                            break;
                        case "-":
                            Console.WriteLine($"Разность {a} и {b} = {a - b}");
                            break;
                        default: 
                            Console.WriteLine(); 
                            break;
                    }

                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
