using System.Collections.Generic;

namespace TheUncodedOne
{
    public class Character
    {
        public string Name { get; private set; }
        private List<IAction> _actions = new List<IAction>();

        public Character(string name)
        {
            Name = name;
            _actions.Add(new DoNothing());
        }

        public void TakeAction(int index)
        {
            _actions[index].Run(this);
        }
    }
}
