namespace Lesson2;

public class Ex1 : IExecutable
{
    public void Run()
    {
        bool isValid;
        int year;

        do
        {
            (isValid, year) = HandleUserInput();

            if (isValid == false)
            {
                Console.WriteLine("Invalid year 😠");
                continue;
            }

            bool isLeap = CheckIfYearIsLeap(year);

            string answer = isLeap ? "YES" : "NO";

            Console.WriteLine(answer);
        } while (isValid == false);

        Console.WriteLine(year);
    }

    private static (bool isValid, int year) HandleUserInput()
    {
        string? userInput = GetUserInput();

        bool parsingSucceeded = int.TryParse(userInput, out int enteredYear);

        bool isValidYear = parsingSucceeded && CheckIfYearIsValid(enteredYear);

        return (isValidYear, enteredYear);
    }

    private static string GetUserInput()
    {
        Console.Write("Enter a year: ");

        return Console.ReadLine() ?? string.Empty;
    }

    private static bool CheckIfYearIsValid(int year)
    {
        const int minYear = 1;
        const int maxYear = 30000;

        bool isGreaterOrEqualsThanMinYear = year >= minYear;
        bool isLessOrEqualThanMaxYear = year <= maxYear;

        return isGreaterOrEqualsThanMinYear && isLessOrEqualThanMaxYear;
    }

    private static bool CheckIfYearIsLeap(int year)
    {
        bool isDivisibleBy4 = year % 4 == 0;
        bool isNotDivisibleBy100 = year % 100 != 0;
        bool isDivisibleBy400 = year % 400 == 0;

        return isDivisibleBy400 || isDivisibleBy4 && isNotDivisibleBy100;
    }
}