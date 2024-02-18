namespace home_work_2;

internal class Program
{
    static void Main()
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        Rotator.Run(a);
    }
}