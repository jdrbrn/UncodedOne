namespace TheUncodedOne
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(Party party) : base(party) { }
        static System.Random rng = new System.Random();

        protected override IAction PickAction(Battle battle, Character character)
        {
            // Check if we want to attack

            // If have health potions, health<50% use potion 25% of time
            float healthPercentage = (float)character.CurHealth / character.MaxHealth;
            if ( (battle.GetParty(character).Items.Count>0)&& (healthPercentage < .5) && rng.Next(4)==0)
            {
                return new ItemAction(battle.GetParty(character).Items[0]);
            }
            else
            {
                return new AttackAction(character.AttackList[0], battle.GetEnemyParty(character).Members[0]);
            }
            //Default action is Do Nothing
            //return new DoNothing();
        }
    }
}
