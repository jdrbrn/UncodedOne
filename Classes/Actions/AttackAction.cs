using System;

namespace TheUncodedOne
{
    class AttackAction : IAction
    {
        private Character _target;
        private IAttack _attack;
        public AttackAction(IAttack attack, Character target)
        {
            _attack = attack;
            _target = target;
        }
        public void Run(Character character)
        {
            Console.WriteLine($"{character.Name} used {_attack.Name} on {_target.Name}");
            Console.WriteLine();
        }
    }
}
