using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    using System;
    public class BankAccountDetails
    {
        // Private field to store the balance
        private decimal balance;

        // Constructor to initialize the balance (optional)
        public BankAccountDetails(decimal initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");
            }
            balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited: {amount}. New Balance: {balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient balance for withdrawal.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}. New Balance: {balance}");
        }

        // Method to get the current balance (read-only)
        public decimal GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank Account Management System!");

            // Initialize the bank account with a starting balance
            Console.Write("Enter the initial balance: ");
            decimal initialBalance;
            while (!decimal.TryParse(Console.ReadLine(), out initialBalance) || initialBalance < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
                Console.Write("Enter the initial balance: ");
            }

            BankAccountDetails account = new BankAccountDetails(initialBalance);

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    Console.Write("Enter your choice: ");
                }

                switch (choice)
                {
                    case 1: // Deposit
                        Console.Write("Enter the amount to deposit: ");
                        decimal depositAmount;
                        while (!decimal.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive number.");
                            Console.Write("Enter the amount to deposit: ");
                        }
                        try
                        {
                            account.Deposit(depositAmount);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2: // Withdraw
                        Console.Write("Enter the amount to withdraw: ");
                        decimal withdrawAmount;
                        while (!decimal.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive number.");
                            Console.Write("Enter the amount to withdraw: ");
                        }
                        try
                        {
                            account.Withdraw(withdrawAmount);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case 3: // Check Balance
                        Console.WriteLine($"Current Balance: {account.GetBalance()}");
                        break;

                    case 4: // Exit
                        Console.WriteLine("Thank you for using the Bank Account Management System. Goodbye!");
                        return;
                }
            }
        }
    }
}
