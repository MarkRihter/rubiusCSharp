using System.Globalization;
using Common;

namespace Lesson2;

internal class L2E2 : ISelectable
{
    public string Name => "Exercise 2";
    public void Select()
    {
        InputUtils.ReadNumber(out int numberOfRecords);

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

    private static decimal ReadAmountOfExpenses(int i)
    {
        Console.Write($"Enter the expense amount {i + 1}: ");

        string? userInput = Console.ReadLine();

        bool parsingSucceeded = decimal.TryParse(userInput, NumberFormatInfo.InvariantInfo, out decimal amountOfExpenses);

        if (parsingSucceeded) return amountOfExpenses;
        else return 0;
    }
}