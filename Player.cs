namespace text_based_game;

public class Player
{
    private string name;
    private int health;
    private int attackDamage;

    public Player(string name, int health, int attackDamage)
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Damage: {attackDamage}");
    }
}