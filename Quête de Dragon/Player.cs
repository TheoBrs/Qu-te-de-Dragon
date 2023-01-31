using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Player : GameObject
    {
        //public override ItemData Data { get; set; }

        Inventory _playerInventory;
        public Inventory Inventory { get => _playerInventory; }

        public Player()
        {
            _playerInventory = new Inventory();

            Inventory.MaxInventorySlot = 64;

            IntData.Add("id", 0);
            StringData.Add("name", string.Empty);
            StringData.Add("type", string.Empty);
            IntData.Add("itemCount", 0);
            IntData.Add("isStackable", 0);
            IntData.Add("lvl", 0);
            IntData.Add("pv", 0);
            IntData.Add("pvMax", 0);
            IntData.Add("pm", 0);
            IntData.Add("pmMax", 0);
            IntData.Add("atk", 0);
            IntData.Add("atkMag", 0);
            IntData.Add("def", 0);
            IntData.Add("defMag", 0);
            IntData.Add("vit", 0);
        }

        public Player(string name)
        {
            _playerInventory = new Inventory();

            Inventory.MaxInventorySlot = 64;

            IntData.Add("Id", 0);
            StringData.Add("name", string.Empty);
            StringData.Add("type", string.Empty);
            IntData.Add("itemCount", 0);
            IntData.Add("isStackable", 0);
            IntData.Add("lvl", 0);
            IntData.Add("pv", 0);
            IntData.Add("pvMax", 0);
            IntData.Add("pm", 0);
            IntData.Add("pmMax", 0);
            IntData.Add("atk", 0);
            IntData.Add("atkMag", 0);
            IntData.Add("def", 0);
            IntData.Add("defMag", 0);
            IntData.Add("vit", 0);
        }
    }
}