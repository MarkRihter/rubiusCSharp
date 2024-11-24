namespace Lesson4.Exercise1;

public class Fraction
{
    private int Dividend { get; }

    private int Divisor { get; }

    public Fraction(int dividend, int divisor)
    {
        ValidateDivisor(divisor);

        Dividend = dividend;
        Divisor = divisor;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        var (aConvertedToLcm, bConvertedToLcm) = ConvertToCommonDenominator(a, b);

        return new Fraction(aConvertedToLcm.Dividend + bConvertedToLcm.Dividend, aConvertedToLcm.Divisor);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        var (aConvertedToLcm, bConvertedToLcm) = ConvertToCommonDenominator(a, b);

        return new Fraction(aConvertedToLcm.Dividend - bConvertedToLcm.Dividend, aConvertedToLcm.Divisor);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.Dividend * b.Dividend, a.Divisor * b.Divisor);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        return new Fraction(a.Dividend * b.Divisor, a.Divisor * b.Dividend);
    }

    public override string ToString()
    {
        return $"{Dividend}/{Divisor}";
    }

    public static explicit operator float(Fraction fraction)
    {
        return (float)fraction.Dividend / fraction.Divisor;
    }

    public static explicit operator double(Fraction fraction)
    {
        return (double)fraction.Dividend / fraction.Divisor;
    }

    private static void ValidateDivisor(int divisor)
    {
        if (divisor == 0)
            throw new DivideByZeroException("Divisor cannot be zero");
    }

    private static (Fraction, Fraction) ConvertToCommonDenominator(Fraction a, Fraction b)
    {
        var lcm = MathUtils.FindLeastCommonMultiple(a.Divisor, b.Divisor);

        return (ConvertFractionToLcm(a, lcm), ConvertFractionToLcm(b, lcm));
    }

    private static Fraction ConvertFractionToLcm(Fraction fraction, int lcm)
    {
        int multiplier = lcm / fraction.Divisor;

        return new Fraction(multiplier * fraction.Dividend, lcm);
    }
}