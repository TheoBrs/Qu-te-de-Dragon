

namespace Project_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.DrawMap();

            Slime slime = new Slime();
            slime.DrawSlime();
        }
    }
}