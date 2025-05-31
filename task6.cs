using System;

public class ArithmeticOps
{
    public static void Main(string[] args)
    {
        double number1, number2;

        Console.Write("Wprowadź pierwszą liczbę (np. 30): ");
        number1 = double.Parse(Console.ReadLine());

        Console.Write("Wprowadź drugą liczbę (np. 7): ");
        number2 = double.Parse(Console.ReadLine());

        Console.WriteLine($"\nWyniki operacji dla {number1} i {number2}:");
        Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
        Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
        Console.WriteLine($"{number1} * {number2} = {number1 * number2}");

        if (number2 != 0)
        {
            Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
        }
        else
        {
            Console.WriteLine("Dzielenie przez zero jest niemożliwe.");
        }

        if (number2 != 0)
        {
            Console.WriteLine($"{number1} mod {number2} = {number1 % number2}");
        }
        else
        {
            Console.WriteLine("Operacja modulo przez zero jest niemożliwa.");
        }
    }
}