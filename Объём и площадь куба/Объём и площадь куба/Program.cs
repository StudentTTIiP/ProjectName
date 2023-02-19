using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Объём_и_площадь_куба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, V, S;
            Console.Write("Введите сторону куба: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------");

            V = Math.Pow(a, 3);
            S = 6 * (Math.Pow(a, 2));

            Console.WriteLine("Объём куба равен: " + V);
            Console.WriteLine("Площадь поверхнотей куба равен: " + S);

            Console.ReadLine();
        }
    }
}
