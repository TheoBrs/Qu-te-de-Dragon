using System.IO;

namespace Quête_de_Dragon
{
    public class TeamBuild
    {
        Player _player1;

        Player _player2;

        Player _player3;

        Inventory _inventory;

        Inventory _inventoryBuffer;

        public Inventory Inventory { get => _inventory; set => _inventory = value; }

        public Inventory InventoryBuffer { get => _inventoryBuffer; }

        public Player Player1 { get => _player1; }

        public Player Player2 { get => _player2; }

        public Player Player3 { get => _player3; }

        public TeamBuild()
        {
            _player1 = new Player("name1");
            _player2 = new Player("name2");
            _player3 = new Player("name3");
            _inventory = new Inventory();
            _inventoryBuffer = new Inventory();
        }

        public void DrawMenu()
        {
            
        }

        public void GetPersoStats()
        {
            throw new System.NotImplementedException();
        }

        public void SetPersoObject()
        {
            throw new System.NotImplementedException();
        }

        public void UseObject()
        {
            throw new System.NotImplementedException();
        }

        public void SetPersoAttack()
        {
            throw new System.NotImplementedException();
        }
    }
}