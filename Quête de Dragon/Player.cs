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
            Lvl = 0;
            Hp = 0;
            HpMax = 0;
            Mp = 0;
            MpMax = 0;
            Atk = 0;
            AtkMag = 0;
            Def = 0;
            DefMag = 0;
            Vit = 0;
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
            Lvl = 0;
            Hp = 0;
            HpMax = 0;
            Mp = 0;
            MpMax = 0;
            Atk = 0;
            AtkMag = 0;
            Def = 0;
            DefMag = 0;
            Vit = 0;
        }
    }
}