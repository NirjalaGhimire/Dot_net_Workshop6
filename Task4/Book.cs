using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Book(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}