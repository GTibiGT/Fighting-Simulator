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
        public Dictionary<int, Move> Moves { get; set; }

        public Character()
        {
            Moves = new Dictionary<int, Move>();
        }
    }

    public class Boxer : Character
    {
        public Boxer()
        {
            Name = "Boxer";

            Moves.Add(1, new Move("Jab", 8, 15));
            Moves.Add(2, new Move("Cross", 14, 24));
            Moves.Add(3, new Move("Hook", 20, 32));
            Moves.Add(4, new Move("Uppercut", 24, Random_damage()));
            Moves.Add(5, new Move("Block", 10, 0));

            Health = 100;
            Stamina = 85;
        }
    }

    public class Wrestler : Character
    {
        public Wrestler()
        {
            Name = "Wrestler";

            Moves.Add(1, new Move("Takedown", 14, 18));
            Moves.Add(2, new Move("Suplex", 28, 38));
            Moves.Add(3, new Move("Body Slam", 34, 45));
            Moves.Add(4, new Move("Headlock", 18, 24));
            Moves.Add(5, new Move("Block", 12, 0));

            Health = 85;
            Stamina = 115;
        }
    }

    public class Kick_Boxer : Character
    {
        public Kick_Boxer()
        {
            Name = "Kick-Boxer";

            Moves.Add(1, new Move("Jab", 8, 14));
            Moves.Add(2, new Move("Roundhouse Kick", 32, Random_damage()));
            Moves.Add(3, new Move("Front Kick", 22, 34));
            Moves.Add(4, new Move("Knee Strike", 18, 28));
            Moves.Add(5, new Move("Block", 10, 0));

            Health = 95;
            Stamina = 90;
        }
    }
}