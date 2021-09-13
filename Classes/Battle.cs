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

            if (_player1.Party.Members.Count > 0) Console.WriteLine("The heroes have defeated the Uncoded One!");
            else Console.WriteLine("The heroes have lost...");
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
    }
}
