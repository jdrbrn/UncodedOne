namespace TheUncodedOne
{
    class TrueProgrammer : Character
    {
        public TrueProgrammer(string name) : base(name)
        {
            CurHealth = MaxHealth = 25;
            Attacks.Add(new Attack { Name = "Punch" });
        }
    }
}
