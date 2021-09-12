using System;
using TheUncodedOne;

Party Heroes = new Party();
Console.Write("What is your name? ");
string input = Console.ReadLine();
Heroes.Members.Add(new TrueProgrammer(input));
ComputerPlayer HeroPlayer = new ComputerPlayer(Heroes);

Party Monsters = new Party();
Monsters.Members.Add(new Skeleton());
ComputerPlayer EnemyPlayer = new ComputerPlayer(Monsters);

Battle game = new Battle(HeroPlayer, EnemyPlayer);
game.Run();
