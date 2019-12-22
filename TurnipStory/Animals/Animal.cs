using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
   abstract class Animal
    {
       public string Alias { get; set; }
       public int Damage { get; set; }
       public Animal(string alias, int damage)
        {
            Alias = alias;
            Damage = damage;
        }
      public abstract void CallHelp();

        public abstract void GetStatus(int hp);
    }
}
