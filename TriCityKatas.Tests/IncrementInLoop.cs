using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriCityKatas.Tests
{
    public class IncrementInLoop
    {
        public static void PrintNumbers()
        {
            for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Console.WriteLine(++i);
                Console.WriteLine(i--);
                Console.WriteLine(i);
            }
        }
    }
}
