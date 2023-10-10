using System;
class Program
{
    static void Main(string[] args)
    {
        //Zadanie 2.2
        int a;
        int b;
        int c;
        int delta;

        Console.WriteLine("Obliczanie delty dla równania kwadratowego!");
        Console.WriteLine("Podaj a: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj b: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj c: ");
        c = int.Parse(Console.ReadLine());

        delta = b * b - 4 * a * c;
        Console.WriteLine($"Delta = {delta}");
    }
}
