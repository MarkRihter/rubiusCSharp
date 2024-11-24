namespace Lesson4.Exercise1;

public static class MathUtils
{
    public static int FindLeastCommonMultiple(int number1, int number2)
    {
        return Math.Abs(number1 * number2) / FindGreatestCommonDivisorWith(number1, number2);
    }

    private static int FindGreatestCommonDivisorWith(int number1, int number2)
    {
        if (number1 > number2)
        {
            return EuclidsAlgorithm(number1, number2);
        }
        else
        {
            return EuclidsAlgorithm(number2, number1);
        }
    }

    static int EuclidsAlgorithm(int greatest, int least)
    {
        int remainder;

        while ((remainder = greatest % least) != 0)
        {
            greatest = least;
            least = remainder;
        }

        return least;
    }
}