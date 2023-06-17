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
            (string name, float width, float height) shape1 = ("shape 1", 2, 8);
            (string name, float width, float height) shape2 = ("shape 2", 3, 3);
            

            // print the details of each shape
            PrintShape(shape1);
            PrintShape(shape2);
        }
            static void PrintShape((string name, float width, float height) shape)
        {
            Console.WriteLine(shape.name);
            Console.WriteLine($"      Area: {shape.width * shape.height}");
            Console.WriteLine($"      Perimeter: {2 * shape.width + 2  * shape.height}");
        }
    }
}
