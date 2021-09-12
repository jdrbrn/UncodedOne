namespace TheUncodedOne
{
    class Skeleton : Character
    {
        public Skeleton(string name = "SKELETON") : base(name)
        {
            CurHealth = MaxHealth = 5;
            AttackList.Add(new Attacks.BoneCrunch());
        }
    }
}
