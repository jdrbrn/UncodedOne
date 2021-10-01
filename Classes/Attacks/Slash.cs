namespace TheUncodedOne.Attacks
{
    class Slash : IAttack
    {
        public string Name => "Slash";
        public AttackData Data
        {
            get
            {
                return new AttackData { damage = 2 };
            }
        }
    }
}
