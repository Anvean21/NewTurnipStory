using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static TurnipStory.GrandPa;


namespace TurnipStory
{
    class StoryTeller
    {
        async public static void Sttory()
        {
            Operation pull = (x, y) => x - y;
            var grandpa = PersonFactory.CreateRandom();
            //GrandPa grandpa = new GrandPa("Дед", PersonFactory.Rand(30, 50));
            grandpa.GrandPaEvent += ShowMess;
            grandpa.Create();
            Turnip turnip = new Turnip();
            turnip.TurnipCreate();
            turnip.Hp = pull(turnip.Hp, grandpa.Damage);
            grandpa.GetStatus(turnip.Hp);
            grandpa.GPevent();
            grandpa.CallHelp();


            await Task.Delay(3000);
            GrandMa grandma = new GrandMa("Бабка", PersonFactory.Rand(20, 35));
            grandma.GrandMaEvent += ShowMess;
            turnip.Hp = pull(turnip.Hp, grandma.Damage);
            grandma.GMevent();
            grandma.GetStatus(turnip.Hp);

            grandma.CallHelp();
            await Task.Delay(3000);


            GrandDot granddot = new GrandDot("Внучка", PersonFactory.Rand(10, 20));
            turnip.Hp = pull(turnip.Hp, granddot.Damage);
            granddot.GetStatus(turnip.Hp);
            grandpa.GPevent();
            granddot.CallHelp();
            await Task.Delay(3000);


            List<Animal> lst = new List<Animal>();
            lst.Add(new Cat("Кошка", PersonFactory.Rand(5, 15)));
            lst.Add(new Dog("Жучка", PersonFactory.Rand(10, 30)));
            lst.Add(new Mouse("Мышка", PersonFactory.Rand(1, 7)));

            foreach (var animal in lst)
            {
                turnip.Hp = pull(turnip.Hp, animal.Damage);
                animal.GetStatus(turnip.Hp);
                animal.CallHelp();
                await Task.Delay(3000);
            }
        }
        public static void ShowMess(string message)
        {
            Console.WriteLine(message);
        }
    }
}
