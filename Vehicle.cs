using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;
    // Base class Vehicle
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car is starting with a roar!");
        }
    }

    // Derived class Bike
    class Bike : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Bike is starting with a vroom!");
        }
    }

    class Program
    {
        static void Main()
        {
            Vehicle myCar = new Car();
            Vehicle myBike = new Bike();

            myCar.Start();
            myBike.Start();
        }
    }

}
