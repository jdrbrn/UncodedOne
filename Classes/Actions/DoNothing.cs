using System;

namespace TheUncodedOne
{
    class DoNothing : IAction
    {
        public void Run(Character character, Battle battle)
        {
            Console.WriteLine($"{character.Name} did NOTHING");
            Console.WriteLine();
        }
    }
}
