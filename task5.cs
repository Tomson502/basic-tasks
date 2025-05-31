using System;

public class MultiplyThree
{
    public static void Main(string[] args)
    {
        int num1, num2, num3, result;

        Console.Write("Wprowadź pierwszą liczbę do pomnożenia (np. 4): ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Wprowadź drugą liczbę do pomnożenia (np. 5): ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("Wprowadź trzecią liczbę do pomnożenia (np. 7): ");
        num3 = int.Parse(Console.ReadLine());

        result = num1 * num2 * num3;

        Console.WriteLine($"\nWynik mnożenia:");
        Console.WriteLine($"{num1} x {num2} x {num3} = {result}");
    }
}
