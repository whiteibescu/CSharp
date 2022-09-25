using System;

class Program
{
    public static void Main(string[] args)
    {
        int x = 3;
        Add(out x);
        Console.WriteLine(x);
        Console.ReadLine();
    }

    public static void Add(out int x)
    {
        x = 3;
    }
}