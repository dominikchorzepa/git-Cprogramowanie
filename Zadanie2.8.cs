using System;

class Program8
{
    static void Main(string[] args)
    {
        // Zadanie 2.8
        bool x;
        int y = 1, z = 1;
        x = (y == 1 && z++ == 1);
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
        // x=true, y=1, z=2
    }
}