using System;
using System.Collections.Generic;

namespace CharacterSelect
{
    public class Character
    {
        public string Name { get; set; } = "";
        public int Health { get; set; } = 100;
        public int Stamina { get; set; } = 100;
        public Dictionary<int, string> Moves { get; set; } = new Dictionary<int, string>();
    }

    public class Boxer : Character
    {
        public Boxer()
        {
            Name = "Boxer";
            Moves.Add(1, "Jab");
            Moves.Add(2, "Cross");
            Moves.Add(3, "Hook");
            Moves.Add(4, "Uppercut");
            Moves.Add(5, "Block");
        }
    }

    public class Wrestler : Character
    {
        public Wrestler()
        {
            Name = "Wrestler";
            Moves.Add(1, "Takedown");
            Moves.Add(2, "Suplex");
            Moves.Add(3, "Body Slam");
            Moves.Add(4, "Headlock");
            Moves.Add(5, "Block");
        }
    }

    public class Kick_Boxer : Character
    {
        public Kick_Boxer()
        {
            Name = "Kick-Boxer";
            Moves.Add(1, "Jab");
            Moves.Add(2, "Roundhouse Kick");
            Moves.Add(3, "Front Kick");
            Moves.Add(4, "Knee Strike");
            Moves.Add(5, "Block");
        }
    }
}