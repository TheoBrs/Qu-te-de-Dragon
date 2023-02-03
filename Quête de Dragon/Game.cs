using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{

    public class Game
    {
        private int _perso;
        private int _team;
        private int _inventory;
        FightProbability _fight = new();
        

        public void PlayGame()
        {
            _fight.SerializePerso();
            Console.CursorVisible = false;
            Map _map = new();
            _map.DrawMap();
            bool _mapDraw = true;
            var _key = Console.ReadKey();
            bool dragon = false;
            while (_fight.teamLife() != 0 && !dragon)
            {
                if (!_mapDraw)
                {
                    Console.Clear();
                    _map.testChangeMap();
                    _map.DrawMap();
                    _key = Console.ReadKey();
                    _mapDraw = true;
                }


                switch (_key.Key)
                {

                    case ConsoleKey.UpArrow:
                        if (_map.MovementTest("up"))
                        {
                            
                            _map.AffichePerso(_map.GetplayerX(), _map.GetplayerY() - 1);

                        }
                        _mapDraw = false;
                        break;


                    case ConsoleKey.DownArrow:
                        if (_map.MovementTest("down"))
                        {
                            
                            _map.AffichePerso(_map.GetplayerX(), _map.GetplayerY() + 1);

                        }
                        _mapDraw = false;
                        break;

                    case ConsoleKey.LeftArrow:
                        if (_map.MovementTest("left"))
                        {
                            
                            _map.AffichePerso(_map.GetplayerX() - 1, _map.GetplayerY());


                        }
                        _mapDraw = false;

                        break;

                    case ConsoleKey.RightArrow:
                        if (_map.MovementTest("right"))
                        {
                            
                            _map.AffichePerso(_map.GetplayerX() + 1, _map.GetplayerY());

                        }
                        _mapDraw = false;
                        break;
                    case ConsoleKey.I:
                        _key = Console.ReadKey();
                        break;

                    default:
                        _key = Console.ReadKey();
                        break;
                }

                if (_map.TestStartfight())
                {

                    if (_fight.AleatoryFight())
                    {
                        _fight.RunFight();
                    }

                }


            }
        }
    }
}