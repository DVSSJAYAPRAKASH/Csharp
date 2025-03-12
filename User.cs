using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    // Base class for User
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public User(string username, string role)
        {
            Username = username;
            Role = role;
        }

        // Virtual method to be overridden by derived classes
        public virtual void AccessControl()
        {
            Console.WriteLine($"User {Username} has basic access.");
        }
    }

    // Derived class for Admin
    public class Admin : User
    {
        public Admin(string username) : base(username, "Admin") { }

        // Override AccessControl method for Admin
        public override void AccessControl()
        {
            Console.WriteLine($"Admin {Username} has full access to all features.");
        }
    }

    // Derived class for Customer
    public class Customer : User
    {
        public Customer(string username) : base(username, "Customer") { }

        // Override AccessControl method for Customer
        public override void AccessControl()
        {
            Console.WriteLine($"Customer {Username} has limited access to features.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an Admin user
            User admin = new Admin("admin_user");
            admin.AccessControl();

            // Create a Customer user
            User customer = new Customer("customer_user");
            customer.AccessControl();
        }
    }
}
