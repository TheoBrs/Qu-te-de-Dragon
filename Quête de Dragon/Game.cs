﻿using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Quête_de_Dragon
{

    public class Game
    {
        Map _map;
        int _verticalChoice = 1;
        int _horizontalChoice = 1;
        int _horizontalChoice2 = 1;
        int _horizontalChoice3 = 1;
        bool _isEnterPressed = false;
        bool _isEnterPressed2 = false;
        bool _isEnterPressed3 = false;
        TeamBuild _team;
        FightProbability _fight = new();
        ConsoleKeyInfo _key;

        public void PlayGame()
        {
            _map = new Map();
            _team = new TeamBuild();
            _map.DrawMap();
            bool _mapDraw = true;
            Sword sword = new Sword();
            Sword sword1 = new Sword("Excalibur");
            Helmet helmet = new Helmet();
            Helmet helmet1 = new Helmet("Cap of invisibility");
            _team.InventoryBuffer.AddItem(sword);
            _team.InventoryBuffer.AddItem(sword1);
            _team.InventoryBuffer.AddItem(helmet);
            _team.InventoryBuffer.AddItem(helmet1);
            _key = Console.ReadKey();
            while (true)
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
                                //GameSave();
                                break;
                            case 3:
                                //GameLoad();
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
                            _verticalChoice = Math.Min(_verticalChoice + 1, _team.Inventory.INVENTORY.Count);
                        break;
                    case ConsoleKey.UpArrow:
                        if (!_isEnterPressed)
                            _verticalChoice = Math.Max(_verticalChoice - 1, 1);
                        break;
                    case ConsoleKey.RightArrow:
                        if (!_isEnterPressed)
                        {
                            _horizontalChoice = Math.Min(_horizontalChoice + 1, 3);
                            _verticalChoice = 1;
                        }
                        else if (!_isEnterPressed2)
                        {
                            _horizontalChoice2 = Math.Min(_horizontalChoice2 + 1, 2);
                        }
                        else { _horizontalChoice3 = Math.Min(_horizontalChoice3 + 1, 3); }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (!_isEnterPressed)
                        {
                            _horizontalChoice = Math.Max(_horizontalChoice - 1, 0);
                            _verticalChoice = 1;
                        }
                        else if (!_isEnterPressed2)
                        {
                            _horizontalChoice2 = Math.Max(_horizontalChoice2 - 1, 0);
                        }
                        else { _horizontalChoice3 = Math.Max(_horizontalChoice3 - 1, 0); }
                        break;
                    case ConsoleKey.Enter:
                        if (!_isEnterPressed) _isEnterPressed = true;
                        else if (!_isEnterPressed2) _isEnterPressed2 = true;
                        else
                            _isEnterPressed3 = true;
                        break;
                    case ConsoleKey.Backspace:
                        if (_isEnterPressed3)
                            _isEnterPressed3 = false;
                        else if (_isEnterPressed2)
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
                        if (_team.Inventory == null) { goto Skip; }
                        int counter = 1;
                        _team.Inventory = new Inventory(_team.InventoryBuffer);
                        foreach (GameObject item in _team.Inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "consummable")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Hp}Hp");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(item);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Hp}Hp");
                            }
                            ++counter;
                        }
                        _team.Inventory = new Inventory(_team.InventoryBuffer);

                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Consummable          ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Weapon               ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Armor");
                        if (_team.Inventory == null) { goto Skip; }
                        counter = 1;
                        _team.Inventory = new Inventory(_team.InventoryBuffer);
                        foreach (GameObject item in _team.Inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "sword")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk       +{item.AtkMag}AtkMag");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(item);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk       +{item.AtkMag}AtkMag");
                            }
                            ++counter;
                        }
                        _team.Inventory = new Inventory(_team.InventoryBuffer);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Consummable          ");
                        Console.Write("Weapon               ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Armor");
                        Console.ForegroundColor = ConsoleColor.White;
                        if (_team.Inventory == null) { goto Skip; }
                        counter = 1;
                        _team.Inventory = new Inventory(_team.InventoryBuffer);
                        foreach (GameObject item in _team.Inventory.INVENTORY)
                        {
                            if (item != null && item.Type == "armor")
                            {
                                if (counter == _verticalChoice)
                                {

                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    ItemOption(item);
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def");
                            }
                            ++counter;
                        }
                        _team.Inventory = new Inventory(_team.InventoryBuffer);
                        break;
                    default:
                    Skip:
                        break;
                }
            }
            _verticalChoice = 1;
            _horizontalChoice = 1;
            _horizontalChoice2 = 1;
            _horizontalChoice3 = 1;
            _isEnterPressed = false;
            _isEnterPressed2 = false;
            _isEnterPressed3 = false;
        }

        public void GetTeam()
        {
            throw new System.NotImplementedException();
        }

        private void ItemOption(GameObject item)
        {
            if (!_isEnterPressed) { return; }
            switch (_horizontalChoice2)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Use on       ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Drop");
                    UseItem(item);
                    _isEnterPressed2 = false;
                    _horizontalChoice2= 1;
                    break;
                case 2:
                    Console.Write("Use          ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Drop");
                    Console.ForegroundColor = ConsoleColor.White;
                    //Drop Item
                    if (_isEnterPressed2)
                    {
                        _team.InventoryBuffer.DestroyItem(item);
                        _isEnterPressed2 = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void UseItem(GameObject item)
        {
            if (!_isEnterPressed2) { goto Skip3; }
            switch (_horizontalChoice3)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_team.Player1.Name + "    ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(_team.Player2.Name + "    ");
                    Console.WriteLine(_team.Player3.Name);
                    if (_isEnterPressed3 == true) { _team.Player1.Inventory.AddItem(item); }
                    break;
                case 2:
                    Console.Write(_team.Player1.Name + "    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(_team.Player2.Name + "    ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(_team.Player3.Name);
                    if (_isEnterPressed3 == true) { _team.Player2.Inventory.AddItem(item); }
                    break;
                case 3:
                    Console.Write(_team.Player1.Name + "    ");
                    Console.Write(_team.Player2.Name + "    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(_team.Player3.Name);
                    Console.ForegroundColor = ConsoleColor.White;
                    if (_isEnterPressed3 == true) { _team.Player3.Inventory.AddItem(item); }
                    break;
                default:
                    break;
            }
        Skip3:;
        }


    }
}