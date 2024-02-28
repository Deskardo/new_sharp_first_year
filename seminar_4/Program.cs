namespace seminar_4
{
    internal class Program
    {
        static void Main()
        {
/*          IBits ibits = new Bits(1107);
            Console.WriteLine(ibits.GetBits(0));
            Console.WriteLine(ibits.GetBits(1));*/


            var bits = new Bits(30);
            Console.WriteLine(bits.Value);

            bits[1] = false;
            long num = (long)bits;
            Console.WriteLine(num);
            num = 1234;
            Bits bits2 = num;

            for (int i = 4; i > 0; i--)
            {
                Console.Write(Convert.ToInt32(bits2.GetBits(i)));
            }
        }
    }
}