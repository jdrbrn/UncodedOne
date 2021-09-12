namespace TheUncodedOne
{
    class Skeleton : Character
    {
        public Skeleton(string name = "SKELETON") : base(name)
        {
            CurHealth = MaxHealth = 5;
            Attacks.Add(new Attack { Name = "Bone Crunch" });
        }
    }
}
