using System;
namespace TheUncodedOne
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Party party) : base(party) { }

        protected override IAction PickAction(Battle battle, Character character)
        {
            Console.WriteLine($"1 - Standard Attack ({character.AttackList[0].Name})");
            Console.WriteLine($"2 - Do Nothing");
            int choice;
            string input;
            do
            {
                Console.Write("What do you want to do? ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out choice) && (choice >= 1 && choice <= 2));

            // Check if we want to attack
            if (choice == 1)
            {
                return new AttackAction(character.AttackList[0], battle.GetEnemyParty(character).Members[0]);
            }
            //Default action is Do Nothing
            return new DoNothing();
        }
    }
}
