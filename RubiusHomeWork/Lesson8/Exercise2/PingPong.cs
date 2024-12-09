namespace Lesson8.Exercise2;

public class PingPong(string name, double skill)
{
    private string Name { get; } = name;

    private double Skill { get; } = skill;

    private readonly Random _random = new();

    public delegate void PingPongHit(PingPong opponent);

    public event PingPongHit? HitHandler;

    public void Register(PingPong pingPong)
    {
        HitHandler += pingPong.StrikeBack;
    }

    public void StartGame()
    {
        Console.WriteLine($"{Name} Начинает игру");

        HitHandler?.Invoke(this);
    }

    private void StrikeBack(PingPong opponent)
    {
        var isStrikeSuccessful = DetermineStrikeSuccess(opponent.Skill);

        if (isStrikeSuccessful)
        {
            OnStrikeSuccess(opponent.Name);
        }
        else
        {
            OnStrikeUnSuccess(opponent.Name);
        }
    }

    private bool DetermineStrikeSuccess(double opponentSkill)
    {
        var skillDifference = double.Abs(Skill - opponentSkill);

        var luck = (_random.NextDouble() - 0.5) / 20;

        var victoryThreshold = _random.NextDouble() + luck;

        return victoryThreshold <= skillDifference;
    }

    private void OnStrikeSuccess(string opponentName)
    {
        Console.WriteLine($"{Name} нанес победный удар в схватке с {opponentName}");
    }

    private void OnStrikeUnSuccess(string opponentName)
    {
        Console.WriteLine($"{Name} отбил удар {opponentName}");
        HitHandler?.Invoke(this);
    }
}