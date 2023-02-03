using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Quête_de_Dragon
{

    public class Game
    {
        int _verticalChoice = 1;
        int _horizontalChoice = 1;
        int _horizontalChoice2 = 1;
        bool _isEnterPressed = false;
        bool _isEnterPressed2 = false;
        TeamBuild _team;
        Inventory _inventory;
        FightProbability _fight = new();
        ConsoleKeyInfo _key;


        public void PlayGame()
        {
            _fight.SerializePerso();
            Console.CursorVisible = false;
            Map _map = new();
            _team = new TeamBuild();
            _inventory = new Inventory();
            _map.DrawMap();
            bool _mapDraw = true;
            _key = Console.ReadKey();
            
            Sword sword = new Sword();
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
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
                    case ConsoleKey.Escape:
                        PauseMenu();
                        _mapDraw = false;
                        break;

                    case ConsoleKey.I:
                        GetInventory();
                        _mapDraw = false;
                        break;
                    case ConsoleKey.T:
                        GetInventory();
                        _mapDraw = false;
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

        public void PauseMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("RResume");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Save");
            Console.WriteLine("Load");
            while (_verticalChoice != 0)
            {
                _key = Console.ReadKey();
                switch (_key.Key)
                {
                    case ConsoleKey.Escape:
                        _verticalChoice = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        _verticalChoice = Math.Min(_verticalChoice + 1, 3);

                        break;
                    case ConsoleKey.UpArrow:
                        _verticalChoice = Math.Max(_verticalChoice - 1, 1);
                        break;
                    case ConsoleKey.Enter:
                        switch (_verticalChoice)
                        {
                            case 1:
                                _verticalChoice = 0;
                                break;
                            case 2:
                                //SAVE
                                GameSave();
                                break;
                            case 3:
                                //load
                                GameLoad();
                                break;
                            default:
                                _key = Console.ReadKey();
                                break;
                        }
                        break;
                    default:
                        _key = Console.ReadKey();
                        break;
                }
                switch (_verticalChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Resume");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Save");
                        Console.WriteLine("Load");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Resume");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Save");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Load");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Resume");
                        Console.WriteLine("Save");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Load");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }
            }
            _verticalChoice = 1;
        }

        private void GameLoad()
        {
            _fight.DeserializePerso();
        }

        private void GameSave()
        {
            _fight.SaveSerializePerso();
        }

        public void GetInventory()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Consummable          ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Weapon               ");
            Console.WriteLine("Armor");
            while (_verticalChoice != 0)
            {
                _key = Console.ReadKey();
                switch (_key.Key)
                {
                    case ConsoleKey.Escape:
                        if (!_isEnterPressed)
                            _verticalChoice = 0;
                        else
                            _isEnterPressed = false;
                        break;
                    case ConsoleKey.DownArrow:
                        if (!_isEnterPressed)
                            _verticalChoice = Math.Min(_verticalChoice + 1, _inventory.INVENTORY.Count);
                        break;
                    case ConsoleKey.UpArrow:
                        if (!_isEnterPressed)
                            _verticalChoice = Math.Max(_verticalChoice - 1, 1);
                        break;
                    case ConsoleKey.RightArrow:
                        if (!_isEnterPressed)
                        {
                            _horizontalChoice = Math.Min(_horizontalChoice + 1, 3);
                        }
                        else
                        {
                            _horizontalChoice2 = Math.Min(_horizontalChoice + 1, 2);
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (!_isEnterPressed)
                        {
                            _horizontalChoice = Math.Min(_horizontalChoice - 1, 3);
                        }
                        else
                        {
                            _horizontalChoice2 = Math.Min(_horizontalChoice - 1, 2);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (!_isEnterPressed)
                            _isEnterPressed = true;
                        else
                            _isEnterPressed2 = true;
                        break;
                    case ConsoleKey.Backspace:
                        if (_isEnterPressed2)
                            _isEnterPressed2 = false;
                        else if (_isEnterPressed)
                            _isEnterPressed = false;
                        else
                            _verticalChoice = 0;
                        break;
                    default:
                        _key = Console.ReadKey();
                        break;
                }
                switch (_horizontalChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Consummable          ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("Weapon               ");
                        Console.WriteLine("Armor");
                        if (_inventory == null) { goto Skip; }
                        int counter = 1;
                        foreach (GameObject item in _inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "consummable")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Hp}Hp");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(_isEnterPressed, _isEnterPressed2, _horizontalChoice2);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Hp}Hp");
                            }
                            ++counter;
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Consummable          ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Weapon               ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Armor");
                        if (_inventory == null) { goto Skip; }
                        counter = 1;
                        foreach (GameObject item in _inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "sword")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk       +{item.AtkMag}AtkMag");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(_isEnterPressed, _isEnterPressed2, _horizontalChoice2);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk       +{item.AtkMag}AtkMag");
                            }
                            ++counter;
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Consummable          ");
                        Console.Write("Weapon               ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Armor");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (_inventory == null) { goto Skip; }
                        counter = 1;
                        foreach (GameObject item in _inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "armor")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(_isEnterPressed, _isEnterPressed2, _horizontalChoice2);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def");
                            }
                            ++counter;
                        }
                        break;
                    default:
                    Skip:
                        break;
                }
            }
            _verticalChoice = 1;
        }

        public void GetTeam()
        {
            throw new System.NotImplementedException();
        }

        private void ItemOption(bool _isEnterPressed, bool _isEnterPressed2, int _horizontalChoice2)
        {
            switch (_isEnterPressed)
            {
                case true:
                    switch (_horizontalChoice2)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("Use          ");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Drop");
                            if (_isEnterPressed2)
                            {
                                //UseObjectFunc
                                Console.WriteLine("1");
                            }
                            break;
                        case 2:
                            Console.Write("Use          ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Drop");
                            Console.ForegroundColor = ConsoleColor.White;
                            if (_isEnterPressed2)
                            {
                                //DropObjectFunc
                                Console.WriteLine("2");
                            }
                            break;
                        default: break;
                    }
                    break;
                default:
                    //_key = Console.ReadKey();
                    break;
            }
        }
    }
}