using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Inventory
    {
        List<GameObject> _inventory;

        int _maxInventorySlot;  //this is a counter, 0 == none

        public List<GameObject> INVENTORY { get => _inventory; }

        public int MAXSLOT { get => _maxInventorySlot; set => _maxInventorySlot = value; }

        public Inventory()
        {
            _inventory = new List<GameObject>();
        }

        public void AddItem(GameObject item)
        {
            if (_inventory.Count < _maxInventorySlot)
            {
                _inventory.Add(item);
                _inventory.Sort();
            }
        }

        public void RemoveItem(GameObject item)
        {
            _inventory.Remove(item);
            _inventory.Sort();
        }
    }
}