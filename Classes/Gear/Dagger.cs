namespace TheUncodedOne.Gear
{
    class Dagger : IGear
    {
        private IAttack _attack = new TheUncodedOne.Attacks.Stab();
        public string Name => "Dagger";
        public IAttack Attack => _attack;

    }
}
