using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        CoordPlayer _player;

        public Map()
        {
            _player = new CoordPlayer
            {
                X = 23,
                Y = 13,
            }; 

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aleksi\source\repos\Qu-te-de-Dragon\design\map\map1.txt");
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

        public bool MovementTest(string _direction)
        {
            switch (_direction)
            {
                case "up":
                    if (_map[_player.X, _player.Y-1] != 'x')
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
                    if (_map[_player.X-1, _player.Y] != 'x')
                    {
                        
                        return true;
                    }
                    else
                    {
                        break;
                    }
                case "right":

                    if (_map[_player.X + 1, _player.Y] != 'x')
                    {
                        
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

        public void AffichePerso(int x , int y)
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

    }
}