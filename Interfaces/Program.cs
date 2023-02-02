﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle tri = new Triangle();

            double a = 10;
            double b = 20;
            double c = 1.0;
            double area = 0.0;
            double perimeter = 0.0;

            rec.height = a;
            rec.width = b;
            area = rec.Area();
            Console.WriteLine("Area of rectangle is : {0:F}", area);
            perimeter = rec.Perimeter();
            Console.WriteLine("Perimeter of rectangle is : {0:F}", perimeter);

            Console.WriteLine("---------------------------");

            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of circle is : {0:F}", area);
            perimeter = circle.Perimeter();
            Console.WriteLine("Perimeter of circle is : {0:F}", perimeter);

            Console.WriteLine("---------------------------");

            tri.length = c;
            area = tri.Area();
            Console.WriteLine("Area of triangle is : {0:F}", area);
            perimeter = tri.Perimeter();
            Console.WriteLine("Perimeter of triangle is : {0:F}", perimeter);

            Console.ReadLine();

        }
    }
}
