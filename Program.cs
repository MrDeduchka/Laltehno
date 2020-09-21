using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод и проверка чисел
            Console.WriteLine("Введите сумму A, рубли и копейки через запятую: рубли,копейки.");
            double A = input_and_verification_money();
            Console.WriteLine("Введите сумму B, рубли и копейки через запятую: рубли,копейки.");
            double B = input_and_verification_money();
            Console.WriteLine("Введите сумму C, рубли и копейки через запятую: рубли,копейки.");
            double C = input_and_verification_money();
            double A1 = A;
            int counter = 1;

            // Решения части а
            while ((A1 * 0.02) <= B)
            {
                A1 = A1 * 1.02;
                counter += 1;       
            }
            Console.WriteLine("За {0} месяца(ев) величина ежемесячного увеличения вклада превысит {1} руб.", counter, B/100);
            
            // Решения части б
            A1 = A;
            counter = 1;
            while (C >= A1)
            {
                Console.WriteLine(A1);
                A1 = A1 * 1.02;
                counter += 1;
                Console.WriteLine(counter);
            }
            Console.WriteLine("Через {0} месяца(ев) размер вклада превысит {1} руб", counter, C/100);

        }

        static double input_and_verification_money()
        {
            double Money;
            // Проверка правильности ввода 
            while (double.TryParse(Console.ReadLine(), out Money) == false || Money > 0 == false)
            {
                Console.WriteLine("Неверный ввод, введите вещественное положительное число");
            }
            // Переводим рубли в копейки
            Money = Money * 100;
            return Money;
        }

    }
}
