using System.Globalization;
using Common;

namespace Lesson3;

internal class L3E1 : ISelectable
{
    public string Name => "Exercise 1";
    public void Select()
    {
        InputUtils.ReadNumber(out decimal income, "Enter Income Amount: ");

        decimal taxes = CalculateTaxes(income);

        Console.WriteLine($"Taxes: {taxes}");

        TuiSelector.WaitForInput();
    }

    private decimal CalculateTaxes(decimal income)
    {
        const decimal taxRate = 0.13m;

        return income * taxRate;
    }
}