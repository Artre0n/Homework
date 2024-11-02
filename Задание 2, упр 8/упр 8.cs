using System;

public class MainClass
{
    public static void Main()
    {
        int base_1 = int.Parse($"{Console.ReadLine()}");
        int base_2 = int.Parse($"{Console.ReadLine()}");
        int h = int.Parse($"{Console.ReadLine()}");
        var a = Math.Sqrt(Math.Pow((base_1 - base_2 / 2), 2) + h * h);
        var perimeter = 2 * a + base_1 + base_2;
        Console.WriteLine( perimeter ); 
    }
}