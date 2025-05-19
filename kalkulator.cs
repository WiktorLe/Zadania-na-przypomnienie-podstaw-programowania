using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        double result;

        if (op == "+")
            result = num1 + num2;
        else if (op == "-")
            result = num1 - num2;
        else if (op == "*")
            result = num1 * num2;
        else if (op == "/")
        {
            if (num2 == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero.");
                return;
            }
            result = num1 / num2;
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
            return;
        }

        Console.WriteLine("Wynik: " + result);
        // Automatyczne zakończenie
    }
}
