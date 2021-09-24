namespace TheUncodedOne.Items
{
    class HealthPotion : IItem
    {
        public string Name => "Health Potion";
        public string Details => "Heals 10 HP";

        public void Use(Character character, Battle battle)
        {
            character.Heal(10);
        }
    }
}
