using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne.Attacks
{
    class Punch : IAttack
    {
        public string Name => "Punch";
        public AttackData Data
        {
            get
            {
                return new AttackData { damage = 1 };
            }
        }
    }
}
