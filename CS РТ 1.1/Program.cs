using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

float memory;

void memory_plus(float num)
{
    memory = num;
    return;
}

void memory_minus(){
    memory = 0;
    return;
}

double calc_func(double first,  double second)
{
    Console.WriteLine("Напишите знак: (+,-,*,/,%,1/x,x^2, MR, M+, M-)");
    string sign;
    sign = Convert.ToString(Console.ReadLine());
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

        }
        else
        {
            return first / second;
        }
    }
    else if (sign == "^")
    {
        return Math.Pow(first, second);
    }
    return 0;
}

double first, second;
byte status;
Console.WriteLine("1 - начать, 0 - завершить");//интерфейс
status = Convert.ToByte(Console.ReadLine());
switch (status){
    case 1:
        first = Convert.ToDouble(Console.ReadLine());
        second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine(calc_func(first, second));
        break;
    case 0:
        return;
    default:
        return;
}
