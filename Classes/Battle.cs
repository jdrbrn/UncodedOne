using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheUncodedOne
{
    public class Battle
    {
        private Player _player1;
        private Player _player2;

        public Battle(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
        }

        public void Run()
        {
            //Basic taking turns
            while (true)
            {
                _player1.TakeTurn(this);
                _player2.TakeTurn(this);
                Thread.Sleep(500);
            }
        }
    }
}
