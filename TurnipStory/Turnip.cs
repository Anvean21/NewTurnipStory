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
       
       async public  void TurnipCreate()
        {

            Name = "Репка";
            Hp = PersonFactory.Rand(75,150);
            if (Hp < 100)
            {
                Console.WriteLine($"И выросла {Name} не большая ");
                await Task.Delay(2000);
            }
            else
            {
                Console.WriteLine($"И выросла {Name} большая прeбольшая ");
                await Task.Delay(2000);
            }
        }
    }
}
