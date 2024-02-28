using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3
{
    public interface IFamily
    {
        Person this[int index] { get; }

        int Count { get; }
    }


}
