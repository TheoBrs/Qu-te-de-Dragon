using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public abstract class GameObject
    {
        public struct Stat
        {
            public int hp;
            public int pm;
            public int hpMax;
            public int pmMax;
            public int vit;
            public int atk;
            public int def;
            public int atkMag;
            public int defMag;
        };

        public struct ItemData
        {
            public int gameId;
            public string name;
            public int itemCount;
            public Stat stat;
        };

        ItemData _itemData;

        public ItemData Data { get => _itemData; set => _itemData = value; }
    }
}