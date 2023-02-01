using System.Xml.Serialization;

namespace Quête_de_Dragon
{
    
    public class Game
    {
        int _choice = 1;
        TeamBuild _team;
        private int _inventory;
        FightProbability _fight = new();
        ConsoleKeyInfo _key;
        
        public void PlayGame()
        {
            Map _map = new();
            _map.DrawMap();
            bool _mapDraw = true;
            _key = Console.ReadKey();
            bool test = true;
            while (test==true)
            {
                if (!_mapDraw)
                {
                    Console.Clear();
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
                        PauseMenu();
                        _mapDraw = false;
                        break;

                    default:
                        _key = Console.ReadKey();
                        break;
                }

                if (_map.TestStartfight())
                {

                    if (_fight.AleatoryFight()) {
                        _fight.RunFight();
                    }

                }


            }
        }

        public void PauseMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            while (_choice != 0)
            {
                _key = Console.ReadKey();
                switch (_key.Key)
                {
                    case ConsoleKey.Escape:
                        _choice = 0;
                        break;
                    case ConsoleKey.UpArrow:
                        _choice = Math.Min(_choice+1,4);
                        Console.WriteLine("Resume");
                        Console.WriteLine("Party");
                        Console.WriteLine("Save");
                        Console.WriteLine("Load");
                        Console.Clear();
                        break;
                    case ConsoleKey.DownArrow:
                        _choice = Math.Max(_choice-1,0);
                        Console.WriteLine("Resume");
                        Console.WriteLine("Party");
                        Console.WriteLine("Save");
                        Console.WriteLine("Load");
                        Console.Clear();
                        break;
                    case ConsoleKey.Enter:
                        switch (_choice)
                        {
                            case 1:
                                _choice = 0;
                                break;
                            case 2:
                                GetTeam();
                                break;
                            case 3:
                                //GameSave();
                                break;
                            case 4:
                                //GameLoad();
                                break;
                            default: break;
                        }
                        break;
                    default: break;
                }
                
            }
            _choice= 1;
        }

        public void GetInventory()
        {
            throw new System.NotImplementedException();
        }

        public void GetTeam()
        {
            throw new System.NotImplementedException();
        }
    }
}