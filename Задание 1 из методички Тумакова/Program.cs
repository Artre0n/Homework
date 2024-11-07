using System;

public class MainClass
{
    public static void Main()
    {
        /*
        Console.WriteLine("Лабораторная работа упражнение 2.1");
        Console.WriteLine();
        Console.WriteLine("Как вас зовут?");
        string user_name = Console.ReadLine();
        Console.WriteLine($"Привет, {user_name}!");
        */

        /*
        Console.WriteLine("Лабораторная работа упражнение 2.2");
        Console.WriteLine();
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
        */

        /*
        Console.WriteLine("Лабораторная работа д/з 2.1");
        Console.WriteLine();
        Console.Write("Введите букву: ");
        char input_char = Console.ReadKey().KeyChar;
        Console.WriteLine(); 
     
        char next_char;
        if (input_char == 'z')
        {
            next_char = 'a';
        }
        else
        {
            next_char = (char)(input_char + 1); 
        }

        Console.WriteLine($"Следующая буква: {next_char}");
        */
        
        
        /*
        Console.WriteLine("Лабораторная работа д/з 2.2");
        Console.WriteLine();
        Console.WriteLine("Введите коэффициенты квадратного уравнения");

        Console.Write("Введите коэффициент a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Уравнение имеет два корня:");
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Уравнение имеет один корень:");
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет корней");
        }
        */
    }   
}
