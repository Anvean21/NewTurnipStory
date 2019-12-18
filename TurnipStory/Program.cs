using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnipStory
{

    delegate int Operation(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            StoryTeller.Sttory();
            Console.ReadKey();

        }
    }
}
