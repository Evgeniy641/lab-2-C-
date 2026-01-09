using System;

// Задание 5 - Дробь
public class Fraction
{
    public int Numerator { get; set; }
    public int Denominator { get; set; }

    // Конструктор
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю");
        }

        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    // Метод для сокращения дроби
    private void Simplify()
    {
        int gcd = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= gcd;
        Denominator /= gcd;

        // Убедимся, что знаменатель всегда положительный
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    // Наибольший общий делитель
    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Метод ToString
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }

    // Операции с дробями
    public Fraction Add(Fraction other)
    {
        int newNumerator = Numerator * other.Denominator + other.Numerator * Denominator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = Numerator * other.Denominator - other.Numerator * Denominator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = Numerator * other.Numerator;
        int newDenominator = Denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Divide(Fraction other)
    {
        if (other.Numerator == 0)
        {
            throw new DivideByZeroException("Деление на нулевую дробь");
        }

        int newNumerator = Numerator * other.Denominator;
        int newDenominator = Denominator * other.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    // Операции с целыми числами
    public Fraction Add(int number)
    {
        return Add(new Fraction(number, 1));
    }

    public Fraction Subtract(int number)
    {
        return Subtract(new Fraction(number, 1));
    }

    public Fraction Multiply(int number)
    {
        return Multiply(new Fraction(number, 1));
    }

    public Fraction Divide(int number)
    {
        return Divide(new Fraction(number, 1));
    }

    // Синонимы методов для удобства
    public Fraction Sum(Fraction other)
    {
        return Add(other);
    }

    public Fraction Sum(int number)
    {
        return Add(number);
    }

    public Fraction Minus(Fraction other)
    {
        return Subtract(other);
    }

    public Fraction Minus(int number)
    {
        return Subtract(number);
    }

    public Fraction Div(Fraction other)
    {
        return Divide(other);
    }

    public Fraction Div(int number)
    {
        return Divide(number);
    }
}