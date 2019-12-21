using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


            Dog dog = new Dog("Жучка", PersonFactory.Rand(10, 30));
            turnip.Hp = pull(turnip.Hp, dog.Damage);
            dog.GetStatus(turnip.Hp);
            dog.CallHelp();
            await Task.Delay(3000);


            Cat cat = new Cat("Кошка", PersonFactory.Rand(5, 15));
            turnip.Hp = pull(turnip.Hp, cat.Damage);
            cat.GetStatus(turnip.Hp);
            cat.CallHelp();
            await Task.Delay(3000);


            Mouse mouse = new Mouse("Мышка", PersonFactory.Rand(1, 7));
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
