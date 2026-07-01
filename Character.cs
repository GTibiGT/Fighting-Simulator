using System;
using System.Collections.Generic;

namespace CharacterSelect
{
    public class Character
    {
        public static int Random_damage()
        {
            int dmg_chance = Random.Shared.Next(20, 41);
            return dmg_chance;
        }
        public string Name { get; set; } = "";
        public int Health { get; set; } = 100;
        public int Stamina { get; set; } = 100;
        public Dictionary<int, Dictionary<string, List<int>>> Moves { get; set; } = new Dictionary<int, Dictionary<string, List<int>>>();
    }

    public class Boxer : Character
    {
        public Boxer()
        {
            Name = "Boxer";

            Moves.Add(1, new Dictionary<string, List<int>> { { "Jab", new List<int> { 8, 15 } } });
            Moves.Add(2, new Dictionary<string, List<int>> { { "Cross", new List<int> { 14, 24 } } });
            Moves.Add(3, new Dictionary<string, List<int>> { { "Hook", new List<int> { 20, 32 } } });
            Moves.Add(4, new Dictionary<string, List<int>> { { "Uppercut", new List<int> { 24, Random_damage() } } });
            Moves.Add(5, new Dictionary<string, List<int>> { { "Block", new List<int> { 10, 0 } } });

            Health = 100;
            Stamina = 85;
        }
    }

    public class Wrestler : Character
    {
        public Wrestler()
        {
            Name = "Wrestler";

            Moves.Add(1, new Dictionary<string, List<int>> { { "Takedown", new List<int> { 14, 18 } } });
            Moves.Add(2, new Dictionary<string, List<int>> { { "Suplex", new List<int> { 28, 38 } } });
            Moves.Add(3, new Dictionary<string, List<int>> { { "Body Slam", new List<int> { 34, 45 } } });
            Moves.Add(4, new Dictionary<string, List<int>> { { "Headlock", new List<int> { 18, 24 } } });
            Moves.Add(5, new Dictionary<string, List<int>> { { "Block", new List<int> { 12, 0 } } });

            Health = 85;
            Stamina = 115;
        }
    }

    public class Kick_Boxer : Character
    {
        public Kick_Boxer()
        {
            Name = "Kick-Boxer";

            Moves.Add(1, new Dictionary<string, List<int>> { { "Jab", new List<int> { 8, 14 } } });
            Moves.Add(2, new Dictionary<string, List<int>> { { "Roundhouse Kick", new List<int> { 32, Random_damage() } } });
            Moves.Add(3, new Dictionary<string, List<int>> { { "Front Kick", new List<int> { 22, 34 } } });
            Moves.Add(4, new Dictionary<string, List<int>> { { "Knee Strike", new List<int> { 18, 28 } } });
            Moves.Add(5, new Dictionary<string, List<int>> { { "Block", new List<int> { 10, 0 } } });

            Health = 95;
            Stamina = 90;
        }
    }
}