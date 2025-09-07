using System;


class Calculator
{
    static float memory = 0;

    static void memoryPlus(float x)
    {
        memory += x;
        Console.WriteLine($"{x} добавлено в память, текущее значение в памяти: {memory}");
    }

    static void memoryMinus(float x)
    {
        memory -= x;
        Console.WriteLine($"{x} вычтено из памяти, текущее значение в памяти: {memory}");
    }

    static float memoryRecall()
    {
        Console.WriteLine($"Текущее значение в памяти: {memory}");
        return memory;
    }

    static float calc_func(float first, float second, string sign)
    {

        if (sign == "+")
        {
            return first + second;
        }
        else if (sign == "-")
        {
            return first - second;
        }
        else if (sign == "*")
        {
            return first * second;
        }
        else if (sign == "/")
        {
            if (second == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return float.NaN;
            }
            else
            {
                return first / second;
            }
        }

        else if (sign == "%")
        {
            if (second == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return float.NaN;
            }
            else
            {
                return first % second;
            }
        }
        else if (sign == "1/x")
        {
            if (first == 0)
            {
                Console.WriteLine("На ноль делить нельзя!");
                return float.NaN;
            }
            else
            {
                return 1 / first;
            }
        }

        else if (sign == "x^2")
        {
            return first * first;
        }

        else if (sign == "sqrt")
        {
            if (first < 0)
            {
                Console.WriteLine("Корень из отрицательного числа!");
                return float.NaN;
            }
            else
            {
                return (float)Math.Sqrt(first);
            }
        }
        else
        {
            Console.WriteLine("Неизвестная операция");
            return float.NaN;
        }
    }
    static void Main()
    {

        Console.WriteLine("Добро пожаловать в калькулятор!");
        Console.WriteLine("Доступные операции:");
        Console.WriteLine("+, -, *, /, %, 1/x, x^2");
        Console.WriteLine("M+ (добавить в память), M- (вычесть из памяти), MR (прочитать память)");
        Console.WriteLine("Введите 'exit' для выхода.");

        string input;
        float result = 0;

        while (true)
        {
            Console.WriteLine("\nВведите команду или операцию: ");
            input = Console.ReadLine();

            if (input == null || input.ToLower() == "exit")
            {
                Console.WriteLine("Завершение работы");
                break;
            }

            if (input == "MR")
            {
                result = memoryRecall();

                continue;
            }

            if (input == "M+")
            {
                memoryPlus(result);
            }
            else if (input == "M-")
            {
                memoryMinus(result);
            }

            if ( input == "MR" || input == "M+" || input == "M-")
            {
                Console.WriteLine("\nВведите операцию: ");
                input = Console.ReadLine();
            }

            Console.Write("Введите первое число: ");
            if (!float.TryParse(Console.ReadLine(), out float first))
            {
                Console.WriteLine("Ошибка: введите корректное число.");
                continue;
            }

            float second = 0;
            if (!(input == "1/x" || input == "x^2" || input == "MR"))
            {
                Console.Write("Введите второе число: ");
                if (!float.TryParse(Console.ReadLine(), out second))
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    continue;
                }
            }
            result = calc_func(first, second, input);

            if (float.IsInfinity(result))
            {
                Console.WriteLine("Переполнение! Результат слишком большой.");
                return;
            }

            if (!float.IsNaN(result))
            {
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}




