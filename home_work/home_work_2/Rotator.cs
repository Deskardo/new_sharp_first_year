namespace home_work_2;

internal class Rotator
{
    public static void Run(int[,] arr)
    {
        var arr1 = new int[arr.GetLength(0) * arr.GetLength(1)];
        var index = 0;

        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                arr1[index] = arr[i, j];
                index++;
            }
        }

        Array.Sort(arr1);
        index = 0;

        for (var i = 0; i < arr.GetLength(0); i++)
        {
            for (var j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = arr1[index];
                index++;
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}