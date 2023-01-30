using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Player
    {
        Inventory _playerInventory;

        public Player() 
        {
            _playerInventory = new Inventory();
        }

        public Inventory INVENTORY { get => _playerInventory; }
    }
}