using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        /*
        Console.WriteLine("Упражнение 11");
        Console.WriteLine();
        Console.WriteLine("Введите два числа через enter");
        try
        {
            double x1 = double.Parse(Console.ReadLine().Replace('.', ','));
            double x2 = double.Parse(Console.ReadLine().Replace('.', ','));
            double x3 = x1;
            x1 = x2;
            x2 = x3;
            Console.WriteLine(1);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
        catch (Exception)
        {
            Console.WriteLine("Неккоректный ввод!");
        }
        */
        /*
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
        */
        /*
        Console.WriteLine("Упражнение 13");
        Console.WriteLine();
        double number = double.Parse(Console.ReadLine());
        Console.WriteLine($"Вы ввели число - {number}");
        */
        /*
        Console.WriteLine("Упражнение 14");
        Console.WriteLine();
        Console.WriteLine("2 кг");
        Console.WriteLine("13 17");
        */
        /*
        Console.WriteLine("Упражнение 15");
        Console.WriteLine();

        Random number = new Random();

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(number.Next(1, 10000));
        }
        */
        /*
        Console.WriteLine("Упражнение 16");
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
        /*
        Console.WriteLine("Упражнение 17");
        Console.WriteLine();
        Console.WriteLine("Введите два целых числа через enter:");
        int x1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());

        double average_arithmetic = (x1 + x2) / 2;
        double average_geometric = Math.Sqrt(x1 * x2);

        Console.WriteLine($"Среднее арифметическое: {average_arithmetic}, среднее геометрическое: {average_geometric}");
        */
        /*
        Console.WriteLine("Упражнение 18");
        Console.WriteLine();
        Console.Write("Введите точку на оси x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите точку на оси y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double distance = Math.Sqrt(x * x + y * y);

        Console.WriteLine($"Расстояние между двумя точками: {distance}");
        */
        /*
        Console.WriteLine("Упражнение 19");
        Console.WriteLine();
        Console.Write("Введите число a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите число c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Схема 1");
        double d = b;
        b = c;
        c = a;
        a = d;
        Console.WriteLine($"Результат: a - {a}, b - {b}, c - {c}");
            //Console.WriteLine("Схема 2");
            //double d = b;
            //b = a;
            //a = c;
            //c = d;
            //Console.WriteLine($"Результат: a - {a}, b - {b}, c - {c}");
        */
        /*
        Console.WriteLine("Упражнение 20");
        Console.WriteLine();
        Console.Write("Введите количество секунд: ");
        int n = int.Parse(Console.ReadLine());
        int hours = n / 3600;
        int minutes = (n % 3600) / 60;
        int seconds = (n % 3600) % 60;

        Console.WriteLine($"Полных часов прошло: {hours}");
        Console.WriteLine($"Полных минут прошло с начала очередного часа: {minutes}");
        Console.WriteLine($"Полных секунд прошло с начала очередной минуты: {seconds}");
        */
        /*
        Console.WriteLine("Упражнение 21");
        Console.WriteLine();
        int length = 543;
        int result = 0;
        while (length > 130)
        {
            length -= 130;
            result++;
        }
        Console.WriteLine($"Можно отрезать - {result} квадратов");
        */
        /*
        Console.WriteLine("Упражнение 22");
        Console.WriteLine();
        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int last_digit = number % 10;
        int new_number = last_digit * 100 + number / 10;

        Console.WriteLine($"Полученное число: {new_number}");
        */
        /*
        Console.WriteLine("Упражнение 23");
        Console.WriteLine();
        Console.Write("Введите число, большее 999: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 999)
        {
            Console.WriteLine("Число должно быть больше 999.");
        }
        else
        {
            int hundreds = (n % 1000) / 100;
            int thousands = n / 1000;

            Console.WriteLine($"Кол-во сотен в числе: {hundreds}");
            Console.WriteLine($"Кол-во тысяч в числе: {thousands}");
        }
        */
        /*
        Console.WriteLine("Упражнение 24");
        Console.WriteLine();
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int reverse_number = int.Parse($"{number % 10}{number % 100 / 10}{number / 100 % 10}{number / 1000}");
        Console.WriteLine($"Число, полученное при прочтении его цифр справа налево: {reverse_number}");
        
        int n2143= int.Parse($"{number / 100 % 10}{number / 1000}{number % 10}{number % 100 / 10}");
        Console.WriteLine($"Число, образуемое при перестановке первой и второй, третьей и четвертой цифр: {n2143}");
        
        int n1324 = int.Parse($"{number / 1000}{number % 100 / 10}{number / 100 % 10}{number % 10}");
        Console.WriteLine($"Число, образуемое при перестановке второй и третьей цифр: {n1324}");
        
        int n3412 = int.Parse($"{number % 100 / 10}{number % 10}{number / 1000}{number / 100 % 10}");
        Console.WriteLine($"Число, образуемое при перестановке двух первых и двух последних цифр: {n3412}");
        */
        /*
        Console.WriteLine("Упражнение 25");
        Console.WriteLine();
        Console.Write("Введите число n, такое что 100 <= n <= 999, десятки не равны нулю: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 100 && n > 999 && (n / 10) % 10 == 0)
        {
            Console.WriteLine("Число должно быть от 100 до 999 и десятки не должны быть равны нулю.");
        }

        int last_digit = n / 100;
        int x = n % 100 * 10 + last_digit;

        Console.WriteLine($"Число x: {x}");
        */
        /*
        Console.WriteLine("Упражнение 26");
        Console.WriteLine();
        Console.Write("Введите часы:");
        int h = int.Parse(Console.ReadLine());
        Console.Write("Введите минуты:");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите секунды:");
        int s = int.Parse(Console.ReadLine());

        double hours = 12;
        double minutes = 60;
        double seconds = 60;
        double degrees = 360;

        double hour_angle = 0.5 * ((h % hours) * minutes + m + s / seconds);
        double minute_angle = 6 * (m + s / seconds);
        double angle = Math.Abs(hour_angle - minute_angle);

        if (angle > degrees / 2)
        {
            angle = degrees - angle;
        }

        Console.WriteLine($"Угол между положением часовой стрелки в начале суток и указанным временем: {angle} градусов");
        */
        /*
        Console.WriteLine("Упражнение 27");
        Console.WriteLine();
        Console.Write("Введите угол y (0 <= y <= 2): ");
        double y = double.Parse(Console.ReadLine());
        if (y < 0 || y > 2)
        {
            Console.WriteLine("Угол y должен быть в диапазоне от 0 до 2.");
        }

        int hours = (int)(y * 12);
        double hourAngle = (y * 360) / 12;
        
        double minuteAngle = (hourAngle * 12) / 60; 
        int minutes = (int)(minuteAngle * 60 / 360);

        Console.WriteLine($"Часовая стрелка соответствует {hours} полным часам и {minutes} полным минутам.");
        Console.WriteLine($"Угол для минутной стрелки: {minuteAngle} градусов.");
        */
        /*
        Console.WriteLine("Упражнение 28");
        Console.WriteLine();
        Console.WriteLine("Введите три вещественных числа через enter:");

        double x1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double min = Math.Abs(x1);
        double result = x1;

        if (Math.Abs(x2) < min)
        {
            min = Math.Abs(x2);
            result = x2;
        }
        if (Math.Abs(x3) < min)
        {
            min = Math.Abs(x3);
            result = x3;
        }
        Console.WriteLine($"Меньшее по модулю число: {result}");
        */
        /*
        Console.WriteLine("Упражнение 29");
        Console.WriteLine();
        Console.WriteLine("Введите три числа через enter:");

        int[] s = {int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())};
        int Maxx = s.Max();
        int Minn = s.Min();
        Console.WriteLine($"Сумма большего и меньшего чисел: {Maxx + Minn}");
        */
        /*
        Console.WriteLine("Упражнение 30");
        Console.WriteLine();
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        Console.WriteLine($"Общее количество делителей числа: {count}");
        */
        /*
        Console.WriteLine("Упражнение 31");
        Console.WriteLine();
        Console.WriteLine("Введите коэффициенты A, B, C и D для уравнения A*X3 + B*X2 + C*X + D = 0: ");

        Console.Write("Введите коэффициент A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент C: ");
        int C = int.Parse(Console.ReadLine());

        Console.Write("Введите коэффициент D: ");
        int D = int.Parse(Console.ReadLine());

        bool flag = false;

        for (int x = -100; x <= 100; x++)
        {
            if (A * x * x * x + B * x * x + C * x + D == 0)
            {
                Console.WriteLine($"Корень: {x}");
                flag = true;
            }
        }

        if (flag == false)
        {
            Console.WriteLine("Целые корни не найдены.");
        }
        */
        /*
        Console.WriteLine("Упражнение 32");
        Console.WriteLine();
        Console.Write("Введите первый элемент арифметической прогрессии: ");
        double a1 = double.Parse(Console.ReadLine());

        Console.Write("Введите второй элемент арифметической прогрессии: ");
        double a2 = double.Parse(Console.ReadLine());
    
        Console.Write("Введите номер элемента прогрессии: ");
        int n = int.Parse(Console.ReadLine());

        double d = a2 - a1;
        double a_n = a1 + (n - 1) * d;

        Console.WriteLine($"{n} элемент арифметической прогрессии равен: {a_n}");
        */
        /*
        Console.WriteLine("Упражнение 33");
        Console.WriteLine();
        Console.WriteLine("Введите вашу статус (студент, пенсионер и т.д):");
        string status = Console.ReadLine().ToLower();

        Console.WriteLine("Вы трудоустроены? (да/нет):");
        string employment_status = Console.ReadLine().ToLower();

        bool is_pensioner = status.Contains("пенсионер");
        bool is_student = status.Contains("студент");
        bool is_employed = employment_status.Contains("да");

        if (is_pensioner && is_student)
        {
            Console.WriteLine("Кредит не дадут.");
        }
        else if ((is_pensioner || is_student) && !is_employed)
        {
            Console.WriteLine("Кредит дадут.");
        }
        else if (is_employed)
        {
            Console.WriteLine("Кредит не дадут.");
        }
        else
        {
            Console.WriteLine("Кредит не дадут.");
        }
        */
        /*
        Console.WriteLine("Упражнение 34");
        Console.WriteLine();
        Console.WriteLine("a) Как вас зовут?");
        Console.WriteLine(Console.ReadLine());

        Console.WriteLine("б) Как вас зовут?");
        Console.WriteLine($"Привет, {Console.ReadLine()}!");
        */
        /*
        Console.WriteLine("Упражнение 35");
        Console.WriteLine();
        string greetings = Console.ReadLine();

        Console.WriteLine("Как тебя зовут?");
        string user_name = Console.ReadLine();

        Console.WriteLine($"Привет, {user_name}.");

        Console.ReadLine();
        Console.WriteLine("Да");

        Console.ReadLine();
        Console.WriteLine("Нет");

        Thread.Sleep(5000);

        Console.WriteLine("Но могу показать");

        Random random = new Random();
        ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
        Console.ForegroundColor = colors[random.Next(colors.Length)];

        Console.WriteLine("Вжух типо цвет поменялся");

        Console.ResetColor();
        */
        /*
        Console.WriteLine("Упражнение 36");
        Console.WriteLine();

        Random random = new Random();
        int[] random_digits = new int[12];
        for (int i = 0; i < 12; i++)
        {
            random_digits[i] = random.Next(0, 10);
        }

        int[] user_digits = new int[12];
        Console.WriteLine("Введите 12 цифр:");
        for (int i = 0; i < 12; i++)
        {
            user_digits[i] = int.Parse(Console.ReadLine());
        }

        int sum1 = 0;
        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                sum1 += user_digits[i];
            }
            else
            {
                sum1 += user_digits[i] * 3;
            }
        }
        int sum2 = 0;
        for (int i = 0; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += random_digits[i];
            }
            else
            {
                sum2 += random_digits[i] * 3;
            }
        }
        
        int random_check_sum1 = (10 - (sum1 % 10)) % 10;
        int user_check_sum2 = (10 - (sum2 % 10)) % 10;   
        Console.WriteLine($"Контрольная цифра для рандомного штрихкода: {random_check_sum1}");
        Console.WriteLine($"Контрольная цифра для введенного штрихкода: {user_check_sum2}");
        */
    }
}
