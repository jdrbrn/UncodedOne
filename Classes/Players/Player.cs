using System;

namespace TheUncodedOne
{
    public abstract class Player
    {
        public Party Party;
        public Player(Party party)
        {
            Party = party;
        }
        protected abstract IAction PickAction(Battle battle, Character character);

        public void TakeTurn(Battle battle)
        {
            foreach (Character member in Party.Members)
            {
                Console.WriteLine($"It is {member.Name}'s turn");
                PickAction(battle, member).Run(member, battle);
                if (battle.GameOver) break;
            }
        }
    }
}
