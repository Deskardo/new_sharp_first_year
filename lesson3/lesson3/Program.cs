using System.Net.Http.Metrics;
using static Person;

namespace lesson3
{
    internal class Program
    {
        /*        record ReferenceRecord() // использование референсных записей
                {
                    public int b { get; set; } = 0;
                    public int c { get; set; } = 0;
                }
                var r1 = new ReferenceRecord() { b = 10, c = 20 };
                var r2 = r1 with { b = 55 };

                Console.WriteLine(r1);
                Console.WriteLine(r2);*/

/*        class SimpleTuple<T1, T2>
        {
            public SimpleTuple(T1 t1, T2 t2)
            {
                this.Item1 = t1;
                this.Item2 = t2;
            }

            public T1 Item1 { get; init; }
            public T2 Item2 { get; init; }

            public override string ToString()
            {
                return $"{{{Item1}}}, {{{Item2}}}";
            }
        }

        SimpleTuple<int, string> tuple = new SimpleTuple<int, string>(10, "test");
        Console.WriteLine(tuple);*/

        class Metric:IComparable<Metric>
        {
            public int Month;
            public int Temperature;
            public int Days;

            public int CompareTo(Metric? metric)
            {
                int res = this.Month.CompareTo(metric.Month);
                if (res != 0)
                {
                    return res;
                }
                else
                {
                    return this.Temperature.CompareTo(metric.Temperature);
                }
            }

            public override string ToString()
            {
                return $"{Month}, {Temperature}, {Days}";
            }

        }
        
        static void Main()
        {
            Metric[] temperatures = new Metric[]
            {
                new Metric { Month = 1, Temperature = -10, Days = 20},
                new Metric { Month = 6, Temperature = 22, Days = 1},
                new Metric { Month = 2, Temperature = 20, Days = 2},
                new Metric { Month = 9, Temperature = 10, Days = 3},
                new Metric { Month = 10, Temperature = 15, Days = 4},
                new Metric { Month = 2, Temperature = 30, Days = 5},
                new Metric { Month = 2, Temperature = -5, Days = 6},
                new Metric { Month = 11, Temperature = -20, Days = 7}
            };

            Array.Sort(temperatures);

            foreach (var temp in temperatures)
            {
                Console.WriteLine(temp );
            }
        }
    }
}