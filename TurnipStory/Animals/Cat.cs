using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class Cat : Animal, IHelp, ITry
    {
        public Cat(string alies, int damage)
            : base(alies, damage)
        { }

        public override void CallHelp()
        {
            Console.WriteLine($"Мяу-мяу, зовет кошка на помощь мышку");
        }

        public override void GetStatus( int hp)
        {
            if (hp >= 0)
            {
                Console.WriteLine("Попытались дед с бабкой, внучкой, Жучкой и кошкой вытащить репку, ничего не получилось.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Дед с бабой, внучкой, Жучкой и кошкой осилили репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

    }
}
