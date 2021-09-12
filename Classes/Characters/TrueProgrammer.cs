namespace TheUncodedOne
{
    class TrueProgrammer : Character
    {
        public TrueProgrammer(string name) : base(name)
        {
            Attacks.Add(new Attack { Name = "Punch" });
        }
    }
}
