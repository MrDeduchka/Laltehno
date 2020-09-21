using System;

namespace ConsoleApp6
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
            Console.WriteLine("За {0} величина ежемесячного увеличения вклада превысит {1} руб.", MonthsToYaer(counter), B / 100);

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
            Console.WriteLine("Через {0} месяц(ев) размер вклада превысит {1} руб", counter, C / 100);
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

        static string MonthsToYaer(int months)
        { 
            int yaer = months / 12;
            string stYear;     
            switch (yaer)
            {
                case 1:
                case 21:
                case 31:
                case 41:
                case 51:
                case 61:
                case 71:
                case 81:
                case 91:
                    {

                        stYear = "год";
                        break;
                    }
                case 2:
                case 3:
                case 4:
                case 22:
                case 23:
                case 24:
                case 32:
                case 33:
                case 34:
                case 42:
                case 43:
                case 44:
                case 52:
                case 53:
                case 54:
                case 62:
                case 63:
                case 64:
                case 72:
                case 73:
                case 74:
                case 82:
                case 83:
                case 84:
                case 92:
                case 93:
                case 94:
                    {
                        stYear = "года";
                        break;
                    }
                default:
                    {
                        stYear = "лет";
                        break;
                    }
            }
            int months1 = months % 12;
            string[] monthsList = {"Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь", "Январь", "Февраль" };
            return ($"{monthsList[months1]} месяц, через {yaer} {stYear}");
        }
    }
}
