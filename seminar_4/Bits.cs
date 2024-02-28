using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar_4
{
    internal class Bits : IBits
    {
        public Int64 Value { get; private set; } = 0;
        private readonly int size = 0;

        public Bits(Int64 value)
        {
            this.Value = value;
            this.size = sizeof(long);
        }

        

        public static explicit operator long(Bits b) => (long)b.Value;

        public static implicit operator Bits(long b) => new Bits(b);

        public static explicit operator int(Bits b) => (int)b.Value;

        public static implicit operator Bits(int b) => new Bits(b);

        public static explicit operator byte(Bits b) => (byte)b.Value;

        public static implicit operator Bits(byte b) => new Bits(b);

        public bool this[int index]
        {
            get
            {
                if(index > size || index < 0)
                    return false;
                return ((Value >> index) & 1) == 1;
            }

            set
            {
                if(index > size || index < 0)
                    return;
                if (value == true)
                    Value = (Int64)(Value | (1 << index));
                else
                {
                    var mask = (Int64)(1 << index);
                    mask = (Int64)(0xffffffffffffffff ^ (ulong)mask);
                    Value &= (Int64)(Value & mask);
                }
            }
        }

        public bool GetBits(int index)
        {
            return this[index];
        }

        public void SetBits(int index, bool value)
        {
            this[index] = value;
        }


    }
}
