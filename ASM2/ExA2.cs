using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    static class ExA2
    {
        static ExA2()
        {
        }
        static int x;
        public static void run()
        {
            int y;
            System.Console.Write("Enter x: ");
            x = int.Parse(Console.ReadLine());
            y = 3 * x * 2 + 4 * x - 7;
            System.Console.WriteLine("3 * x * 2 + 4 * x - 7 = " + y);
        }
    }
}
