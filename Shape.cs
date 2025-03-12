using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;
    using System.Runtime.InteropServices;

    // Abstract class Shape
    abstract class Shape
    {
        public abstract double CalculateArea(); // Abstract method
    }

    // Derived class Circle
    class Circle : Shape
    {
        private double radius;
        public Circle()
        {
            Console.WriteLine("Enter the radius of the circle:");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        private double length, width;
        public Rectangle()
        {
            Console.WriteLine("Enter the length and width of the rectangle:");
            length = Convert.ToDouble(Console.ReadLine());
            width = Convert.ToDouble(Console.ReadLine());
        }
        public override double CalculateArea()
        {
            return length * width;
        }
    }

    class Program
    {
        static void Main()
        {
            Shape shape1 = new Circle();
            Shape shape2 = new Rectangle();

            Console.WriteLine("Area of Circle: " + shape1.CalculateArea());
            Console.WriteLine("Area of Rectangle: " + shape2.CalculateArea());
        }
    }

}
