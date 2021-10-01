using System;

namespace TheUncodedOne
{
    class GearAction : IAction
    {
        private IGear _gear;
        public GearAction(IGear gear)
        {
            _gear = gear;
        }
        public void Run(Character character, Battle battle)
        {
            if (character.EquippedGear != null)
            {
                battle.GetParty(character).Gear.Add(character.EquippedGear);
                Console.WriteLine($"{character.Name} unequiped a {character.EquippedGear.Name}");
            }
            character.EquippedGear = _gear;
            battle.GetParty(character).Gear.Remove(_gear);
            Console.WriteLine($"{character.Name} equipped a {_gear.Name}");
        }
    }
}
