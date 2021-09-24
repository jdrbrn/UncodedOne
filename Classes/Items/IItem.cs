namespace TheUncodedOne
{
    public interface IItem
    {
        public string Name { get;  }
        public string Details { get;  }
        void Use(Character character, Battle battle);
    }
}
