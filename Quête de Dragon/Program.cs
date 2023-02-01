

using Quête_de_Dragon;

namespace Project_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map;
            map= new Map();

            map.DrawMap();
            for (int i = 0; i < 10; i++)
            {
                map.DrawMap();
                Console.Clear();
            }
        }
    }
}