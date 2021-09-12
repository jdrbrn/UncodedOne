using System;
using System.Threading;
using TheUncodedOne;

Party Heroes = new Party(new ComputerPlayer());
Console.Write("What is your name? ");
string input = Console.ReadLine();
Heroes.AddMember(new TrueProgrammer(input));

Party Monsters = new Party(new ComputerPlayer());
Monsters.AddMember(new Skeleton());

Battle game = new Battle(Heroes, Monsters);
game.Run();
