using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int crystalPrice = 5;
            bool isPurchased;

            Console.WriteLine($"Добро подаловать в магазин кристаллов! Только у нас продаются " +
                $"кристаллы по цене {crystalPrice} золотых монет.");
            Console.Write($"Какое кол-во золотых монет в вашем распоряжении? ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько вы хотите приобрести кристаллов? ");
            int crystals = Convert.ToInt32(Console.ReadLine());

            isPurchased = gold >= crystalPrice * crystals;
            crystals *= Convert.ToInt32(isPurchased);
            gold -= crystalPrice * crystals;

            Console.WriteLine($"Теперь у вас {gold} золотых монет и {crystals} кристаллов.");
        }
    }
}
