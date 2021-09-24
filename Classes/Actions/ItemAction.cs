using System;

namespace TheUncodedOne
{
    class ItemAction : IAction
    {
        private IItem _item;
        public ItemAction(IItem item)
        {
            _item = item;
        }
        public void Run(Character character, Battle battle)
        {
            _item.Use(character, battle);
            battle.GetParty(character).Items.Remove(_item);
            Console.WriteLine($"{character.Name} used a {_item.Name}");
        }
    }
}
