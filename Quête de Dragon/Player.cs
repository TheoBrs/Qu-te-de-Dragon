﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

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

            Id = 0;
            Name = string.Empty;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 0;
            Pv = 0;
            PvMax = 0;
            Pm = 0;
            PmMax = 0;
            Atk = 0;
            AtkMag = 0;
            Def = 0;
            DefMag = 0;
            Vit = 0;
        }

        public Player(string name)
        {
            _playerInventory = new Inventory();

            Inventory.MaxInventorySlot = 64;

            Id = 0;
            Name = name;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 0;
            Pv = 0;
            PvMax = 0;
            Pm = 0;
            PmMax = 0;
            Atk = 0;
            AtkMag = 0;
            Def = 0;
            DefMag = 0;
            Vit = 0;
        }
    }
}