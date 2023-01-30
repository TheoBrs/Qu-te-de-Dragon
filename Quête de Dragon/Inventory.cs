﻿using System;
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
            _inventory = new List<GameObject>();
        }

        public void AddItem(GameObject item)
        {
            if (item.Data._itemCount == 0)
            {
                _inventory.Add(item);
                item.Data._itemCount = item.Data._itemCount - 1;
            }
            _inventory.Sort();
        }

        public void RemoveItem(GameObject item)
        {
            --item.Data._itemCount;
            if (item.Data._itemCount == 0)
                _inventory.Remove(item);
            _inventory.Sort();
        }
    }
}
