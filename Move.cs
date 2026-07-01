public class Move
{
    public string Name { get; set; }
    public int StaminaCost { get; set; }
    public int Damage { get; set; }

    public Move(string name, int staminaCost, int damage)
    {
        Name = name;
        StaminaCost = staminaCost;
        Damage = damage;
    }
}