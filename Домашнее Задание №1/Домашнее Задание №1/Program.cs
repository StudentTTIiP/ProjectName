using System;

namespace Домашнее_Задание__1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Работа с классом собачек

            Console.Title = "Класс собачек";
            Console.SetWindowSize(50,24);
            Dog dog1 = new Dog()
            {
                Name = "Джессика",
                Age = 3,
                HungryLevel = 100
            };

            Dog dog2 = new Dog()
            {
                Name = "Бима",
                Age = 6,
                HungryLevel = 30
            };

            Console.WriteLine($"Возраст Бимы: {dog2.Age}");

            dog1.Voice();

            Console.WriteLine(dog2.HungryLevel);
            dog2.Voice();
            dog2.Voice();
            Console.WriteLine(dog2.HungryLevel);

            //Работа с консолью

            Console.SetWindowSize(50, 20);
            Console.WriteLine("Размер консоли: 50x20");

            Console.Title = "Заголовок консоли";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Текст цианового цвета");

            Console.ResetColor();

            Console.Write("Введите любое двухзначное число: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine($"Перевёрнутое число: {a % 10}{a / 10}");

            
            Console.BackgroundColor = ConsoleColor.Gray;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\nPress any button to continue...");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
