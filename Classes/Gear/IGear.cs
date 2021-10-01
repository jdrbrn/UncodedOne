using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    public interface IGear
    {
        public string Name { get; }
        public IAttack Attack { get; }
    }
}
