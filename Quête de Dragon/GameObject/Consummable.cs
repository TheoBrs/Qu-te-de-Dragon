using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Consummable : GameObject
    {        
        public Consummable()
        {
            Id = 3;
            Name = "Potion      ";
            ItemCount = 1;
            IsStackable = 1;
            Lvl = 1;
            Hp = 30;
        }

        public Consummable(string name)
        {
            Id = 3;
            Name = name;
            ItemCount = 1;
            IsStackable = 1;
            Lvl = 1;
            Hp = 30;
        }
    }
}