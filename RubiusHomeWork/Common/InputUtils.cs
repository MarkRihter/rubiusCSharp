using System.Globalization;

namespace Common;

public static class InputUtils
{
    public static void ReadNumber(out int number, string message = "")
    {
        HandleInput(out number, message, int.Parse);
    }

    public static void ReadNumber(out decimal number, string message = "")
    {
        HandleInput(out number, message, decimal.Parse);
    }

    private static void HandleInput<T>(out T number, string message, Func<string, T> parser)
    {
        while (true)
        {
            Console.Write(message);

            string? input = Console.ReadLine();

            try
            {
                number = parser(input ?? string.Empty);
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Try again.");
            }
        }

        ;
    }
}