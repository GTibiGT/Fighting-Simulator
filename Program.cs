using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using CharacterSelect;

class Program
{
    public static void PlayerTurn(Character player, Character enemy)
    {
        Console.WriteLine("Choose a move:");

        foreach (var move in player.Moves)
        {
            Console.WriteLine($"{move.Key}. {move.Value.Name} (Cost: {move.Value.StaminaCost}, Damage: {move.Value.Damage})");
        }

        Console.Write("Choose a number (1-5): ");
        int choice = Convert.ToInt32(Console.ReadLine());

        // Perform move
        Move selectedMove = player.Moves[choice];

        player.Stamina -= selectedMove.StaminaCost;

        if (selectedMove.Name == "Block"){
            player.isBlocking = true;
            Console.WriteLine($"{player.Name} is blocking!");
            return;
        }

        int damage = selectedMove.Damage;

        if (enemy.isBlocking)
        {
            damage = 0;
            enemy.isBlocking = false;
            Console.WriteLine($"{enemy.Name} blocked the attack!");
        }

        enemy.Health -= damage;

        Console.WriteLine();
        Console.WriteLine($"{player.Name} used {selectedMove.Name}!");
        Console.WriteLine($"{enemy.Name} took {selectedMove.Damage} damage.");

        if (player.Stamina <= 0)
        {
            Console.WriteLine($"{player.Name} is exhausted and can no longer fight!");
            Console.WriteLine($"{enemy.Name} wins!");
            return;
        }
    }

    public static void EnemyTurn(Character enemy, Character player)
    {
        Random rand = new Random();

        int choice = rand.Next(1, 6);

        // Perform move
        Move move = enemy.Moves[choice];

        enemy.Stamina -= move.StaminaCost;

        if (move.Name == "Block"){
            enemy.isBlocking = true;
            Console.WriteLine($"{enemy.Name} is blocking!");
            Console.ReadLine();
            return;
        }

        int damage = move.Damage;

        if (player.isBlocking)
        {
            damage = 0;
            player.isBlocking = false;
            Console.WriteLine($"{player.Name} blocked the attack!");
        }

        player.Health -= damage;


        Console.WriteLine();
        Console.WriteLine($"{enemy.Name} used {move.Name}!");
        Console.WriteLine($"{player.Name} took {move.Damage} damage.");
    
        if (enemy.Stamina <= 0)
        {
            Console.WriteLine($"{enemy.Name} is exhausted and can no longer fight!");
            Console.WriteLine($"{player.Name} wins!");
            return;
        }
    }

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

        Random random = new Random();

        Character[] fighters =
        {
            new Boxer(),
            new Wrestler(),
            new Kick_Boxer()
        };

        Character p2 = fighters[random.Next(fighters.Length)];

        Console.WriteLine($"\nSo you chose: The {p1.Name}");
        Console.WriteLine($"Health: {p1.Health}");
        Console.WriteLine($"Stamina: {p1.Stamina}");

        Console.WriteLine("\nYour moves:");

        foreach (var move in p1.Moves)
        {
            Console.WriteLine($"{move.Key}. {move.Value.Name} (Cost: {move.Value.StaminaCost}, Damage: {move.Value.Damage})");
        }

        Console.WriteLine("Get ready!");
        Console.WriteLine("FIGHT!");

        while (p1.Health > 0 && p2.Health > 0)
        {
            Console.Clear();
            Console.WriteLine($"You are {p1.Name}: {p1.Health} HP | {p1.Stamina} Stamina");
            Console.WriteLine($"Opponent is {p2.Name}: {p2.Health} HP | {p2.Stamina} Stamina");
            Console.WriteLine();

            // Player Turn
            PlayerTurn(p1, p2);

            if (p2.Health <= 0)
                break;

            // Enemy Turn
            EnemyTurn(p2, p1);

            if (p1.Health <= 0)
                break;
        }
        if (p1.Health <= 0){
            Console.WriteLine($"{p2.Name} Wins!");
        }
        else{
            Console.WriteLine($"{p1.Name} Wins!");
        }
    }
}