using System;
using System.IO;

// Interface for printing details
public interface IPrintable
{
    void Print();
}

// Interface for saving to a file
public interface ISerializable
{
    void SaveToFile(string filePath);
}

// Report class implementing both interfaces
public class Report : IPrintable, ISerializable
{
    public string Title { get; set; }
    public string Content { get; set; }

    public Report(string title, string content)
    {
        Title = title;
        Content = content;
    }

    // Implementation of IPrintable interface
    public void Print()
    {
        Console.WriteLine($"Report Title: {Title}");
        Console.WriteLine($"Report Content: {Content}");
    }

    // Implementation of ISerializable interface
    public void SaveToFile(string filePath)
    {
        try
        {
            File.WriteAllText(filePath, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report saved to {filePath}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving report: {ex.Message}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a Report object
        Report report = new Report("Annual Financial Report", "The company's revenue increased by 10% this year.");

        // Demonstrate IPrintable implementation
        Console.WriteLine("Printing Report:");
        report.Print();

        // Demonstrate ISerializable implementation
        string filePath = "report.txt";
        Console.WriteLine("\nSaving Report to File:");
        report.SaveToFile(filePath);

        // Verify the file was created
        if (File.Exists(filePath))
        {
            Console.WriteLine("\nFile Content:");
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}