namespace TheUncodedOne
{
    class TrueProgrammer : Character
    {
        public TrueProgrammer(string name) : base(name)
        {
            CurHealth = MaxHealth = 25;
            AttackList.Add(new Attacks.Punch());
        }
    }
}
