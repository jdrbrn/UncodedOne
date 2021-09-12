using System;

namespace TheUncodedOne
{
    class DoNothing : IAction
    {
        public void Run(Character character)
        {
            Console.WriteLine($"{character.Name} did NOTHING");
            Console.WriteLine();
        }
    }
}
