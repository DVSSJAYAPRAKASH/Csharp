using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;

    public class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "Not Provided";
        }

        // Constructor with Title and Author
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "Not Provided";
        }

        // Constructor with Title, Author, and ISBN
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        // Method to display book details
        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Library System!");

            // Using the default constructor
            Book book1 = new Book();
            Console.WriteLine("\nBook 1 (Default Constructor):");
            book1.DisplayDetails();

            // Using the constructor with Title and Author
            Book book2 = new Book("Rich Dad and Poor Dad", "Robert Kiyosaki");
            Console.WriteLine("\nBook 2 (Title and Author Constructor):");
            book2.DisplayDetails();

            // Using the constructor with Title, Author, and ISBN
            Book book3 = new Book("1984", "George Orwell", "978-0451524935");
            Console.WriteLine("\nBook 3 (Title, Author, and ISBN Constructor):");
            book3.DisplayDetails();
        }
    }

}
