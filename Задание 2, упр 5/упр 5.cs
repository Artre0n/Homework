using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine($"Введите сторону квадрата");
        int a = int.Parse($"{Console.ReadLine()}");
        Console.WriteLine($"Периметр квадрата: {a * 4}");
    }
}