using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    class Turnip
    {
       public string Name { get; set; }
        public int  Hp { get; set; }
       
        public  void TurnipCreate()
        {

            Name = "Репка";
            Hp = Randomizer.Rand(75,150);
            if (Hp < 100)
            {
                Console.WriteLine($"И выросла {Name} не большая ");
            }
            else
            {
                Console.WriteLine($"И выросла {Name} большая прeбольшая ");
            }
        }
    }
}
