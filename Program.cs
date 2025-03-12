using System.Security.Cryptography.X509Certificates;

namespace BankAccount
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter 1 to create a Bank Account, 2 to create a Student:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CreateBankAccount();
                break;
            case 2:
                CreateStudent();
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
        Public void CreateBankAccount()
        {

        }
    }
