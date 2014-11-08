using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH05_02_enum
{
    enum orientation : byte
    {
        north = 1,
        south = 2,
        east = 3,
        west = 4
    }

    class Program
    {
        static void Main(string[] args)
        {
            orientation myDirection = orientation.north;
            Console.WriteLine("myDirection = {0}", myDirection);
            Console.ReadKey();
        }
    }
}
