namespace Common;

public class TuiSelector(ISelectable[] selectables)
{
    private int _currentIndex = 0;
    private Func<string>? _header;
    private Func<string>? _footer;

    public TuiSelector(ISelectable[] selectables, Func<string>? header = null, Func<string>? footer = null) :
        this(selectables)
    {
        _header = header;
        _footer = footer;
    }

    public static void WaitForInput()
    {
        Console.WriteLine("\nPress any key to continue");
        Console.ReadKey();
    }

    public void Run()
    {
        while (true)
        {
            if (HandleInput()) break;
        }
    }

    private void IncreaseIndex()
    {
        if (_currentIndex >= selectables.Length - 1) return;
        _currentIndex++;
    }

    private void DecreaseIndex()
    {
        if (_currentIndex < 1) return;
        _currentIndex--;
    }

    private void SelectCurrent()
    {
        Console.Clear();

        selectables[_currentIndex].Select();
    }

    private void Render()
    {
        Console.Clear();

        RenderHeader();

        RenderSelectables();

        RenderFooter();

        Console.WriteLine("\nPress TAB to exit.");
    }

    private void RenderHeader()
    {
        if (_header != null)
        {
            Console.WriteLine(_header());
        }
    }

    private void RenderSelectables()
    {
        for (int i = 0; i < selectables.Length; i++)
        {
            Console.WriteLine($"{(_currentIndex == i ? '>' : ' ')} {selectables[i].Name}");
        }
    }

    private void RenderFooter()
    {
        if (_footer != null)
        {
            Console.WriteLine(_footer());
        }
    }

    private bool HandleInput()
    {
        Render();

        var key = Console.ReadKey().Key;

        return HandleKey(key);
    }

    private bool HandleKey(ConsoleKey key)
    {
        bool exiting = false;

        switch (key)
        {
            case ConsoleKey.UpArrow:
                DecreaseIndex();
                break;
            case ConsoleKey.DownArrow:
                IncreaseIndex();
                break;
            case ConsoleKey.Enter:
                SelectCurrent();
                break;
            case ConsoleKey.Tab:
                exiting = true;
                break;
        }

        return exiting;
    }
}