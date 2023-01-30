using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Inventory
    {
        List<GameObject> _inventory;

        public List<GameObject> INVENTORY { get => _inventory; }

        public Inventory() 
        {
            _inventory= new List<GameObject>();
        }

        public void AddItem(GameObject item)
        {
            _inventory.Add(item);
            _inventory.Sort();
        }

        public void RemoveItem(GameObject item)
        {
            _inventory.Remove(item);
            _inventory.Sort();
        }
    }
}
