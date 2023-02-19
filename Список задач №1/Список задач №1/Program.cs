using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Список_задач__1
{
    internal class Program
    {
        static void Head(string s)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorLeft = Console.WindowWidth / 2 - s.Length / 2;
            Console.WriteLine(s);
            Console.ResetColor();
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //Светофор без жёлтого сигнала
            Program.Head("Светофор без жёлтого сигнала");

            Console.Write("Введите кол-во минут, прошедших с начала этого часа: ");
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i <= t; i++)
            {
                if (0<=i%6 && i%6<=3)
                {
                    Console.WriteLine($"Минута {i}. Светофор зелёный");
                }
                else
                {
                    Console.WriteLine($"Минута {i}. Светофор красный");
                }
            }

            Console.WriteLine();

            #region Старояпонский календарь
            ////Старояпонский календарь
            //Program.Head("Старояпонский календарь");

            //const int constYear = 1984;

            //Console.Write("Введите год нашей эры: ");
            //int year = int.Parse(Console.ReadLine());
            //int animal = year - constYear % 12;
            //string str = "";
            //switch (animal)
            //{
            //    case 0:
            //        str = "Rat";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 1:
            //        str = "Ox";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 2:
            //        str = "Tiger";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 3:
            //        str = "Hare";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 4:
            //        str = "Dragon";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 5:
            //        str = "Snake";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 6:
            //        str = "Horse";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 7:
            //        str = "Sheep";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 8:
            //        str = "Monkey";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 9:
            //        str = "Rooster";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 10:
            //        str = "Dog";
            //        Console.WriteLine($"{str}");
            //        break;
            //    case 11:
            //        str = "Boar";
            //        Console.WriteLine($"{str}");
            //        break;
            //}

            //for (int i = 1; i <= 60; i++)
            //{
            //    for (int j = 1; j <= 12; j++)
            //    {
            //        if (true)
            //        {

            //        }
            //    }
            //    for (int j = 1; j <= 12; j++)
            //    {

            //    }
            //    for (int j = 1; j <= 12; j++)
            //    {

            //    }
            //    for (int j = 1; j <= 12; j++)
            //    {

            //    }
            //    for (int j = 1; j <= 12; j++)
            //    {

            //    }
            //}
            #endregion

            //Количество цифр в числе
            Program.Head("Количество цифр в числе");

            Console.Write("Введите любое натуральное число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Кол-во цифр в этом числе: {num1.ToString().Length}");

            //Сумма вклада 2%
            Program.Head("Сумма вклада 2%");

            int sumVklada = 1000;
            int percent = 0;
            int month = 3;

            while (sumVklada - 1000 <= 30)
            {
                sumVklada += (sumVklada * 2) / 100;
                percent = sumVklada % 100;
                Console.WriteLine($"{percent}\t{sumVklada}");
            }

            Console.ReadKey();
        }
    }
}
