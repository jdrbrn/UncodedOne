using System.Collections.Generic;
using System.Linq;

namespace TheUncodedOne
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Party party) : base(party) { }

        protected override IAction PickAction(Battle battle, Character character)
        {
            string[] gameOptions = new string[] { $"Standard Attack ({character.AttackList[0].Name})", "Use Item", "Do Nothing"};
            int choice = MenuHelper.GetInputFromList(gameOptions, "What do you want to do? ");

            // Check if we want to attack
            switch (choice)
            {
                case 0: return new AttackAction(character.AttackList[0], battle.GetEnemyParty(character).Members[0]);
                case 1: return PickItem(battle, character);
                default: return new DoNothing();
            }
        }

        IAction PickItem(Battle battle, Character character)
        {
            List<IItem> items = battle.GetParty(character).Items;
            List<string> choices = items.Select(i => i.Name + " (" + i.Details + ")").ToList();
            choices.Add("None (Go Back)");
            int choice = MenuHelper.GetInputFromList(choices.ToArray(), "Use what item? ");
            if (choice == items.Count)
            {
                return PickAction(battle, character);
            }
            return new ItemAction(items[choice]);
        }
    }
}
