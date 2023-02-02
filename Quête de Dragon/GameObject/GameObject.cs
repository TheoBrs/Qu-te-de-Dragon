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
        public int Hp { get; set; }
        public int Mp { get; set; }
        public int MpMax { get; set; }
        public int HpMax { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int AtkMag { get; set; }
        public int Vit { get; set; }
    }
}