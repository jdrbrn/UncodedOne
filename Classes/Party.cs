using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheUncodedOne
{
    class Party
    {
        private List<Character> _members;

        public Party()
        {
            _members = new List<Character>();
        }

        public void AddMember(Character member)
        {
            _members.Add(member);
        }

        public void RemoveMember(Character member)
        {
            _members.Remove(member);
        }

        public void TakeTurn()
        {
            foreach (var member in _members) member.TakeTurn();
        }
    }
}
