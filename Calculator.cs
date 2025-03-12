using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    // Calculator class demonstrating method overloading
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double values
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            Console.WriteLine("Sum of 2 integers: " + calc.Add(5, 10));
            Console.WriteLine("Sum of 3 integers: " + calc.Add(5, 10, 15));
            Console.WriteLine("Sum of 2 doubles: " + calc.Add(5.5, 10.2));
        }
    }

}
