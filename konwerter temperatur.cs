using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Wybierz konwersję (C - Celsjusz → Fahrenheit, F - Fahrenheit → Celsjusz): ");
        string direction = Console.ReadLine().ToUpper();

        Console.Write("Podaj temperaturę: ");
        double inputTemp = Convert.ToDouble(Console.ReadLine());

        double converted;

        if (direction == "C")
        {
            converted = inputTemp * 1.8 + 32;
            Console.WriteLine($"{inputTemp}°C = {converted}°F");
        }
        else if (direction == "F")
        {
            converted = (inputTemp - 32) / 1.8;
            Console.WriteLine($"{inputTemp}°F = {converted}°C");
        }
        else
        {
            Console.WriteLine("Nieznany kierunek konwersji.");
            return;
        }

    }
}
