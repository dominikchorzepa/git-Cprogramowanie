using System;
class Program1
{
    static void Main(string[] args)
    {
        // Zadanie 2.1
        double StopnieC;
        double StopnieF;

        Console.WriteLine("Podaj temperaturę w stopniach Celsjusza: ");
        StopnieC = int.Parse(Console.ReadLine());
        StopnieF = 32 + (9 * StopnieC) / 5;
        Console.WriteLine($"Temperatura w stopniach Fahrenheita: {StopnieF}");
    }
}
