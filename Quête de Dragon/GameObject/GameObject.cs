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
            public int atk;
            public int def;
        };

        public struct ItemData
        {
            public int gameId;
            public string name;
            public Stat stat;
        }


        //protected ItemData _itemData;


        public abstract ItemData Data { get; }


    }
}