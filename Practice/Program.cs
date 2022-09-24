using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = 3;
        Add(ref x);
        Console.WriteLine(x);
        Console.ReadLine();
    }

    public static void Add(ref int x)
    {
        x = x + 3;
    }
}