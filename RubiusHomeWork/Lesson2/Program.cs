using Lesson2;

int exerciseNumber = 0;

while (true)
{
    bool isExiting = HandleInput();

    if (isExiting) break;
}


bool HandleInput()
{
    bool isExiting = false;

    RenderExerciseSelection();

    ConsoleKeyInfo key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            OnUpKey();
            break;
        case ConsoleKey.DownArrow:
            OnDownKey();
            break;
        case ConsoleKey.Enter:
            isExiting = true;
            OnEnterKey();
            break;
    }

    return isExiting;
}

void OnUpKey()
{
    if (exerciseNumber < 1) return;
    exerciseNumber--;
}

void OnDownKey()
{
    if (exerciseNumber > 1) return;
    exerciseNumber++;
}

void OnEnterKey()
{
    Console.Clear();

    switch (exerciseNumber)
    {
        case 0: Ex1.ReadYearAndCheckIfItIsLeap();
            break;
        case 1: Ex2.ReadAndCalculateTotalExpenses();
            break;
    }
}


void RenderExerciseSelection()
{
    Console.Clear();

    Console.WriteLine(
        $"""
         Select exercise number:
         {(exerciseNumber == 0 ? "> " : "  ")} Exercise 1
         {(exerciseNumber == 1 ? "> " : "  ")} Exercise 2
         """);
}