using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите стоимость товара в копейках: ");
            int Money;
            while (int.TryParse(Console.ReadLine(), out Money) == false || Money > 0 == false || Money < 1000 == false)
            {
                Console.WriteLine("Неверный ввод, введите вещественное положительное число");
            }

            switch (Money/100)
            {
                case 1:
                    {

                        Console.Write("{0} рубль ", Money/100);
                        break;
                    }
                case 2:
                case 3:
                case 4:
                    {
                        Console.Write("{0} рубля ", Money/100);
                        break;
                    }
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        Console.Write("{0} рублей ", Money/100);
                        break;
                    }
            }

            switch (Money % 100)
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

                        Console.Write("{0} копейка", Money % 100);
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
                        Console.Write("{0} копейки", Money % 100);
                        break;
                    }
                default:
                    {
                        Console.Write("{0} копеек", Money % 100);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
