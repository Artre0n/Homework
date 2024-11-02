using System;

public class MainClass
{
    public static void Main()
    {
        int x = int.Parse($"{Console.ReadLine()}");
        Console.WriteLine(Math.Cos(x));
    }
}