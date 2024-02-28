using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    internal class BabySitter: IBabySitter
    {
        public void TakeCare()
        {
            Console.WriteLine("hello, I'm Your BabySitter, class BabySitter");
        }
    }
}
