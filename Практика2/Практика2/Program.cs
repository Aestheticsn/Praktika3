using System;

namespace Практика2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            char operation;
            
            Console.WriteLine("Введите первое число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите действие:");

            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine("Cумма " + a + " и " + b + " равна " + result + ".");
                    break;

                case '-':
                    result = a - b;
                    Console.WriteLine("Разность " + a + " и " + b + " равна " + result + ".");
                    break;

                case '*':
                    result = a * b;
                    Console.WriteLine("Произведение " + a + " и " + b + " равно " + result + ".");
                    break;

                case '^':
                    result = Math.Pow(a, b);
                    Console.WriteLine("возведение в степень " + a + " и " + b + " равно " + result + ".");
                    break;

                case 'a':
                    result = Math.Pow(a, b);
                    Console.WriteLine("возведение в степень " + a + " и " + b + " равно " + result + ".");
                    break;
            }
        }
    }
}
