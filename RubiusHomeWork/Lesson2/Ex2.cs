using System.Globalization;

namespace Lesson2;

public class Ex2 : IExecutable
{
    public void Run()
    {
        int numberOfRecords = ReadNumberOfRecords();
        decimal totalExpenses = 0m;

        for (int i = 0; i < numberOfRecords; i++)
        {
            totalExpenses += ReadAmountOfExpenses(i);
        }

        Console.WriteLine($"""
                           ===============
                           Total expenses: {totalExpenses}
                           """);
    }

    private static int ReadNumberOfRecords()
    {
        Console.Write("Enter number of records: ");

        string? userInput = Console.ReadLine() ?? string.Empty;

        bool parsingSucceeded = int.TryParse(userInput, out int numberOfRecords);

        if (parsingSucceeded)
        {
            return numberOfRecords;
        }
        else
        {
            return 0;
        };
    }

    private static decimal ReadAmountOfExpenses(int i)
    {
        Console.Write($"Enter the expense amount {i + 1}: ");

        string? userInput = Console.ReadLine();

        bool parsingSucceeded = decimal.TryParse(userInput, NumberFormatInfo.InvariantInfo, out decimal amountOfExpenses);

        if (parsingSucceeded) return amountOfExpenses;
        else return 0;
    }
}