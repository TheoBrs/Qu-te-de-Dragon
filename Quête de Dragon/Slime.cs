using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{
    public class Slime
    {
        char[,] _slime;

        public Slime()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\aleksi\source\repos\Qu-te-de-Dragon\design\ennemy\ennemy1.txt");
            _slime = new char[lines[1].Count(), lines.GetLength(0)];
            int y = 0;
            int x;
            foreach (string line in lines)
            {
                x = 0;
                foreach (char c in line)
                {
                    _slime[x, y] = c;
                    x++;
                }
                y++;
            }
        }
        public void DrawSlime()
        {
            for (int y = 0; y < _slime.GetLength(1); y++)
            {
                for (int x = 0; x < _slime.GetLength(0); x++)
                {
                    switch (_slime[x, y])
                    {
                        case '*':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(_slime[x, y]);
                            break;
                        case '+':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(_slime[x, y]);
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_slime[x, y]);
                            break;
                        case '@':
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(_slime[x, y]);
                            break;
                        case ',':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.Write(_slime[x, y]);
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(_slime[x, y]);
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