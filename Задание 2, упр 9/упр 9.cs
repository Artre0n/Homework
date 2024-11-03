using System;

public class MainClass
{
    public static void Main()
    {
        int cost_candies = 23;
        int cost_cookies = 200;
        int cost_apples = 60;
        Console.WriteLine($"Стоимость одного килограмма конфет: {cost_candies}");
        Console.WriteLine($"Стоимость одного килограмма печенья: {cost_cookies}");
        Console.WriteLine($"Стоимость одного килограмма яблок: {cost_apples}");

        Console.WriteLine();

        Console.Write("Введите количество килограмм конфет: ");
        int kg_candies = int.Parse(Console.ReadLine());
        Console.Write("Введите количество килограмм печенья: ");
        int kg_cookies = int.Parse(Console.ReadLine());
        Console.Write("Введите количество килограмм яблок: ");
        int kg_apples = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine($"Стоимость всей покупки: {cost_candies * kg_candies + cost_cookies * kg_cookies + cost_apples * kg_apples}");

    }
}