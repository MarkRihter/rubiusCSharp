namespace Lesson3.Exercise2;

internal class NameReader
{
    protected static string ReadName()
    {
        Console.Write("Enter product name: ");
        return Console.ReadLine() ?? string.Empty;
    }
}