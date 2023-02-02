using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Helmet : GameObject
    {        
        public Helmet()
        {
            Id = 2;
            Name = "Helmet";
            Type = "armor";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Def = 12;
        }

        public Helmet(string name)
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