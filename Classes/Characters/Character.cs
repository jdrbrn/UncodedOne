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
        private List<IAction> _actions = new List<IAction>();

        public Character(string name)
        {
            Name = name;
            _actions.Add(new DoNothing());
        }

        public void TakeTurn()
        {
            Console.WriteLine($"It is {Name}'s turn...");
            // Do nothing
            _actions[0].Run(this);
        }
    }
}
