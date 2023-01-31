using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quête_de_Dragon
{
    internal class GreenDragon
    {
        char[,] _dragon;

        public GreenDragon()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\tboros\source\repos\Qu-te-de-Dragon\design\ennemy\greendragon.txt");
            _dragon = new char[lines[1].Count(), lines.GetLength(0)];
            int y = 0;
            int x;
            foreach (string line in lines)
            {
                x = 0;
                foreach (char c in line)
                {
                    _dragon[x, y] = c;
                    x++;
                }
                y++;
            }
        }

        public void DrawDragon()
        {
            for (int y = 0; y < _dragon.GetLength(1); y++)
            {
                for (int x = 0; x < _dragon.GetLength(0); x++)
                {
                    switch (_dragon[x, y])
                    {
                        case '+':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(_dragon[x, y]);
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(_dragon[x, y]);
                            break;
                        case '.':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_dragon[x, y]);
                            break;
                        case ':':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_dragon[x, y]);
                            break;
                        case '@':
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(_dragon[x, y]);
                            break;
                        case '=':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(_dragon[x, y]);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_dragon[x, y]);
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }


    }
}
