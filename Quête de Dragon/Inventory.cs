using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Inventory
    {
        List<GameObject> _inventory;

        int _maxInventorySlot;

        public List<GameObject> INVENTORY { get => _inventory; }

        public int MaxInventorySlot { get => _maxInventorySlot; set => _maxInventorySlot = value; }

        public Inventory()
        {
            _inventory = new List<GameObject>();

            _maxInventorySlot= 0;
        }

        public void AddItem(GameObject item)
        {
            if (INVENTORY.Contains(item) && INVENTORY[INVENTORY.IndexOf(item)].IntData["isStackable"] == 1)
            {
                ++INVENTORY[INVENTORY.IndexOf(item)].IntData["itemCount"];
                return;
            }

            if (item.IntData["itemCount"] == _maxInventorySlot)
            {
                Console.WriteLine("Storage space full.");
                return;
            }


            _inventory.Add(item);
            _inventory.Sort();
        }

        public void RemoveItem(GameObject item)
        {
            if (INVENTORY.Contains(item) && INVENTORY[INVENTORY.IndexOf(item)].IntData["isStackable"] == 1)
            {
                INVENTORY[INVENTORY.IndexOf(item)].IntData["itemCount"] -= 1;
                if (INVENTORY[INVENTORY.IndexOf(item)].IntData["itemCount"] == 0)
                {
                    _inventory.Remove(item);
                }
                _inventory.Sort();
                return;
            }

        }
    }
}
