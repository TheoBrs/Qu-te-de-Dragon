

using Quête_de_Dragon;

namespace Project_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player= new Player();
            Sword sword1 = new Sword();

            player.INVENTORY.AddItem(sword1);
            Console.Write($"gameId: {player.INVENTORY.INVENTORY[0].Data.gameId}, name: {player.INVENTORY.INVENTORY[0].Data.name}, stat.atk: {player.INVENTORY.INVENTORY[0].Data.stat.atk}, stat.def: {player.INVENTORY.INVENTORY[0].Data.stat.def}");
            Game game= new();
            game.PlayGame();

        }
    }
}