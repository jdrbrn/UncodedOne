using System.Collections.Generic;

namespace TheUncodedOne
{
    public class Character
    {
        public string Name { get; private set; }
        public List<IAttack> AttackList = new List<IAttack>();
        public int MaxHealth { get; protected set; }
        public int CurHealth { get; protected set; }

        public Character(string name)
        {
            Name = name;
        }
    }
}
