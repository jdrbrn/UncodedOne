namespace TheUncodedOne
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Party party) : base(party) { }

        protected override IAction PickAction(Battle battle, Character character)
        {
            string[] gameOptions = new string[] { $"Standard Attack ({character.AttackList[0].Name})", "Do Nothing"};
            int choice = MenuHelper.GetInputFromList(gameOptions, "What do you want to do? ");

            // Check if we want to attack
            switch (choice)
            {     
                case 0: return new AttackAction(character.AttackList[0], battle.GetEnemyParty(character).Members[0]);
                default: return new DoNothing();
            }
        }
    }
}
