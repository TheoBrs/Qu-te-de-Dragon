using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Quête_de_Dragon.GameObject;

namespace Quête_de_Dragon
{
    public class Player : GameObject
    {
        Inventory _playerInventory;

        public Player() 
        {
            _playerInventory = new Inventory();
            _playerInventory.MAXSLOT = 64;
            _itemData = new ItemData()
            {
                gameId = 1,
                name = "Sword",
                stat =
                {
                    atk = 5,
                    def = 15,
                },
            };
        }

        public Inventory INVENTORY { get => _playerInventory; }
        
    }
}