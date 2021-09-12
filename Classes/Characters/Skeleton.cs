namespace TheUncodedOne
{
    class Skeleton : Character
    {
        public Skeleton(string name = "SKELETON") : base(name)
        {
            Attacks.Add(new Attack { Name = "Bone Crunch" });
        }
    }
}
