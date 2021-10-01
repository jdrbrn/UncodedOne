using System;
using TheUncodedOne;

Console.WriteLine("You have multiple ways to fight The Uncoded One:");
string[] gameOptions = new string[] { "Human vs Computer", "Computer vs Computer", "Human vs Human" };
int gameTypeChoice = MenuHelper.GetInputFromArray(gameOptions, "How should the fight go? ");

Party Heroes = new Party();
Console.Write("What is the name of the hero? ");
string name = Console.ReadLine();
Heroes.Members.Add(new TrueProgrammer(name));
Player HeroPlayer;
if (gameTypeChoice != 1)
{
    HeroPlayer = new HumanPlayer(Heroes);
}
else
{
    HeroPlayer = new ComputerPlayer(Heroes);
}
Heroes.Items.Add(new TheUncodedOne.Items.HealthPotion());
Heroes.Items.Add(new TheUncodedOne.Items.HealthPotion());
Heroes.Items.Add(new TheUncodedOne.Items.HealthPotion());

Console.Clear();

Party MonstersRound1 = new Party();
MonstersRound1.Members.Add(new Skeleton());

Party MonstersRound2 = new Party();
MonstersRound2.Members.Add(new Skeleton());
MonstersRound2.Members.Add(new Skeleton());

Party MonstersRound3 = new Party();
MonstersRound3.Members.Add(new UncodedOne());

Party[] EnemyTeams = new Party[] { MonstersRound1, MonstersRound2, MonstersRound3 };

for (int i=0; i<EnemyTeams.Length; i++)
{
    Player Enemy;
    if (gameTypeChoice==2)
    {
        Enemy = new HumanPlayer(EnemyTeams[i]);
    }
    else
    {
        Enemy = new ComputerPlayer(EnemyTeams[i]);
    }
    EnemyTeams[i].Items.Add(new TheUncodedOne.Items.HealthPotion());
    new Battle(HeroPlayer, Enemy).Run();
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
