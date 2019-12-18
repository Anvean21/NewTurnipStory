using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class GrandDot:Person,IHelp,ITry
    {
        public GrandDot(string name, int damage)
            : base(name, damage) {}
        public void CallHelp()
        {
            Console.WriteLine($"Позвала внучка собачку Жучку");
        }
        public void GetStatus( int hp)
        {
            if (hp >= 0)
            {
                Console.WriteLine("Попытались дед с бабкой и внучкой вытащить репку, ничего не получилось.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Невероятно, дед с бабой и внучкой осилили репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
