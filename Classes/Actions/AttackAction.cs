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
            AttackData attackData = _attack.Data;
            Console.WriteLine($"{character.Name} used {_attack.Name} on {_target.Name}");
            _target.TakeDamage(attackData.damage);
            Console.WriteLine($"{_target.Name} was dealt {attackData.damage} damage!");
            Console.WriteLine($"{_target.Name} is at {_target.CurHealth}/{_target.MaxHealth} HP");
            Console.WriteLine();
        }
    }
}
