using System.Net.Mime;
using text_based_game;

void StartGame()
{
    Console.Write("What is your name?: ");
    string inputName = Console.ReadLine().ToString();
    
    Player player = new Player(inputName, 80, 10);
}


Console.WriteLine("Start game?");
Console.Write("(y/n): ");
string action = Console.ReadLine().ToString();

if (action.ToLower() == "y")
    StartGame();
else
    System.Environment.Exit(0);

