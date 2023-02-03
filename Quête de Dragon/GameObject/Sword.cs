using System.Xml.Linq;

namespace Quête_de_Dragon
{
    public class Weapon : GameObject
    {        
        public Weapon()
        {
            Id = 1;
            Name = "Sword        ";
            Type = "sword";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Atk = 5;
        }

        public Weapon(string name)
        {
            Id = 1;
            Name = name;
            Type = "sword";
            ItemCount = 1;
            IsStackable = 0;
            Lvl = 1;
            Atk = 5;
        }
    }
}