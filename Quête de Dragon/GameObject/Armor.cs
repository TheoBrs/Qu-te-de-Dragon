using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Armor : GameObject
    {        
        public Armor()
        {
            Id = 2;
            Name = "Helmet             ";
            Type = "armor";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Def = 12;
        }

        public Armor(string name)
        {
            Id = 2;
            Name = name;
            Type = "armor";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Def = 12;
        }
    }
}