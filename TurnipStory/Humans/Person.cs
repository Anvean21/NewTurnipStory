using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
    abstract class Person
    {
        public string Name { get; set; }
        public int Damage { get; set; }
        public Person(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
    }
    interface IHelp
    {
        void CallHelp();

    }
    interface ITry
    {
        void GetStatus(int hp);
    }
}
