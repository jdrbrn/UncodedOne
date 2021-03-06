using System.Collections.Generic;

namespace TheUncodedOne
{
    public class Character
    {
        public string Name { get; private set; }
        public IAttack StandardAttack { get; protected set; }
        public int MaxHealth { get; protected set; }
        public int CurHealth { get; protected set; }
        public IGear EquippedGear;

        public Character(string name)
        {
            Name = name;
        }

        public void TakeDamage(int dmg)
        {
            CurHealth = System.Math.Max(CurHealth - dmg, 0);
        }

        public void Heal(int health)
        {
            CurHealth = System.Math.Min(CurHealth + health, MaxHealth);
        }
    }
}
