using Common;

namespace Lesson8.Exercise2;

public class L8E2 : ISelectable
{
    public string Name { get; } = "Exercise 2";

    public void Select()
    {
        var ping = new PingPong("Ping", 0.55f);
        var pong = new PingPong("Pong", 0.45f);

        pong.Register(ping);
        ping.Register(pong);

        ping.StartGame();

        TuiSelector.WaitForInput();
    }
}