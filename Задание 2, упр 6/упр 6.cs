using System;
using System.Reflection.Metadata;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine($"Введите радиус круга");
        double r = Convert.ToDouble(Console.ReadLine());
        double length = 2 * 3.14 * r;
        double area = 3.14 * r * r;
        Console.WriteLine($"Длина окружности: {length}, площадь: {area}");
    }
}