using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine($"Введите радиус круга");
        double r = Convert.ToDouble(Console.ReadLine());
        double pi = Math.PI;
        double length = 2 * pi * r;
        double area = pi * r * r;
        Console.WriteLine($"Длина окружности: {length}, площадь: {area}");
    }
}