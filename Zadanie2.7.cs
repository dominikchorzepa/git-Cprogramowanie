using System;

class Program7
{
    static void Main(string[] args)
    {
        // Zadanie 2.7
        int x, y = 5;
        x = ++y * 2;
        x = y++;
        x = y--;
        Console.WriteLine(++y);
        // y = 7
    }
}