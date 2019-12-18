using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurnipStory.GrandPa;

namespace TurnipStory
{
    class GrandMa : Person,IHelp,ITry
    {
        public event EventDelegate GrandMaEvent;
        public GrandMa(string name, int damage)
            : base(name, damage) { }
        public void CallHelp()
        {
            Console.WriteLine($"Зовет {Name} внучку");
            if (Randomizer.Rand(1, 15) < 5)
            {
                try
                {
                    throw new Exception($"Внучка ушла на гульки");
                }
                catch
                (Exception exp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникло исключение: {exp.Message} ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        public void GetStatus( int hp)
        {
            if(hp >= 0)
            {
                Console.WriteLine("Попытались дед с бабкой вытащить репку, ничего не получилось.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Невероятно, дед с бабой вдвоем вытащили репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void GMevent()
        {
            if (Randomizer.Rand(1, 10) < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                GrandMaEvent?.Invoke("Возникло событие : Принесли пенсию, и бабка поехала на шоппинг.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
    }
}
