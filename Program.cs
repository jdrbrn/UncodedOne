using System;
using TheUncodedOne;

Party Heroes = new Party();
Console.Write("What is your name? ");
string input = Console.ReadLine();
Heroes.Members.Add(new TrueProgrammer(input));
HumanPlayer HeroPlayer = new HumanPlayer(Heroes);

Party MonstersRound1 = new Party();
MonstersRound1.Members.Add(new Skeleton());
ComputerPlayer EnemyRound1 = new ComputerPlayer(MonstersRound1);

Party Monsters2 = new Party();
Monsters2.Members.Add(new Skeleton());
Monsters2.Members.Add(new Skeleton());
ComputerPlayer EnemyRound2 = new ComputerPlayer(Monsters2);

Party MonstersRound3 = new Party();
MonstersRound3.Members.Add(new UncodedOne());
ComputerPlayer EnemyRound3 = new ComputerPlayer(MonstersRound3);

Player[] EnemyTeams = new Player[] { EnemyRound1, EnemyRound2, EnemyRound3 };

for (int i=0; i<EnemyTeams.Length; i++)
{
    new Battle(HeroPlayer, EnemyTeams[i]).Run();
    Console.WriteLine();
    if (HeroPlayer.Party.Members.Count == 0) break;
    if (i<EnemyTeams.Length-1)
    {
        Console.WriteLine("You have won the battle!");
        Console.WriteLine("Prepare for the next one...");
        Console.WriteLine();
    }
}

if (HeroPlayer.Party.Members.Count > 0) Console.Write("You have defeated the Uncoded One!");
else Console.WriteLine("The Uncoded One has prevailed over the heroes...");
