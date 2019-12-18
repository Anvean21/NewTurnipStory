using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class StoryTeller
    {
        
     async   public static void Sttory()
        {

            Operation pull = (x, y) => x - y;
            GrandPa grandpa = new GrandPa("Дед", Randomizer.Rand(30, 50));

            grandpa.GrandPaEvent += ShowMess;
            grandpa.Create();

            await Task.Delay(1000);
            Turnip turnip = new Turnip();
            turnip.TurnipCreate();
            await Task.Delay(2000);
            turnip.Hp = pull(turnip.Hp, grandpa.Damage);
            grandpa.GetStatus(turnip.Hp);
            grandpa.GPevent();
            await Task.Delay(3000);
            grandpa.CallHelp();
            await Task.Delay(3000);


            GrandMa grandma = new GrandMa("Бабка", Randomizer.Rand(20, 35));
            grandma.GrandMaEvent += ShowMess;
            turnip.Hp = pull(turnip.Hp, grandma.Damage);
            grandma.GMevent();
            grandma.GetStatus(turnip.Hp);

            await Task.Delay(3000);
            grandma.CallHelp();
            await Task.Delay(3000);


            GrandDot granddot = new GrandDot("Внучка", Randomizer.Rand(10, 20));
            turnip.Hp = pull(turnip.Hp, granddot.Damage);
            granddot.GetStatus(turnip.Hp);
            grandpa.GPevent();
            await Task.Delay(3000);
            granddot.CallHelp();
            await Task.Delay(3000);


            Dog dog = new Dog("Жучка", Randomizer.Rand(10, 30));
            turnip.Hp = pull(turnip.Hp, dog.Damage);
            dog.GetStatus(turnip.Hp);
            await Task.Delay(3000);
            dog.CallHelp();
            await Task.Delay(3000);


            Cat cat = new Cat("Кошка", Randomizer.Rand(5, 15));
            turnip.Hp = pull(turnip.Hp, cat.Damage);
            cat.GetStatus(turnip.Hp);
            await Task.Delay(3000);
            cat.CallHelp();
            await Task.Delay(3000);


            Mouse mouse = new Mouse("Мышка", Randomizer.Rand(1, 7));
            turnip.Hp = pull(turnip.Hp, mouse.Damage);
            await Task.Delay(3000);
            mouse.GetStatus(turnip.Hp);
            

        }

        public static void ShowMess(string message)
        {
            Console.WriteLine(message);
        }
    }
}
