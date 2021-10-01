namespace TheUncodedOne.Gear
{
    class Sword : IGear
    {
        private IAttack _attack = new TheUncodedOne.Attacks.Slash();
        public string Name => "Sword";
        public IAttack Attack => _attack;

    }
}
