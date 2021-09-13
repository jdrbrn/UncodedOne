namespace TheUncodedOne
{
    class UncodedOne : Character
    {
        public UncodedOne(string name = "The Uncoded One") : base(name)
        {
            CurHealth = MaxHealth = 15;
            AttackList.Add(new Attacks.Unravel());
        }
    }
}
