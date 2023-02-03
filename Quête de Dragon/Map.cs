namespace Quête_de_Dragon
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
        int persoInMap = 0;
        CoordPlayer _player;
        string[] pathmap = {
                @"../../../../design/map/map1.txt",
                @"../../../../design/map/map2.txt",
                @"../../../../design/map/map3.txt",
                @"../../../../design/map/map4.txt"
            };
        public Map()
        {

            


            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;

            _player = new CoordPlayer
            {
                X = 23,
                Y = 13,
            }; 
            string[] lines = System.IO.File.ReadAllLines(pathmap[0]);
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

        public void ChangeMap(int map) {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            if (_player.X == 0) _player.X = 66;
            if (_player.X == 67) _player.X = 1;
            if (_player.Y == 0) _player.Y = 22;
            if (_player.Y == 23) _player.Y = 1;

            string[] lines = System.IO.File.ReadAllLines(pathmap[map]);
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
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Black;
                        continue;
                    }


                    switch (_map[x, y])
                    {
                        case 'x':

                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            Console.Write(_map[x, y]);
                            break;
                        case 'D':

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(_map[x, y]);
                            break;
                        case '*':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(_map[x, y]);
                            break;


                        case '$':

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(_map[x, y]);
                            break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_map[x, y]);
                            break;
                    }


                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }


        }
        public void testChangeMap()
        {
            if (_map[_player.X, _player.Y] == 'n')
            {
                persoInMap++;
                ChangeMap(persoInMap);

            }
            if (_map[_player.X, _player.Y] == 'b')
            {
                persoInMap--;
                ChangeMap(persoInMap);
            }
        }
        public bool MovementTest(string _direction)
        {
            
            switch (_direction)
            {
                case "up":
                    if (_map[_player.X, _player.Y - 1] != 'x')
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }

                case "down":
                    if (_map[_player.X, _player.Y + 1] != 'x')
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                    
                case "left":
                    if (_map[_player.X - 1, _player.Y] != 'x')
                    {
                        testChangeMap();
                        return true;
                    }
                    else
                    {
                        break;
                    }
                case "right":

                    if (_map[_player.X + 1, _player.Y] != 'x')
                    {
                        testChangeMap();
                        return true;
                    }
                    else
                    {
                        break;
                    }


                default:


                    break;

            }
            return false;
        }

        public void AffichePerso(int x, int y)
        {
            _player.X = x;
            _player.Y = y;
        }

        public bool TestStartfight()
        {
            if (_map[_player.X, _player.Y] == '*') return true;
            else return false;
        }


        public int GetplayerX()
        {
            return _player.X;
        }
        public int GetplayerY()
        {
            return _player.Y;
        }

        public void writeText(string textToDisplay)
        {
            Console.Write(textToDisplay);
        }
    }
}