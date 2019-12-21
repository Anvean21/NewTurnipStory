using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TurnipStory.GrandPa;

namespace TurnipStory
{
    public delegate void Graaand();
    class GrandMa : Person,IHelp,ITry
    {
        public event EventDelegate GrandMaEvent;
        public GrandMa(string name, int damage)
            : base(name, damage) { }
        public void CallHelp()
        {
            Console.WriteLine($"Зовет {Name} внучку");
            if (PersonFactory.Rand(1, 15) < 3)
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
            if (PersonFactory.Rand(1, 15) < 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                GrandMaEvent?.Invoke("Возникло событие : Принесли пенсию, и бабуля поехала на шоппинг.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            
        }
        
    }
}
