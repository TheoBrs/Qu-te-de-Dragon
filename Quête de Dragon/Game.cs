﻿using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Quête_de_Dragon
{

    public class Game
    {
        int _verticalChoice = 1;
        int _horizontalChoice = 1;
        bool _IsEnterPressed = false;
        TeamBuild _team;
        Inventory _inventory;
        FightProbability _fight = new();
        ConsoleKeyInfo _key;

        public void PlayGame()
        {
            Map _map = new();
            _team = new TeamBuild();
            _inventory = new Inventory();
            _map.DrawMap();
            bool _mapDraw = true;
            _key = Console.ReadKey();
            bool test = true;
            Sword sword = new Sword();
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            _inventory.AddItem(sword);
            while (test == true)
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
                        _verticalChoice = 0;
                        break;
                    case ConsoleKey.DownArrow:
                        _verticalChoice = Math.Min(_verticalChoice + 1, _inventory.INVENTORY.Count);
                        break;
                    case ConsoleKey.UpArrow:
                        _verticalChoice = Math.Max(_verticalChoice - 1, 1);
                        break;
                    case ConsoleKey.RightArrow:
                        _horizontalChoice = Math.Min(_horizontalChoice + 1, 3);
                        break;
                    case ConsoleKey.LeftArrow:
                        _horizontalChoice = Math.Max(_horizontalChoice - 1, 1);
                        break;
                    case ConsoleKey.Enter:
                        _IsEnterPressed = true;
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
                                    switch (_key.Key)
                                    {
                                        case ConsoleKey.Enter:
                                            Console.WriteLine("Test");
                                            break;
                                        default:
                                            _key = Console.ReadKey();
                                            break;
                                    }
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
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    switch (_IsEnterPressed)
                                    {
                                        case true:
                                            Console.WriteLine("Test");
                                            break;
                                        default:
                                            _key = Console.ReadKey();
                                            break;
                                    }
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Atk}Atk");
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
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def       +{item.DefMag}DefMag");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                    Console.WriteLine($"{item.Name}         x{item.ItemCount}       +{item.Def}Def       +{item.DefMag}DefMag");
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
    }
}