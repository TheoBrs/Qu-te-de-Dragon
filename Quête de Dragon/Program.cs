

using Quête_de_Dragon;

namespace Project_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player;
            player = new Player();
            Sword sword1;
            sword1 = new Sword();

            player.Inventory.AddItem(sword1);
            Console.Write($"gameId: {player.Inventory.INVENTORY[0].IntData["id"]}, name: {player.Inventory.INVENTORY[0].StringData["name"]}, stat.atk: {player.Inventory.INVENTORY[0].IntData["atk"]}");
            
        }
    }
}