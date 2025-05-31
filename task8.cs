using System;

public class MultiplicationTable
{
    public static void Main(string[] args)
    {
        int number;

        Console.Write("Wprowadź liczbę, dla której chcesz zobaczyć tabliczkę mnożenia (np. 7): ");
        number = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabliczka mnożenia dla liczby {number}:");

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{number} * {i} = {number * i}");
        }
    }
}
