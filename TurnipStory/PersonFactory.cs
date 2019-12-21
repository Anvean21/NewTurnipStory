using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
   static class PersonFactory
    {
        static readonly Random rand = new Random();
        static readonly List<string> names = new List<string> { "Дед", "Иван Петрович", "Иван Иваныч", "Сан-Саныч", "Василий Мифодиевич"};
      

        public static GrandPa CreateRandom()
        {
            var name = names.Random();
            var damage = Rand(30,50);
            

            return new GrandPa(name, damage);
        }

        public static T Random<T>(this IList<T> list) => list[rand.Next(list.Count)];
        public static int Rand(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
    }

}
