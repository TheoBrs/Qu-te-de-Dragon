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
            Lvl = 0;
            Hp = 0;
            HpMax = 0;
            Mp = 0;
            MpMax = 0;
            Atk = 0;
            AtkMag = 0;
            Def = 0;
            Vit = 0;
        }

        public Player(string name)
        {

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
            Vit = 0;
        }
    }
}