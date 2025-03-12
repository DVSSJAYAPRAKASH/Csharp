using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    // Base class Person
    class Person
    {
        public virtual void GetDetails()
        {
            Console.WriteLine("Person details.");
        }
    }

    // Derived class Student
    class Student : Person
    {
        private string name;
        private int studentId;

        public Student(string name, int studentId)
        {
            this.name = name;
            this.studentId = studentId;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Student Name: {name}, ID: {studentId}");
        }
    }

    // Derived class Teacher
    class Teacher : Person
    {
        private string name;
        private string subject;

        public Teacher(string name, string subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"Teacher Name: {name}, Subject: {subject}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person student = new Student("Alice", 101);
            Person teacher = new Teacher("Mr. Smith", "Mathematics");

            student.GetDetails();
            teacher.GetDetails();
        }
    }

}
