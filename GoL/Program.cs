using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoL
{
    class Program
    {
        static void Main()
        {
            Cell cell = new Cell();
            cell.Foo = (5150);
            Console.WriteLine("TRACER: " + cell.Foo);
            Console.ReadLine();
        }
    }
}
