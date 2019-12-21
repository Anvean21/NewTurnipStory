using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using static TurnipStory.GrandMa;
using static TurnipStory.StoryTeller;

namespace TurnipStory
{
    
        delegate void Message();
    class GrandPa : Person,IHelp,ITry
    {
        public delegate void EventDelegate(string message);
        public event EventDelegate GrandPaEvent;
        public GrandPa(string name, int damage)
            : base(name, damage) { }
       public  void Create()
        {
            if (PersonFactory.Rand(1,15)<3)
            {
                try
                {
                    throw new PersonException($"{Name} не посадил репку");
                }
                catch (PersonException exp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникло исключение {exp.Message} ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine($"{Name} посадил репку");
               
            }
        }
        public void CallHelp()
        {

            Console.WriteLine($"Зовет {Name} бабу ");
            
            if (PersonFactory.Rand(1,15)<3)
            {
                try
                {
                    throw new PersonException($"Баба с внучкой пошли за пенсией и будут не скоро");
                }
                catch
                (PersonException exp)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Возникло исключение: {exp.Message} ");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
        }
        public void GetStatus(int hp)
        { 
            if (hp >= 0)
            {
                Console.WriteLine("Попытался дед вытащить репку, ничего не получилось.");
              
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Невероятно, дед осилил и вытащил репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        public void GPevent()
        {
                if (PersonFactory.Rand(1, 10) < 3)
                {
                Console.ForegroundColor = ConsoleColor.Red;
                GrandPaEvent?.Invoke("Возникло событие : У деда прихватило спину и его отправили в больницу.");
                Console.ReadKey();
                Environment.Exit(0);
            }
                else if (PersonFactory.Rand(1, 15) < 3)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                GrandPaEvent?.Invoke($"Возникло событие : {Name} плюнул, взял у Петровича трактор и выкопал репку");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
