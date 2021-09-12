using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    public interface IAttack
    {
        public string Name { get; }
        public AttackData Data { get;  }
    }
}
