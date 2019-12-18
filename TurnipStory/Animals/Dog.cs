using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class Dog : Animal, IHelp, ITry
    {
        public Dog(string alies, int damage)
            : base(alies, damage)
        { }

        public void CallHelp()
        {
            Console.WriteLine($"Гав-гав, Жучка зовет на помозь кошку") ;
        }

        public void GetStatus( int hp)
        {
            if (hp >= 0)
            {
                Console.WriteLine("Попытались дед с бабкой, внучкой и Жучкой вытащить репку, ничего не получилось.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Невероятно, дед с бабой, внучкой и Жучкой осилили репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
