using System;

namespace Тема_6.Компьютерный_практикум__4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(3/2);
            //Компьютерный практикум №4 "Конструкция switch/case"
            //Составить программный код к следующим задачам.

            //Задача 1.Дано целое число n, указывающее номер дня недели от 1 до 7.По указанному номеру n вывести название соответствующего дня недели.

            //Задача 2.По номеру месяца вывести название времени года.

            //Задача 3.Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.
            //Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.

            //Задача 4.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

            //Задача 5.По названию месяца выводится количество дней в этом месяце. Принимается, что в феврале 28 дней.

            int day, month;
            char machine, obj;
            string dayMonth;

            //----------------------------------------------------------------------------------------------------------------------------------------

            //Задача 1.Дано целое число n, указывающее номер дня недели от 1 до 7.По указанному номеру n вывести название соответствующего дня недели.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t\t   День недели\n");
            Console.ResetColor();

            Console.Write("Введите номер дня недели: ");
            day = int.Parse(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine($"День №{day}. День недели - Понедельник\n");
                    break;
                case 2:
                    Console.WriteLine($"День №{day}. День недели - Вторник\n");
                    break;
                case 3:
                    Console.WriteLine($"День №{day}. День недели - Среда\n");
                    break;
                case 4:
                    Console.WriteLine($"День №{day}. День недели - Четверг\n");
                    break;
                case 5:
                    Console.WriteLine($"День №{day}. День недели - Пятница\n");
                    break;
                case 6:
                    Console.WriteLine($"День №{day}. День недели - Суббота\n");
                    break;
                case 7:
                    Console.WriteLine($"День №{day}. День недели - Воскресенье\n");
                    break;
                default:
                    Console.WriteLine("Такого дня недели не существует \n");
                    break;
            }

            //Задача 2.По номеру месяца вывести название времени года.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t\t   Время года\n");
            Console.ResetColor();

            Console.Write("Введите номер месяца: ");
            month = int.Parse(Console.ReadLine());

            switch (month)
            {
                case 1:
                    Console.WriteLine($"Месяц №{month}. Время года: Зима\n");
                    break;
                case 2:
                    Console.WriteLine($"Месяц №{month}. Время года: Зима\n");
                    break;
                case 3:
                    Console.WriteLine($"Месяц №{month}. Время года: Весна\n");
                    break;
                case 4:
                    Console.WriteLine($"Месяц №{month}. Время года: Весна\n");
                    break;
                case 5:
                    Console.WriteLine($"Месяц №{month}. Время года: Весна\n");
                    break;
                case 6:
                    Console.WriteLine($"Месяц №{month}. Время года: Лето\n");
                    break;
                case 7:
                    Console.WriteLine($"Месяц №{month}. Время года: Лето\n");
                    break;
                case 8:
                    Console.WriteLine($"Месяц №{month}. Время года: Лето\n");
                    break;
                case 9:
                    Console.WriteLine($"Месяц №{month}. Время года: Осень\n");
                    break;
                case 10:
                    Console.WriteLine($"Месяц №{month}. Время года: Осень\n");
                    break;
                case 11:
                    Console.WriteLine($"Месяц №{month}. Время года: Осень\n");
                    break;
                case 12:
                    Console.WriteLine($"Месяц №{month}. Время года: Зима\n");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует \n");
                    break;
            }

            //Задача 3.Дан признак транспортного средства: a – автомобиль, в – велосипед, м - мотоцикл, с – самолет, п – поезд.
            //Вывести на экран максимальную скорость транспортного средства в зависимости от введенного признака.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t   Признак транспортного средства\n");
            Console.ResetColor();

            Console.Write("Введите первую букву транспортного средства: ");
            machine = char.Parse(Console.ReadLine());

            switch (machine)
            {
                case 'а':
                    Console.WriteLine($"Транспрт: Автомобиль. Максимальная скорость: 415 км/ч \n");
                    break;
                case 'в':
                    Console.WriteLine($"Транспрт: Велосипед. Максимальная скорость: 35 км/ч \n");
                    break;
                case 'м':
                    Console.WriteLine($"Транспрт: Мотоцикл. Максимальная скорость: 200 км/ч \n");
                    break;
                case 'с':
                    Console.WriteLine($"Транспрт: Самолёт. Максимальная скорость: 11230 км/ч \n");
                    break;
                case 'п':
                    Console.WriteLine($"Транспрт: Поезд. Максимальная скорость: 603 км/ч \n");
                    break;
                default:
                    Console.WriteLine("Нужно ввести на выбор: а, в, м, с, т \n");
                    break;
            }

            //Задача 4.Вывести название предмета по введенной первой букве: ф – физика, м – математика, и – история, г – география, б – биология.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t\tНазвание предмета\n");
            Console.ResetColor();

            Console.Write("Введите первую букву предмета(урока): ");
            obj = char.Parse(Console.ReadLine());

            switch (obj)
            {
                case 'ф':
                    Console.WriteLine($"Предмет: Физика \n");
                    break;
                case 'м':
                    Console.WriteLine($"Предмет: Математика \n");
                    break;
                case 'и':
                    Console.WriteLine($"Предмет: История \n");
                    break;
                case 'г':
                    Console.WriteLine($"Предмет: География \n");
                    break;
                case 'б':
                    Console.WriteLine($"Предмет: Биология \n");
                    break;
                default:
                    Console.WriteLine("Нужно ввести на выбор: ф, м, и, г, б \n");
                    break;
            }

            //Задача 5.По названию месяца выводится количество дней в этом месяце. Принимается, что в феврале 28 дней.

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t       Кол-во дней в месяце\n");
            Console.ResetColor();

            Console.Write("Введите название месяца: ");
            dayMonth = Console.ReadLine();

            switch (dayMonth)
            {
                case "Январь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Февраль":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 28 дней \n");
                    break;
                case "Март":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Апрель":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 30 дней \n");
                    break;
                case "Май":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Июнь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Июль":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 30 дней \n");
                    break;
                case "Август":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Сентябрь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 30 дней \n");
                    break;
                case "Октябрь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                case "Ноябрь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 30 дней \n");
                    break;
                case "Декабрь":
                    Console.WriteLine($"Месяц: {dayMonth}. В нём 31 день \n");
                    break;
                default:
                    Console.WriteLine("Такого месяца не существует либо Вы ввели название месяца с прописной буквы\n");
                    break;
            }

            //Квадратное уравнение

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t\t\t\tКвадратное уравнение\n");
            Console.ResetColor();

            double x, x1, x2, a, b, c, D;

            Console.Write("Введите число А: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Введите число B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Введите число C: ");
            c = int.Parse(Console.ReadLine());

            D = Math.Pow(b, 2) - 4 * a * c;

            if (D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"\nX1 = {Math.Round(x1)}");
                Console.WriteLine($"X2 = {Math.Round(x2)}\n");
            }
            else if (D == 0)
            {
                x = -b / (2 * a);
                Console.WriteLine($"\nX = {Math.Round(x)}\n");
            }
            else
            {
                Console.WriteLine($"\nКвадратное уравнение не имеет корней\n");
            }

            //Конец

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Press any key to continue...");
            Console.ResetColor();
            Console.ReadKey();

        }
    }
}
