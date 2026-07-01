using System;
using System.Collections.Generic;
using CharacterSelect;

class Program
{
    static void Main()
    {
        int num;

        Console.WriteLine("Welcome to *Fighting Simulator*!");
        Console.WriteLine("This is a turn-based game where each character has their own skills.\n");

        Console.WriteLine("Choose your character:");
        Console.WriteLine("1. Boxer");
        Console.WriteLine("2. Wrestler");
        Console.WriteLine("3. Kick-Boxer");

        Console.Write("\nEnter the number corresponding to the style you want to pick: ");

        while (!int.TryParse(Console.ReadLine() ?? "", out num) || num < 1 || num > 3)
        {
            Console.Write("Invalid input. Enter 1, 2, or 3: ");
        }

        Character p1;

        if (num == 1)
        {
            p1 = new Boxer();
        }
        else if (num == 2)
        {
            p1 = new Wrestler();
        }
        else
        {
            p1 = new Kick_Boxer();
        }

        Console.WriteLine($"\nSo you chose: The {p1.Name}");
        Console.WriteLine($"Health: {p1.Health}");
        Console.WriteLine($"Stamina: {p1.Stamina}");

        Console.WriteLine("\nYour moves:");

        foreach (KeyValuePair<int, string> move in p1.Moves)
        {
            Console.WriteLine($"{move.Key}. {move.Value}");
        }
    }
}