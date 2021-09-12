using System;
using System.Threading;
using TheUncodedOne;

Party Heroes = new Party();
Party Monsters = new Party();

Heroes.AddMember(new Skeleton());
Monsters.AddMember(new Skeleton());

//Basic taking turns
while (true)
{
    Heroes.TakeTurn();
    Monsters.TakeTurn();
    Thread.Sleep(500);
}

