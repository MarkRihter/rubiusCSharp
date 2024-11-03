namespace Lesson2;

public class ExerciseSelector
{
    private int _index = 0;
    private readonly IExecutable[] _exercises;

    public ExerciseSelector(IExecutable[] exercises) => _exercises = exercises;

    public void IncreaseIndex()
    {
        if (_index >= _exercises.Length - 1) return;
        _index++;
    }

    public void DecreaseIndex()
    {
        if (_index < 1) return;
        _index--;
    }

    public void Run()
    {
        Console.Clear();
        _exercises[_index].Run();
    }

    public void Render()
    {
        Console.Clear();

        Console.WriteLine("Select exercise:");

        for (int i = 0; i < _exercises.Length; i++)
        {
            Console.WriteLine($"{(_index == i ? '>' : ' ')} Exercise {i + 1}");
        }
    }
}