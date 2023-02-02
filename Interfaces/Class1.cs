using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : IShape
    {
        // Just going to assume equilateral for convenience 
        public double length { get; set; }

        public double Area()
        {
            return 0.25d * Math.Pow(3, 0.5) * Math.Pow(length, 2);
        }

        public double Perimeter()
        {
            return 3 * length;
        }
    }
}
