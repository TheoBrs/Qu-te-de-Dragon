using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Linq;
using static Quête_de_Dragon.Fight_Team;
using static System.Net.Mime.MediaTypeNames;

namespace Quête_de_Dragon
{
    public class Fight_Team
    {


        public class StatPerso
        {
            public string Name { get; set; }
            public int Life { get; set; }
            public int Mana { get; set; }
            public int Dps { get; set; }
        }
        StatPerso _hero;
        StatPerso _mage;
        StatPerso _healer;

        public class StatAbilities
        {
            public string name { get; set; }
            public string description { get; set; }
            public int stat { get; set; }
            public int mana { get; set; }
            public int niveau { get; set; }
            public string buff_type { get; set; }
            public string cible_type { get; set; }

        }

        StatAbilities[] _abilities;





        internal void init()
        {
            _abilities = new StatAbilities[11];
            _hero = new StatPerso();
            _mage = new StatPerso();
            _healer = new StatPerso();
            string[] _path = {
                @"../../../../design/skill/0.json",
                @"../../../../design/skill/1.json",
                @"../../../../design/skill/2.json",
                @"../../../../design/skill/3.json",
                @"../../../../design/skill/4.json",
                @"../../../../design/skill/5.json",
                @"../../../../design/skill/6.json",
                @"../../../../design/skill/7.json",
                @"../../../../design/skill/8.json",
                @"../../../../design/skill/9.json",
                @"../../../../design/skill/10.json"
            };
            for (int i = 0; i < 11; i++)
            {
                _abilities[i] = JsonSerializer.Deserialize<StatAbilities>(File.ReadAllText(_path[i]));
            }



            _hero = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"../../../../design/perso/hero.json"));
            _mage = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"../../../../design/perso/mage.json"));
            _healer = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"../../../../design/perso/healer.json"));

        }

        //func verifie les stats du perso actuel
        // func modifie les stats du perso actuel 
        // func change de perso 

        //func choix d'attaque
        //func use object in inventory

        /* public void changePerso()
         {
             if(perso.Name == "Hero")
             {
                 hero = perso;
             }
         }
 */


        public int returnStatLifePerso(string name)
        {
            switch (name)
            {
                case "hero":

                    return _hero.Life;
                case "mage":
                    return _mage.Life;
                case "healer":
                    return _healer.Life;
                default:
                    return -10;
            }

        }

        public int returnStatManaPerso(string name)
        {
            switch (name)
            {
                case "hero":
                    return _hero.Mana;
                case "mage":
                    return _mage.Mana;
                case "healer":
                    return _healer.Mana;
                default:
                    return -10;
            }
        }

        public int returnStatDPSPerso(string name)
        {
            switch (name)
            {
                case "hero":
                    return _hero.Dps;
                case "mage":
                    return _mage.Dps;
                case "healer":
                    return _healer.Dps;
                default:
                    return -10;
            }
        }



        public void ModifieStat(string stat, int x, string namePeso)
        {
            switch (stat)
            {
                case "Life":
                    switch (namePeso)
                    {
                        case "hero":
                            _hero.Life += x;
                            if (_hero.Life < 0) _hero.Life = 0;
                            if (_hero.Life > 100) _hero.Life = 100;
                            break;
                        case "mage":
                            _mage.Life += x;
                            if (_mage.Life < 0) _mage.Life = 0;
                            if (_mage.Life > 100) _mage.Life = 100;
                            break;
                        case "healer":
                            _healer.Life += x;
                            if (_healer.Life < 0) _healer.Life = 0;
                            if (_healer.Life > 100) _healer.Life = 100;
                            break;

                    }
                    break;

                case "Mana":
                    switch (namePeso)
                    {
                        case "hero":
                            _hero.Mana += x;
                            if (_hero.Mana < 0) _hero.Mana = 0;
                            if (_hero.Mana > 100) _hero.Mana = 100;
                            break;
                        case "mage":
                            _mage.Mana += x;
                            if (_mage.Mana < 0) _mage.Mana = 0;
                            if (_mage.Mana > 100) _mage.Mana = 100;
                            break;
                        case "healer":
                            _healer.Mana += x;
                            if (_healer.Mana < 0) _healer.Mana = 0;
                            if (_healer.Mana > 100) _healer.Mana = 100;
                            break;

                    }
                    break;


            }
        }

        internal int choix(string perso)
        {
            int verif_cursor = 0;
            int Dpsinflige = 0;
            ConsoleKeyInfo _key;
            char[] tabChoix = { '>', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
            bool écriture_test = true;
            bool valid_choix = false;
            if (returnStatLifePerso(perso) != 0)
            {
                while (!valid_choix)
                {
                    if (écriture_test)
                    {

                        Console.Write("Le "+ perso+" prépare une action:\n\n");

                        Console.Write(tabChoix[0] + "Atack \n");
                        Console.Write(tabChoix[1] + "Abilities \n");
                        Console.Write(tabChoix[2] + "DEF \n");

                        écriture_test = false;
                    }

                    _key = Console.ReadKey();
                    switch (_key.Key)
                    {

                        case ConsoleKey.UpArrow:
                            if (verif_cursor != 0)
                            {
                                tabChoix[verif_cursor] = ' ';
                                verif_cursor--;
                                tabChoix[verif_cursor] = '>';
                                écriture_test = true;

                            }

                            break;


                        case ConsoleKey.DownArrow:
                            if (verif_cursor != 2)
                            {
                                tabChoix[verif_cursor] = ' ';
                                verif_cursor++;
                                tabChoix[verif_cursor] = '>';
                                écriture_test = true;

                            }

                            break;
                        case ConsoleKey.Enter:
                            valid_choix = true;

                            break;
                        default:


                            break;
                    }


                }
                if (tabChoix[0] == '>') { Dpsinflige += returnStatDPSPerso(perso); }
                if (tabChoix[1] == '>')
                {

                    tabChoix[1] = ' ';
                    tabChoix[0] = '>';
                    verif_cursor = 0;
                    écriture_test = true;
                    valid_choix = false;

                    while (!valid_choix)
                    {

                        if (écriture_test)
                        {
                            Console.Clear();
                            for (int k = 0; k < 10; k++)
                            {
                                Console.Write(tabChoix[k] + _abilities[k].name + "\n");
                                if (tabChoix[k] == '>')
                                {
                                    Console.Write("\n->" + _abilities[k].description + "\n");
                                    Console.Write("-> Gain: " + _abilities[k].stat + "    Cost: " + _abilities[k].mana + "\n\n");
                                }
                            }
                            écriture_test = false;
                        }

                        _key = Console.ReadKey();
                        switch (_key.Key)
                        {

                            case ConsoleKey.UpArrow:
                                if (verif_cursor != 0)
                                {
                                    tabChoix[verif_cursor] = ' ';
                                    verif_cursor--;
                                    tabChoix[verif_cursor] = '>';
                                    écriture_test = true;

                                }

                                break;


                            case ConsoleKey.DownArrow:
                                if (verif_cursor != 10)
                                {
                                    tabChoix[verif_cursor] = ' ';
                                    verif_cursor++;
                                    tabChoix[verif_cursor] = '>';
                                    écriture_test = true;

                                }

                                break;
                            case ConsoleKey.Enter:
                                valid_choix = true;

                                break;
                            default:


                                break;
                        }

                        if (perso == "hero")
                        {
                            if (_abilities[verif_cursor].stat > _hero.Mana) { valid_choix = false; }
                        }
                        if (perso == "mage")
                        {
                            if (_abilities[verif_cursor].stat > _mage.Mana) { valid_choix = false; }
                        }
                        if (perso == "healer")
                        {
                            if (_abilities[verif_cursor].stat > _healer.Mana) { valid_choix = false; }
                        }


                    }

                    if (_abilities[verif_cursor].buff_type == "life")
                    {
                        int tpm = verif_cursor;

                        tabChoix[verif_cursor] = ' ';
                        tabChoix[0] = '>';
                        verif_cursor = 0;
                        écriture_test = true;
                        valid_choix = false;

                        while (!valid_choix)
                        {


                            if (écriture_test)
                            {
                                Console.Write(tabChoix[0] + "hero\n");
                                Console.Write(tabChoix[1] + "mage\n");
                                Console.Write(tabChoix[2] + "healer\n");
                            }


                            _key = Console.ReadKey();
                            switch (_key.Key)
                            {

                                case ConsoleKey.UpArrow:
                                    if (verif_cursor != 0)
                                    {
                                        tabChoix[verif_cursor] = ' ';
                                        verif_cursor--;
                                        tabChoix[verif_cursor] = '>';
                                        écriture_test = true;

                                    }

                                    break;


                                case ConsoleKey.DownArrow:
                                    if (verif_cursor != 2)
                                    {
                                        tabChoix[verif_cursor] = ' ';
                                        verif_cursor++;
                                        tabChoix[verif_cursor] = '>';
                                        écriture_test = true;

                                    }

                                    break;
                                case ConsoleKey.Enter:
                                    valid_choix = true;

                                    break;
                                default:


                                    break;
                            }
                        }
                        if (verif_cursor == 0)
                        {
                            ModifieStat("life", _abilities[tpm].stat, "hero");
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }
                        if (verif_cursor == 1)
                        {
                            ModifieStat("life", _abilities[tpm].stat, "mage");
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }
                        if (verif_cursor == 2)
                        {
                            ModifieStat("life", _abilities[tpm].stat, "healer");
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }
                    }
                    if (_abilities[verif_cursor].buff_type == "atk")
                    {
                        Dpsinflige += _abilities[verif_cursor].stat;
                        ModifieStat("Mana", _abilities[verif_cursor].mana, perso);
                        
                    }
                    if (_abilities[verif_cursor].buff_type == "amelioration_atk")
                    {
                        int tpm = verif_cursor;

                        tabChoix[verif_cursor] = ' ';
                        tabChoix[0] = '>';
                        verif_cursor = 0;
                        écriture_test = true;
                        valid_choix = false;

                        while (!valid_choix)
                        {


                            if (écriture_test)
                            {
                                Console.Write(tabChoix[0] + "hero\n");
                                Console.Write(tabChoix[1] + "mage\n");
                                Console.Write(tabChoix[2] + "healer\n");
                            }


                            _key = Console.ReadKey();
                            switch (_key.Key)
                            {

                                case ConsoleKey.UpArrow:
                                    if (verif_cursor != 0)
                                    {
                                        tabChoix[verif_cursor] = ' ';
                                        verif_cursor--;
                                        tabChoix[verif_cursor] = '>';
                                        écriture_test = true;

                                    }

                                    break;


                                case ConsoleKey.DownArrow:
                                    if (verif_cursor != 2)
                                    {
                                        tabChoix[verif_cursor] = ' ';
                                        verif_cursor++;
                                        tabChoix[verif_cursor] = '>';
                                        écriture_test = true;

                                    }

                                    break;
                                case ConsoleKey.Enter:
                                    valid_choix = true;

                                    break;
                                default:


                                    break;
                            }
                        }
                        if (_abilities[verif_cursor].buff_type == "kill")
                        {
                            Dpsinflige += _abilities[verif_cursor].stat;
                            if(perso == "hero"){_hero.Life = 0;}
                            if (perso == "mage") { _hero.Life = 0; }
                            if (perso == "healer") { _hero.Life = 0; }
                        }


                            if (verif_cursor == 0)
                        {
                            _hero.Dps += _abilities[tpm].stat;
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }
                        if (verif_cursor == 1)
                        {
                            _mage.Dps += _abilities[tpm].stat;
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }
                        if (verif_cursor == 2)
                        {
                            _healer.Dps += _abilities[tpm].stat;
                            ModifieStat("Mana", _abilities[tpm].mana, perso);
                        }




                    }
                    


                }
                if (tabChoix[2] == '>') { ModifieStat("Mana", 15, perso); }
            }
      
            return Dpsinflige;
        }

        internal int Lifeteam()
        {
            return _hero.Life + _mage.Life + _healer.Life;
        }

        internal void SerializeAllPerso()
        {
            var hero = new StatPerso
            {
                Name = _hero.Name,
                Life = _hero.Life,
                Mana= _hero.Mana,
                Dps= _hero.Dps
            };
            var mage = new StatPerso
            {
                Name = _mage.Name,
                Life = _mage.Life,
                Mana = _mage.Mana,
                Dps = _mage.Dps
            };
            var healer = new StatPerso
            {
                Name = _healer.Name,
                Life = _healer.Life,
                Mana = _healer.Mana,
                Dps = _healer.Dps
            };
            string stinghero = JsonSerializer.Serialize(hero);
            string stingmage = JsonSerializer.Serialize(mage);
            string stinghealer = JsonSerializer.Serialize(healer);
            File.WriteAllText(@"../../../../design/perso/hero.json", stinghero);
            File.WriteAllText(@"../../../../design/perso/mage.json", stingmage);
            File.WriteAllText(@"../../../../design/perso/healer.json", stinghealer);
        }
        internal void initAllPerso()
        {

            var hero = new StatPerso
            {
                Name = "hero",
                Life = 100,
                Mana = 100,
                Dps = 10
            };
            var mage = new StatPerso
            {
                Name = "mage",
                Life = 100,
                Mana = 100,
                Dps = 8
            };
            var healer = new StatPerso
            {
                Name = "healer",
                Life = 100,
                Mana = 100,
                Dps = 5
            };
            string stinghero = JsonSerializer.Serialize(hero);
            string stingmage = JsonSerializer.Serialize(mage);
            string stinghealer = JsonSerializer.Serialize(healer);
            File.WriteAllText(@"../../../../design/perso/hero.json", stinghero);
            File.WriteAllText(@"../../../../design/perso/mage.json", stingmage);
            File.WriteAllText(@"../../../../design/perso/healer.json", stinghealer);
        }

        internal void Save()
        {
            File.WriteAllText(@"../../../../design/perso/herosave.json", File.ReadAllText(@"../../../../design/perso/hero.json"));
            File.WriteAllText(@"../../../../design/perso/magesave.json", File.ReadAllText(@"../../../../design/perso/mage.json"));
            File.WriteAllText(@"../../../../design/perso/healersave.json", File.ReadAllText(@"../../../../design/perso/healer.json"));
        }

        internal void Deserialize()
        {
            File.WriteAllText(@"../../../../design/perso/hero.json", File.ReadAllText(@"../../../../design/perso/herosave.json"));
            File.WriteAllText(@"../../../../design/perso/mage.json", File.ReadAllText(@"../../../../design/perso/magesave.json"));
            File.WriteAllText(@"../../../../design/perso/healer.json", File.ReadAllText(@"../../../../design/perso/healersave.json"));
        }
    }
}