using System;

namespace TheUncodedOne
{
    public abstract class Player
    {
        private Party _party;
        public Player(Party party)
        {
            _party = party;
        }
        protected abstract IAction PickAction(Battle battle, Character character);

        public void TakeTurn(Battle battle)
        {
            foreach (Character member in _party.Members)
            {
                Console.WriteLine($"It is {member.Name}'s turn");
                PickAction(battle, member).Run(member);
            }
        }
    }
}
