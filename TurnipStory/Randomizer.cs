using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{
   public static class Randomizer
    {
        public static int Rand(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        
    }
}
