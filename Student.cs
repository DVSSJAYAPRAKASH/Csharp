using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;
    public class Student
    {
        // Private fields
        private string name;
        private int rollNo;

        // Property for Name with validation
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty or null.");
                }
                name = value;
            }
        }

        // Property for RollNo with validation
        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Roll number cannot be negative.");
                }
                rollNo = value;
            }
        }

        // Constructor to initialize the student
        public Student(string name, int rollNo)
        {
            Name = name; // Use the property to enforce validation
            RollNo = rollNo; // Use the property to enforce validation
        }

        // Method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine($"Student Name: {Name}, Roll Number: {RollNo}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Management System!");

            // Dynamic input for student details
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            int rollNo;
            while (true)
            {
                Console.Write("Enter student roll number: ");
                if (int.TryParse(Console.ReadLine(), out rollNo))
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid integer for roll number.");
            }

            try
            {
                // Create a new student object
                Student student = new Student(name, rollNo);

                // Display student details
                student.DisplayDetails();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}