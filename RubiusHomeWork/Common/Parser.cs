namespace Common;

public static class Parser
{
    public static string ParseNonEmptyLine(string? line) => line switch
    {
        null or "" => throw new FormatException("Input should not be empty"),
        _ => line
    };
}