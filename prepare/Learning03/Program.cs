using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction() 
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator) 
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator) 
    {
        _numerator = numerator;
        if (denominator != 0) 
        {
            _denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public int GetNumerator()
    {
        return _numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public void SetDenominator(int denominator)
    {
        if (denominator != 0) 
        {
            _denominator = denominator;
        }
        else
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
    }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Console.WriteLine(fraction1.GetFractionString()); 
        Console.WriteLine(fraction1.GetDecimalValue());   

        Fraction fraction2 = new Fraction(5);
        Console.WriteLine(fraction2.GetFractionString()); 
        Console.WriteLine(fraction2.GetDecimalValue());   

        Fraction fraction3 = new Fraction(3, 4);
        Console.WriteLine(fraction3.GetFractionString()); 
        Console.WriteLine(fraction3.GetDecimalValue());   

        Fraction fraction4 = new Fraction(1, 3);
        Console.WriteLine(fraction4.GetFractionString()); 
        Console.WriteLine(fraction4.GetDecimalValue());   

        fraction4.SetNumerator(7);
        fraction4.SetDenominator(8);
        Console.WriteLine(fraction4.GetFractionString()); 
        Console.WriteLine(fraction4.GetDecimalValue());  
    }
}
