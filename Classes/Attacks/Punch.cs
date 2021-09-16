namespace TheUncodedOne.Attacks
{
    class Punch : IAttack
    {
        public string Name => "Punch";
        public AttackData Data
        {
            get
            {
                return new AttackData { damage = 1 };
            }
        }
    }
}
