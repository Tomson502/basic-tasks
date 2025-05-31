using System;

public class SpecifiedFormula
{
    public static void Main(string[] args)
    {
        double x, y, z;
        double result1, result2;

        Console.WriteLine("Program obliczający wartości według wzorów: (x+y).z oraz x.y + y.z");

        Console.Write("Wprowadź pierwszą liczbę (x) (np. 3): ");
        x = double.Parse(Console.ReadLine());

        Console.Write("Wprowadź drugą liczbę (y) (np. 4): ");
        y = double.Parse(Console.ReadLine());

        Console.Write("Wprowadź trzecią liczbę (z) (np. 5): ");
        z = double.Parse(Console.ReadLine());

        result1 = (x + y) * z;
        result2 = (x * y) + (y * z);

        Console.WriteLine($"\nWyniki dla liczb x={x}, y={y}, z={z}:");
        Console.WriteLine($"(x+y).z = ({x}+{y})*{z} = {result1}");
        Console.WriteLine($"x.y + y.z = ({x}*{y}) + ({y}*{z}) = {result2}");
    }
}
