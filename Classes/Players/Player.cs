using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    public abstract class Player
    {
        private Party _party;
        public Player(Party party)
        {
            _party = party;
        }
        protected abstract int PickAction(Battle battle, Character character);

        public void TakeTurn(Battle battle)
        {
            foreach (Character member in _party.Members)
            {
                Console.WriteLine($"It is {member.Name}'s turn");
                int action = PickAction(battle, member);
                member.TakeAction(action);
            }
        }
    }
}
