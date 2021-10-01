using System;
using System.Threading;

namespace TheUncodedOne
{
    public class Battle
    {
        private Player _player1;
        private Player _player2;
        private bool _gameOver;
        public bool GameOver
        {
            get
            {
                if (_gameOver) return _gameOver;
                return _gameOver = _player1.Party.Members.Count == 0 || _player2.Party.Members.Count == 0;
            }
        }

        public Battle(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            _gameOver = false;
        }

        public void Run()
        {
            //Basic taking turns
            while (!GameOver)
            {
                _player1.TakeTurn(this);
                if (GameOver) break;
                _player2.TakeTurn(this);
                Thread.Sleep(500);
            }
        }

        public Party GetParty(Character character)
        {
            if (_player1.Party.Members.Contains(character)) return _player1.Party;
            else return _player2.Party;
        }

        public Party GetEnemyParty(Character character)
        {
            if (_player1.Party.Members.Contains(character)) return _player2.Party;
            else return _player1.Party;
        }

        public bool IsGameOver()
        {
            if (_player1.Party.Members.Count < 0 || _player2.Party.Members.Count < 0) return true;
            return false;
        }

        public void DisplayTurnStatus(Character character)
        {
            Console.WriteLine("===============BATTLE================");
            foreach (Character member in _player1.Party.Members)
            {
                Console.WriteLine((character == member ? "-->  " : "     ") + $"{member.Name} ({member.CurHealth}/{member.MaxHealth})");
                Console.WriteLine("        Gear: " + (member.EquippedGear==null? "None" : member.EquippedGear.Name));
            }
            Console.WriteLine("-----------------VS------------------");
            foreach (Character member in _player2.Party.Members)
            {
                Console.WriteLine((character == member ? "-->  " : "     ") + $"{member.Name} ({member.CurHealth}/{member.MaxHealth})");
                Console.WriteLine("        Gear: " + (member.EquippedGear == null ? "None" : member.EquippedGear.Name));
            }
            Console.WriteLine("=====================================");
            Console.WriteLine();
        }
    }
}
