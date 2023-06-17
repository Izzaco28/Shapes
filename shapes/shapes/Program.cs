using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare all shapes
            float width1 = 2;
            float height1 = 8;

            float width2 = 3;
            float height2 = 3;

            // print the details of each shape
            Console.WriteLine("shape 1");
            Console.WriteLine($"     Area: {width1 * height1}");
            Console.WriteLine($"      perimeter: {2 * width1 + 2 * height1}");

            Console.WriteLine("shape 2");
            Console.WriteLine($"     Area: {width2 * height2}");
            Console.WriteLine($"      perimeter: {2 * width2 + 2 * height2}");
        }
    }
}
