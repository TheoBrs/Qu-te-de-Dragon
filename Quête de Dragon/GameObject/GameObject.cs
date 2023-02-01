using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class GameObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ItemCount { get; set; }
        public int IsStackable { get; set; }
        public int Lvl { get; set; }
        public int Pv { get; set; }
        public int Pm { get; set; }
        public int PmMax { get; set; }
        public int PvMax { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int AtkMag { get; set; }
        public int DefMag { get; set; }
        public int Vit { get; set; }
    }
}