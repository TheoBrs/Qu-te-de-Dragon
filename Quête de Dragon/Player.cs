using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Player : GameObject
    {
        //public override ItemData Data { get; set; }

        Inventory _playerEquipment;
        public Inventory Inventory { get => _playerEquipment; }

        public Player()
        {
            _playerEquipment = new Inventory();

            Inventory.MaxInventorySlot = 64;

            Id = 0;
            Name = string.Empty;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Pv = 26;
            PvMax = 26;
            Pm = 4;
            PmMax = 4;
            Atk = 18;
            AtkMag = 0;
            Def = 18;
            Vit = 4;
            Exp = 0;
        }

        public Player(string name)
        {
            _playerEquipment = new Inventory();

            Inventory.MaxInventorySlot = 64;

            Id = 0;
            Name = name;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Pv = 18;
            PvMax = 18;
            Pm = 16;
            PmMax = 16;
            Atk = 4;
            AtkMag = 18;
            Def = 7;
            Vit = 18;
            Exp = 0;
        }

        public Player(string name, int i)
        {
            _playerInventory = new Inventory();

            Inventory.MaxInventorySlot = 64;

            Id = 0;
            Name = name;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Pv = 19;
            PvMax = 19;
            Pm = 22;
            PmMax = 22;
            Atk = 9;
            AtkMag = 0;
            Def = 9;
            Vit = 14;
            Exp = 0;
        }

    }
}