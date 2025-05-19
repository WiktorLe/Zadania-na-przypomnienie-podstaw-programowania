using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ile ocen chcesz wprowadzić? ");
        int count = Convert.ToInt32(Console.ReadLine());

        List<double> grades = new List<double>();

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Ocena {i + 1}: ");
            double grade = Convert.ToDouble(Console.ReadLine());
            grades.Add(grade);
        }

        double sum = 0;
        foreach (var grade in grades)
        {
            sum += grade;
        }

        double average = sum / grades.Count;
        Console.WriteLine($"Średnia: {average:F2}");

        if (average >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");

    }
}
