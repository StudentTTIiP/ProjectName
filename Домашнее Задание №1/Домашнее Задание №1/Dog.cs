using System;

namespace Домашнее_Задание__1
{
    public class Dog
    {
        public string Name;

        public int Age;

        public int HungryLevel;

        public void Voice()
        {
            if (HungryLevel <= 0)
            {
                Console.WriteLine($"[{Name}]: Я не могу гавкать.. накорми меня.. :(");
                return;
            }
            Console.WriteLine($"[{Name}]: Гав!");
            HungryLevel -= 30;
        }
        public int GetHungry()
        {
            return HungryLevel;
        }
        public void Feed()
        {
            if (HungryLevel < 100)
                HungryLevel += 10;
            Console.WriteLine($"[{Name}]: Ням - ням");

            Console.WriteLine($"[{ Name}]:Я сытый. Моя сытость = {HungryLevel}");
        }
    }
}
