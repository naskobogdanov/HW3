using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBitChange
{
    class Program
    {
        static void Main()
        {
            int p = 5;
            int n = 291;
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine(result);
        }
    }
}
