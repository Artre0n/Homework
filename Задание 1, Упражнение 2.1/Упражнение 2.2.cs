using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите два целых числа через enter");
        int x1 = int.Parse($"{Console.ReadLine()}");
        int x2 = int.Parse($"{Console.ReadLine()}");
        try
        {
            var division = x1 / x2;
            Console.WriteLine(division);
        }
        catch (Exception)
        {
            Console.WriteLine("Деление на 0 недопустимо!");
        }
    }
}