using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1 "Номер месяца"

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t\t   Номер месяца");
            Console.ResetColor();

            Console.Write("Введите номер месяца: ");
            int month = int.Parse(Console.ReadLine());

            if (12 - month == 1)
            {
                Console.WriteLine($"До конца года остался {12 - month} месяц");
            }
            else if (12 - month > 1 && 12 - month < 5)
            {
                Console.WriteLine($"До конца года осталось {12 - month} месяца");
            }
            else if (12 - month > 4 && 12 - month < 12)
            {
                Console.WriteLine($"До конца года осталось {12 - month} месяцев");
            }
            else if (month == 12)
            {
                Console.WriteLine($"До конца года осталось меньше 1 месяца");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("В году всего 12 месяцев!");
                Console.ResetColor();
            }
            Console.WriteLine();

            //Ex 2 "Регистрация и вход"

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t\tРегистрация и вход");
            Console.WriteLine("Регистрация\n");
            Console.ResetColor();

            Console.Write("Введите логин: ");
            string myLog = Console.ReadLine();
            if (myLog.Length >= 6)
            {
                Console.Write("Введите пароль: ");
                string myPas = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВход\n");
                Console.ResetColor();

                Console.Write("Введите логин: ");
                string myLogOut = Console.ReadLine();
                Console.Write("Введите пароль: ");
                string myPasOut = Console.ReadLine();
                if (myPas == myPasOut && myLogOut == myLog)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("\nВы вошли в кабинет!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nВы ввели некорректный логин или пароль!");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Логин должен быть не менее 6 символов!");
                Console.ResetColor();
            }

            //Ex 3 "Цикл"

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t\t\t\t   Цикл с цифрами");
            Console.ResetColor();

            Console.Write("Введите число: ");
            int num1 = int.Parse(Console.ReadLine());
            int count = 0;
            int checkpoint = num1;

            while (num1 > 0)
            {
                num1 /= 10;
                count++;
            }
            Console.WriteLine($"\nКоличество цифр в числе {checkpoint} = {count}");

            Console.ReadLine();

        }
    }
}
