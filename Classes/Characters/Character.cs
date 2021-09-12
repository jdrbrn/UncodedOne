using System.Collections.Generic;

namespace TheUncodedOne
{
    public class Character
    {
        public string Name { get; private set; }
        public List<Attack> Attacks = new List<Attack>();

        public Character(string name)
        {
            Name = name;
        }
    }
}
