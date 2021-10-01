using System;
using System.Collections.Generic;
using System.Linq;

namespace TheUncodedOne
{
    class HumanPlayer : Player
    {
        public HumanPlayer(Party party) : base(party) { }

        protected override IAction PickAction(Battle battle, Character character)
        {
            string[] gameOptions = new string[] { $"Attack", "Use Item", "Equip Gear", "Do Nothing"};
            int choice = MenuHelper.GetInputFromArray(gameOptions, "What do you want to do? ");

            // Check if we want to attack
            switch (choice)
            {
                case 0: return PickAttack(battle, character);
                case 1: return PickItem(battle, character);
                case 2: return PickGear(battle, character);
                default: return new DoNothing();
            }
        }

        IAction PickItem(Battle battle, Character character)
        {
            List<IItem> items = battle.GetParty(character).Items;
            List<string> choices = items.Select(i => i.Name + " (" + i.Details + ")").ToList();
            choices.Add("None (Go Back)");
            int choice = MenuHelper.GetInputFromArray(choices.ToArray(), "Use what item? ");
            if (choice == items.Count)
            {
                return PickAction(battle, character);
            }
            return new ItemAction(items[choice]);
        }

        IAction PickAttack(Battle battle, Character character)
        {
            List<IAttack> attacks = new List<IAttack> { character.StandardAttack};
            if (character.EquippedGear != null) attacks.Add(character.EquippedGear.Attack);
            List<string> choices = attacks.Select(i => i.Name).ToList();
            choices.Add("None (Go Back)");
            int choice = MenuHelper.GetInputFromArray(choices.ToArray(), "Use what attack? ");
            if (choice == attacks.Count)
            {
                return PickAction(battle, character);
            }
            return new AttackAction(attacks[choice], battle.GetEnemyParty(character).Members[0]);
        }

        IAction PickGear(Battle battle, Character character)
        {
            List<IGear> gear = battle.GetParty(character).Gear;
            List<string> choices = gear.Select(i => i.Name ).ToList();
            choices.Add("None (Go Back)");
            int choice = MenuHelper.GetInputFromArray(choices.ToArray(), "Equip what? ");
            if (choice == gear.Count)
            {
                return PickAction(battle, character);
            }
            return new GearAction(gear[choice]);
        }
    }
}
