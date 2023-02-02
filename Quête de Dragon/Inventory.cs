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

        public List<GameObject> INVENTORY { get => _inventory; set => _inventory = value; }

        public int MaxInventorySlot { get => _maxInventorySlot; set => _maxInventorySlot = value; }

        public Inventory()
        {
            _inventory = new List<GameObject>();

            _maxInventorySlot = 0;
        }

        public Inventory(Inventory inventory)
        {
            if (inventory.INVENTORY.Count == 0)
                return;
            _inventory = new List<GameObject>();

            for (int i = 0; i < inventory.INVENTORY.Count; ++i)
            {
                _inventory.Add(inventory.INVENTORY[i]);
            }

            _maxInventorySlot = inventory.MaxInventorySlot;
        }

        public void AddItem(GameObject item)
        {
            if (INVENTORY.Contains(item) && INVENTORY[INVENTORY.IndexOf(item)].IsStackable == 1)
            {
                ++INVENTORY[INVENTORY.IndexOf(item)].ItemCount;
                return;
            }

            if (item.ItemCount == _maxInventorySlot)
            {
                Console.WriteLine("Storage space full.");
                return;
            }


            _inventory.Add(item);
        }

        public void RemoveItem(GameObject item)
        {
            if (INVENTORY.Contains(item))
            {
                INVENTORY[INVENTORY.IndexOf(item)].ItemCount -= 1;
                if (INVENTORY[INVENTORY.IndexOf(item)].ItemCount == 0)
                {
                    _inventory.Remove(item);
                }
            }
        }

        public void DestroyItem(GameObject item)
        {
            if (INVENTORY.Contains(item))
            {
                INVENTORY.Remove(item);
            }
        }
    }
}
