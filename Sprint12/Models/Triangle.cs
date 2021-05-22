using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sprint12.Models
{
    public class Triangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }
        public double side3 { get; set; }

        public Triangle() { }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
    }
}
