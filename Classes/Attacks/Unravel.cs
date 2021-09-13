using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne.Attacks
{
    class Unravel : IAttack
    {
        private static readonly Random rng = new Random();
        public string Name => "Unravel";
        public AttackData Data
        {
            get
            {
                return new AttackData { damage = rng.Next(3) };
            }
        }
    }
}
