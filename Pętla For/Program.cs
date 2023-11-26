using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Obliczanie wartości funkcji y = root(3^2) * x");

        for (int x = 0; x <= 10; x++)
        {
            double y = Math.Sqrt(Math.Pow(3, 2)) * x;
            Console.WriteLine($"Dla x = {x}, y = {y}");
        }

        Console.ReadLine();
    }
}
