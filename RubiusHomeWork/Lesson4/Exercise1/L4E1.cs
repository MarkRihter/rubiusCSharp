using Common;

namespace Lesson4.Exercise1;

public class L4E1 : ISelectable
{
    public string Name { get; } = "Exercise 1";

    public void Select()
    {
        var a = new Fraction(2, 5);
        var b = new Fraction(7, 6);

        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Substraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Division: {a / b}");
        Console.WriteLine($"B to float: {(float)b}");
        Console.WriteLine($"A to double: {(double)a}");

        TuiSelector.WaitForInput();
    }
}