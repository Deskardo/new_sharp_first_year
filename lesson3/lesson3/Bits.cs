using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    class Bits
    {
        public byte Value { get; private set; } = 0;

        public Bits(byte b)
        {
            this.Value = b;
        }

        public static implicit operator byte(Bits b) => b.Value;
        public static implicit operator Bits(byte b) => new Bits(b);


/*        public byte Value { get; private set; }
        public Bits(byte b)
        {
            this.Value = b;
        }
*/
/*        public bool this[int index]
        {
            get
            {
                if (index > 7 || index < 0)
                    return false;

                return ((Value >> index) & 1) == 1;
            }
            set
            {
                if (index > 7 || index < 0)
                    return;
                if (value == true)
                    Value = (byte)(Value | (1 << index));
                else
                {
                    var mask = (byte)(1 << index);
                    mask = (byte)(0xff ^ mask);
                    Value &= (byte)(Value & mask);
                }
            }       
        }*/
    }

}

/*            var b = new Bits(122);

   for (int i = 0; i <= 7; i++)
   {
       Console.Write(b[i]);
   }
*/

/*
 *            var bits = new Bits(20);

   byte b = bits;

   Console.WriteLine(bits);
   b = 21;

   bits = (Bits)b;
   Console.WriteLine(bits);
 */

