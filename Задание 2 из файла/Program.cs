using System;

public class MainClass
{
    public static void Main()
    {
        /*
        Console.WriteLine("Упражнение 1");
        Console.WriteLine();
        double e = 2.7;
        Console.WriteLine(e);
        */
        /*
        Console.WriteLine("Упражнение 2");
        Console.WriteLine();
        Console.WriteLine("50");
        Console.WriteLine("10");
        */
        /*
        Console.WriteLine("Упражнение 3");
        Console.WriteLine();
        Console.WriteLine("Введите 4 числа через enter");
        var x1 = Console.ReadLine();
        var x2 = Console.ReadLine();
        var x3 = Console.ReadLine();
        var x4 = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine(x1);
        Console.WriteLine(x2);
        Console.WriteLine(x3);
        Console.WriteLine(x4);
        */
        /*
        Console.WriteLine("Упражнение 4");
        Console.WriteLine();
        int number = int.Parse($"{Console.ReadLine()}") + 10;
        Console.WriteLine(number);
        */
        /*
        Console.WriteLine("Упражнение 5");
        Console.WriteLine();
        Console.WriteLine($"Введите сторону квадрата");
        int a = int.Parse($"{Console.ReadLine()}");
        Console.WriteLine($"Периметр квадрата: {a * 4}");
        */
        /*
        Console.WriteLine("Упражнение 6");
        Console.WriteLine();
        Console.WriteLine($"Введите радиус круга");
        double r = Convert.ToDouble(Console.ReadLine());
        double pi = Math.PI;
        double length = 2 * pi * r;
        double area = pi * r * r;
        Console.WriteLine($"Длина окружности: {length}, площадь: {area}");
        */
        /*
        Console.WriteLine("Упражнение 7");
        Console.WriteLine();
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(Math.Cos(x));
        */
        /*
        Console.WriteLine("Упражнение 8");
        Console.WriteLine();
        int base_1 = int.Parse($"{Console.ReadLine()}");
        int base_2 = int.Parse($"{Console.ReadLine()}");
        int h = int.Parse($"{Console.ReadLine()}");
        var a = Math.Sqrt(Math.Pow((base_1 - base_2 / 2), 2) + h * h);
        var perimeter = 2 * a + base_1 + base_2;
        Console.WriteLine(perimeter);
        */
        /*
        Console.WriteLine("Упражнение 9");
        Console.WriteLine();
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
        */
        /*
        Console.WriteLine("Упражнение 10");
        Console.WriteLine();
        Console.WriteLine("Мир Труд Май");
        Console.WriteLine("Мир");
        Console.WriteLine("\tТруд");
        Console.WriteLine("\t\tМай");
        */
        Console.WriteLine("Упражнение 12");
        Console.WriteLine();
        Console.WriteLine("1.Треугольник");
        Console.WriteLine("2.Четырехугольник");
        Console.WriteLine("3.Круг");

        Console.Write("Выберите фигуру от 1 до 3: ");
        int shape = int.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Что вы хотите вычислить?");
        Console.WriteLine("1.Периметр");
        Console.WriteLine("2.Площадь");
        Console.Write("Выберите от 1 до 2: ");
        int type_of_operation = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // аааа что то сложное сейчас будет не хочууууууу
        double pi = Math.PI;
        double result = 0;

        switch (shape)
        {
            case 1: // Треугольник
                switch (type_of_operation)
                {
                    case 1: // Периметр
                        Console.Write("Введите сторону a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону c: ");
                        double c = double.Parse(Console.ReadLine());
                        result = a + b + c;
                        break;
                    case 2: // Площадь
                        Console.Write("Введите основание: ");
                        double base_triangle = double.Parse(Console.ReadLine()); // ругается на одинаковые название с case 1
                        Console.Write("Введите высоту: ");
                        double h = double.Parse(Console.ReadLine());
                        result = 0.5 * base_triangle * h;
                        break;
                }
                break;
            case 2: // Четырехугольник
                switch (type_of_operation)
                {
                    case 1: // Периметр
                        Console.Write("Введите сторону a: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону b: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону c: ");
                        double c = double.Parse(Console.ReadLine());
                        Console.Write("Введите сторону d: ");
                        double d = double.Parse(Console.ReadLine());
                        result = a + b + c + d;
                        break;
                    case 2: // Площадь
                        Console.Write("Введите длину: ");
                        double length = double.Parse(Console.ReadLine()); //Тоже ругается
                        Console.Write("Введите ширину: ");
                        double width = double.Parse(Console.ReadLine());
                        result = length * width;
                        break;
                }
                break;
            case 3: // Круг
                switch (type_of_operation)
                {
                    case 1: // Периметр
                        Console.Write("Введите радиус: ");
                        double r = double.Parse(Console.ReadLine());
                        result = 2 * pi * r;
                        break;
                    case 2: // Площадь
                        Console.Write("Введите радиус: ");
                        double radius = double.Parse(Console.ReadLine());
                        result = pi * radius * radius; 
                        break;
                }
                break;
        }
        Console.WriteLine();
        Console.WriteLine($"Результат: {result}");























    }   
}