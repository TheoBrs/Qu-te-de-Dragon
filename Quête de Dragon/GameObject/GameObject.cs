using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class GameObject
    {

        Dictionary<string, int> _itemIntData = new Dictionary<string, int>();

        Dictionary<string, string> _itemStringData = new Dictionary<string, string>();

        public GameObject() 
        {
            /*_itemIntData.Add("Id", 0);
            _itemStringData.Add("name", string.Empty);
            _itemStringData.Add("type", string.Empty);
            _itemIntData.Add("itemCount", 0);
            _itemIntData.Add("isStackable", 0);
            _itemIntData.Add("lvl", 0);
            _itemIntData.Add("pv", 0);
            _itemIntData.Add("pvMax", 0);
            _itemIntData.Add("pm", 0);
            _itemIntData.Add("pmMax", 0);
            _itemIntData.Add("atk", 0);
            _itemIntData.Add("atkMag", 0);
            _itemIntData.Add("def", 0);
            _itemIntData.Add("defMag", 0);
            _itemIntData.Add("vit", 0);*/
        }

        public Dictionary<string, int> IntData { get => _itemIntData; set => _itemIntData = value; }

        public Dictionary<string, string> StringData { get => _itemStringData; set => _itemStringData = value; }
    }
}