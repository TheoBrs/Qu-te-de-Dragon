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

        //Inventory _playerEquipment;
        public Weapon Weapon { get; set; }

        public Armor Armor { get; set; }


        public Player()
        {
            Id = 0;
            Name = string.Empty;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Hp = 26;
            HpMax = 26;
            Mp = 4;
            MpMax = 4;
            Atk = 18;
            AtkMag = 0;
            Def = 18;
            Vit = 4;
            Exp = 0;
        }

        public Player(string name)
        {

            Id = 0;
            Name = name;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Hp = 18;
            HpMax = 18;
            Mp = 16;
            MpMax = 16;
            Atk = 4;
            AtkMag = 18;
            Def = 7;
            Vit = 18;
            Exp = 0;
        }

        public Player(string name, int i)
        {
            _playerEquipment = new Inventory();

            Inventory.MaxInventorySlot = 64;

            Id = 0;
            Name = name;
            Type = "Player";
            ItemCount = 0;
            IsStackable = 0;
            Lvl = 1;
            Hp = 19;
            HpMax = 19;
            Mp = 22;
            MpMax = 22;
            Atk = 9;
            AtkMag = 0;
            Def = 9;
            Vit = 14;
            Exp = 0;
        }

    }
}