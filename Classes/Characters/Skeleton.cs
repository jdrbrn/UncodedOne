namespace TheUncodedOne
{
    class Skeleton : Character
    {
        public Skeleton(string name = "SKELETON") : base(name)
        {
            CurHealth = MaxHealth = 5;
            StandardAttack = new Attacks.BoneCrunch();
        }
    }
}
