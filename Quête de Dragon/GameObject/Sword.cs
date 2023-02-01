using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Sword : GameObject
    {
        //ItemData _itemData;

        //public override ItemData Data { get /*=> _itemData*/; set /*=> _itemData = value*/; }
        //public new virtual ItemData Data => _itemData;

        public Sword()
        {
            Id = 1;
            Name = "Sword";
            Type = "Player";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Atk = 5;
        }

        public Sword(string name)
        {
            Id = 1;
            Name = name;
            Type = "Sword";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Atk = 5;
        }
    }
}