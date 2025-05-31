using System;

public class SwapNumbers
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;

        Console.Write("Wprowadź pierwszą liczbę (np. 10): ");
        if (!int.TryParse(Console.ReadLine(), out number1))
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe dla pierwszej liczby.");
            return;
        }

        Console.Write("Wprowadź drugą liczbę (np. 15): ");
        if (!int.TryParse(Console.ReadLine(), out number2))
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe dla drugiej liczby.");
            return;
        }

        Console.WriteLine("\nPrzed zamianą:");
        Console.WriteLine("Pierwsza liczba: " + number1);
        Console.WriteLine("Druga liczba: " + number2);

        temp = number1;
        number1 = number2;
        number2 = temp;

        Console.WriteLine("\nPo zamianie:");
        Console.WriteLine("Pierwsza liczba: " + number1);
        Console.WriteLine("Druga liczba: " + number2);