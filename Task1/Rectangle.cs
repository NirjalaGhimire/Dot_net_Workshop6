using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        // Expression-bodied properties
        public double Area => Length * Breadth;

        // Expression-bodied method for perimeter
        public double Perimeter() => 2 * (Length + Breadth);
    }
}
