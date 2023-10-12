using System;

class Program3
{
    static void Main(string[] args)
    {
        // Zadanie 2.3
        double waga;
        double wzrost;
        double BMI;

        Console.WriteLine("Obliczê twój wskaŸnik masy cia³a BMI!");
        Console.WriteLine("Podaj mi swoj¹ wagê (kg): ");
        waga = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj mi swój wzrost (m): ");
        wzrost = double.Parse(Console.ReadLine());

        BMI = waga / (wzrost * wzrost);
        Console.WriteLine($"Twoje BMI to: {BMI}");
    }
}