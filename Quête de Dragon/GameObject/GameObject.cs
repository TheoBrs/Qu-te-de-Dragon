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
            public int _lvl;
            public int _pv;
            public int _pvMax;
            public int _pm; 
            public int _pmMax;
            public int _atk;
            public int _atkMag;
            public int _def;
            public int _defMag;
            public int _vit;
        };

        public struct ItemData
        {
            public int _gameId;
            public int _itemCount;
            public string _type;
            public string _name;
            public Stat _stat;
        }

        //ItemData _itemData;

        public abstract ItemData Data { get /*=> _itemData*/; set /*=> _itemData = value*/; }


    }
}