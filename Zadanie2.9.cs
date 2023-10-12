using System;

class Program9
{
    static void Main(string[] args)
    {
        // Zadanie 2.9a
        //int x = 1, y = 4, z = 2;
        //bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        // wynik=False x=2 y=4 z=2

        //b
        //int x = 1, y = 4, z = 2;
        //bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        //wynik=False x=2 y=5 z=2

        //c
        //int x = 1, y = 4, z = 2;
        //bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        //wynik=False x=2 y=5 z=1

        //d
        //int x = 1, y = 3, z = 4;
        //bool wynik = (x == 1 || y++ > 2 || ++z > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        //wynik=True x=1 y=3 z=4

        //e
        //int x = 1, y = 3, z = 4;
        //bool wynik = (x == 1 | y++ > 2 || ++z > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        //wynik=True x=1 y=4 z=4

        //f
        //int x = 1, y = 3, z = 4;
        //bool wynik = (x == 1 | y++ > 2 | ++z > 0);
        //Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        //wynik=True x=1 y=4 z=5
    }
}
