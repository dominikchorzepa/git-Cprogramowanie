using System;

class Program6
{
    static void Main(string[] args)
    {
        // Zadanie 2.6
        int x, y = 4;
        x = (y -= 2);
        x = y++;
        x = y--;
        Console.WriteLine(x);
        // x = 3
    }
}