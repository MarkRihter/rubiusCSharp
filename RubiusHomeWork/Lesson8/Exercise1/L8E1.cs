using Common;

namespace Lesson8.Exercise1;

public class L8E1 : ISelectable
{
    public string Name { get; } = "Exercise 1";

    public void Select()
    {
        var counter = new Counter();

        var handler1 = new Handler1();
        var handler2 = new Handler2();

        counter.Register(handler1.OnCallback);
        counter.Register(handler2.OnCallback);

        counter.Start();


        TuiSelector.WaitForInput();
    }
}