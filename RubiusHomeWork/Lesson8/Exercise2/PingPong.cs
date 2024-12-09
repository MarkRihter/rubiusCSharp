namespace Lesson8.Exercise2;

public class PingPong
{
    public string Name { get; }
    public double Skill { get; }

    private Random random = new Random();

    public PingPong(string name, double skill)
    {
        Name = name;
        Skill = skill;
    }

    public delegate void PingPongHit(PingPong opponent);

    public event PingPongHit? HitHandler;

    public void Register(PingPong pingPong)
    {
        HitHandler += pingPong.StrikeBack;
    }

    private void StrikeBack(PingPong opponent)
    {
        var skillDifference = double.Abs(Skill - opponent.Skill);

        var luck = (random.NextDouble() - 0.5) / 20;
        var victoryThreshold = random.NextDouble() + luck;

        var isHitSuccessful = victoryThreshold <= skillDifference;

        if (isHitSuccessful)
        {
            Console.WriteLine($"{Name} нанес победный удар в схватке с {opponent.Name}");
        }
        else
        {
            Console.WriteLine($"{Name} отбил удар {opponent.Name}");
            HitHandler?.Invoke(this);
        }
    }

    public void StartGame()
    {
        Console.WriteLine($"{Name} Начинает игру");

        HitHandler?.Invoke(this);
    }
}