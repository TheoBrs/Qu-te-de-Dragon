namespace Project_CSharp
{
    public class Map
    {
        public struct CoordPlayer
        {
            int x;
            int y;

            public int X { get => x; set => x = value; }
            public int Y { get => y; set => y = value; }
        }

        char[,] _map;

        CoordPlayer _player;

        public Map()
        {
            _player = new CoordPlayer
            {
                X = 23,
                Y = 13,
            };

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aauneau\source\repos\Qu-te-de-Dragon\Quête de Dragon\map1.txt");
            _map = new char[lines[1].Count(), lines.GetLength(0)];
            int y = 0;
            int x;
            foreach (string line in lines) 
            {
                x = 0;
                foreach (char c in line)
                {
                    _map[x, y] = c;
                    x++;
                }
                y++;
            }

        }
        public void DrawMap()
        {

            for (int y = 0; y < _map.GetLength(1); y++)
            {
                for (int x = 0; x < _map.GetLength(0); x++)
                {
                    if (_player.X == x && _player.Y == y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(_map[x, y]);
                        continue;
                    }


                    switch (_map[x, y])
                    {
                        case 'x':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            break;

                        case '*':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            break;


                        case '$':

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            break;
                    }
                    Console.Write(_map[x, y]);
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}