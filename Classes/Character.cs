using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    class Character
    {
        public string Name { get; private set; }

        public Character(string name)
        {
            Name = name;
        }

        public void TakeTurn()
        {
            Console.WriteLine($"It is {Name}'s turn...");
            // Do nothing
            Console.WriteLine($"{Name} did NOTHING");
            Console.WriteLine();
        }
    }
}
