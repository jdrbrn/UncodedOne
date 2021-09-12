namespace TheUncodedOne
{
    class ComputerPlayer : Player
    {
        public ComputerPlayer(Party party) : base(party) { }

        protected override IAction PickAction(Battle battle, Character character)
        {
            // Check if we want to attack
            if (true)
            {
                return new AttackAction(character.AttackList[0], battle.GetEnemyParty(character).Members[0]);
            }
            //Default action is Do Nothing
            return new DoNothing();
        }
    }
}
