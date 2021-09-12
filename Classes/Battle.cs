using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TheUncodedOne
{
    class Battle
    {
        private Party _party1;
        private Party _party2;

        public Battle(Party party1, Party party2)
        {
            _party1 = party1;
            _party2 = party2;
        }

        public void Run()
        {
            //Basic taking turns
            while (true)
            {
                _party1.TakeTurn();
                _party2.TakeTurn();
                Thread.Sleep(500);
            }
        }
    }
}
