using System.ComponentModel.DataAnnotations;

public static class Ensure
{
    public static void IsPositive(int value)
    {
        if (value <= 0)
        {
            throw new ValidationException("Value must be positive.");
        }
    }

    public static void IsPositive(double value)
    {
        if (value <= 0)
        {
            throw new ValidationException("Value must be positive.");
        }
    }

    public static void IsPositive(float value)
    {
        if (value <= 0)
        {
            throw new ValidationException("Value must be positive.");
        }
    }

    public static void IsPositive(long value)
    {
        if (value <= 0)
        {
            throw new ValidationException("Value must be positive.");
        }
    }

    public static void IsPositive(ulong value)
    {
        if (value <= 0)
        {
            throw new ValidationException("Value must be positive.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            int testValue = int.Parse(Console.ReadLine());
            Ensure.IsPositive(testValue);
        }
        catch (ValidationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
