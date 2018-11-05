using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursPrintIneger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PrintRecursion(3487));
        }
        static int PrintRecursion(int ch)
        {
            if (ch == 0)
            {
                return 0;
            }
            else
            {
                return ch % 10 + 10*PrintRecursion(ch / 10);
            }
        }
    }
}
