using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class Mouse : Animal, ITry
    {
        public Mouse(string alies, int damage)
            : base(alies, damage)
        { }

        public override void CallHelp()
        {
            
        }

        public override void GetStatus(int hp)
        {
            if (hp >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Попытались дед с бабкой, внучкой, Жучкой, кошкой и мышкой вытащить репку, ничего не получилось.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Всеми силами, вытащили репку:)");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

    }
}
