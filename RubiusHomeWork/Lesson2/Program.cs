using Lesson2;

ExerciseSelector exerciseSelector = new ExerciseSelector( [new Ex1(), new Ex2()]);

while (true)
{
    bool isExiting = HandleInput();

    if (isExiting) break;
}


bool HandleInput()
{
    bool isExiting = false;

    exerciseSelector.Render();

    ConsoleKeyInfo key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            exerciseSelector.DecreaseIndex();
            break;
        case ConsoleKey.DownArrow:
            exerciseSelector.IncreaseIndex();
            break;
        case ConsoleKey.Enter:
            isExiting = true;
            exerciseSelector.Run();
            break;
    }

    return isExiting;
}