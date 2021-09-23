using System;

public static class MenuHelper
{
    public static void DisplayList(string[] entries)
    {
        for (int i=0; i<entries.Length; i++)
        {
            Console.WriteLine($"{i + 1}) {entries[i]}");
        }
    }

    public static int GetInputFromList(string[] entries, string prompt)
    {
        int choice;
        string input;
        DisplayList(entries);
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine();
        } while (!Int32.TryParse(input, out choice) || !(choice >0 && choice <= entries.Length));
        return choice-1;
    }
}
