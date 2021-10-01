namespace TheUncodedOne.Attacks
{
    class Stab : IAttack
    {
        public string Name => "Stab";
        public AttackData Data
        {
            get
            {
                return new AttackData { damage = 1 };
            }
        }
    }
}
