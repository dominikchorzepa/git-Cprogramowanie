using System;

class Program3
{
    static void Main(string[] args)
    {
        // Zadanie 2.3
        double waga;
        double wzrost;
        double BMI;

        Console.WriteLine("Oblicz� tw�j wska�nik masy cia�a BMI!");
        Console.WriteLine("Podaj mi swoj� wag� (kg): ");
        waga = double.Parse(Console.ReadLine());

        Console.WriteLine("Podaj mi sw�j wzrost (m): ");
        wzrost = double.Parse(Console.ReadLine());

        BMI = waga / (wzrost * wzrost);
        Console.WriteLine($"Twoje BMI to: {BMI}");
    }
}