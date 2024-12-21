namespace Common;

public static class InputUtils
{
    public static void ReadNumber(out int number, string message = "")
    {
        HandleInput(out number, message, "Invalid format. Try again.", int.Parse);
    }

    public static void ReadNumber(out decimal number, string message = "")
    {
        HandleInput(out number, message, "Invalid format. Try again.", decimal.Parse);
    }

    public static void ReadNonEmptyLine(out string line, string message = "")
    {
        HandleInput(out line, message, "Input should not be empty", Parser.ParseNonEmptyLine);
    }

    private static void HandleInput<T>(out T number, string message, string errorMessage, Func<string, T> parser)
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
                Console.WriteLine(errorMessage);
            }
        }
    }
}