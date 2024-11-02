using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Как вас зовут?");
        string user_name = Console.ReadLine();
        Console.WriteLine($"Привет, {user_name}!");
    }
}
