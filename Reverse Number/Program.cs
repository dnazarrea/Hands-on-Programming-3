using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y = 0, z;
            Console.Write("Enter a number: ");
            x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                z = x % 10;
                y = y * 10 + z;
                x /= 10;
            }
            Console.Write("Reversed Number: " + y);

            Console.ReadKey();

        }
    }
}
