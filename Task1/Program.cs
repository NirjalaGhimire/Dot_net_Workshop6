using System.Drawing;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle { Length = 10, Breadth = 5 };

            Console.WriteLine($"Area: {r.Area}");
            Console.WriteLine($"Perimeter: {r.Perimeter()}");
        }
    }
}
