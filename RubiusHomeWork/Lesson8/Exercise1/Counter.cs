namespace Lesson8.Exercise1;

public class Counter
{
    public delegate void EventPayload(int value);

    public event EventPayload? Event;

    public void Start()
    {
        var random = new Random();
        int magicNumber = random.Next(100);

        for (int i = 0; i < 100; i++)
        {
            if (magicNumber == i)
            {
                Event?.Invoke(i);
            }
        }
    }

    public void Register(EventPayload notifyCallback)
    {
        Event += notifyCallback;
    }
}