using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        internal void init()
        {

            _hero = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"C:\Users\aleksi\source\repos\Qu-te-de-Dragon\design\hero.json"));
            _mage = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"C:\Users\aleksi\source\repos\Qu-te-de-Dragon\design\mage.json"));
            _healer = JsonSerializer.Deserialize<StatPerso>(File.ReadAllText(@"C:\Users\aleksi\source\repos\Qu-te-de-Dragon\design\healer.json"));

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
                                   if (_mage.Life > 100)_mage.Life = 100;
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
                                   _healer.Life += x;
                                   if (_healer.Mana < 0) _healer.Mana = 0;
                                   if (_healer.Mana > 100) _healer.Mana = 100;
                                   break;

                           }
                           break;


                   }
               }

        
    }
}