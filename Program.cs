using System;
using System.Threading;
using TheUncodedOne;

Party Heroes = new Party();
Party Monsters = new Party();
Monsters.AddMember(new Skeleton());

Console.Write("What is your name? ");
string input = Console.ReadLine();
Heroes.AddMember(new TrueProgrammer(input));

//Basic taking turns
while (true)
{
    Heroes.TakeTurn();
    Monsters.TakeTurn();
    Thread.Sleep(500);
}

