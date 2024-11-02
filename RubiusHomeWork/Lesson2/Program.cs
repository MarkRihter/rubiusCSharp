ReadYearAndCheckIfItIsLeap();

void ReadYearAndCheckIfItIsLeap()
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

(bool isValid, int year) HandleUserInput()
{
    string? userInput = GetUserInput();

    bool parsingSucceeded = int.TryParse(userInput, out int enteredYear);

    bool isValidYear = parsingSucceeded && CheckIfYearIsValid(enteredYear);

    return (isValidYear, enteredYear);
}

string GetUserInput()
{
    Console.Write("Enter a year: ");

    return Console.ReadLine() ?? string.Empty;
}

bool CheckIfYearIsValid(int year)
{
    const int minYear = 0;
    const int maxYear = 30000;

    switch (year)
    {
        case < minYear: return false;
        case > maxYear: return false;
        default: return true;
    }
}

bool CheckIfYearIsLeap(int year)
{
    bool isDivisibleBy4 = year % 4 == 0;
    bool isDivisibleBy100 = year % 100 == 0;
    bool isDivisibleBy400 = year % 400 == 0;

    return isDivisibleBy400 || isDivisibleBy4 && !isDivisibleBy100;
}