namespace Common;

public class TuiSelector(List<ISelectable> selectables)
{
    public List<ISelectable> Selectables { get; } = selectables;
    private int _currentIndex = 0;
    private Func<string>? _header;
    private Func<string>? _footer;


    public TuiSelector(ISelectable[] selectables) : this(selectables.ToList())
    {
    }

    public TuiSelector(ISelectable[] selectables, Func<string>? header = null, Func<string>? footer = null) :
        this(selectables)
    {
        _header = header;
        _footer = footer;
    }

    public TuiSelector(List<ISelectable> selectables, Func<string>? header = null, Func<string>? footer = null) : this(
        selectables.ToArray(), header, footer
    )
    {
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

    public void Add(ISelectable selectable)
    {
        Selectables.Add(selectable);
        ResetIndex();
    }

    public void Remove(ISelectable selectable)
    {
        Selectables.Remove(selectable);
        ResetIndex();
    }

    public void Clear()
    {
        Selectables.Clear();
        ResetIndex();
    }

    private void IncreaseIndex()
    {
        if (_currentIndex >= Selectables.Count - 1) return;
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

        Selectables[_currentIndex].Select();
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
        for (int i = 0; i < Selectables.Count; i++)
        {
            Console.WriteLine($"{(_currentIndex == i ? '>' : ' ')} {Selectables[i].Name}");
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

    private void ResetIndex()
    {
        _currentIndex = 0;
    }
}