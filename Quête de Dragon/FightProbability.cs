using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quête_de_Dragon
{

    public class FightProbability
    {
        int probability = 1;
        Random random = new();

        public bool AleatoryFight()
        {
            int i = random.Next(100);
            if (probability > i)
            {
                probability = 1;
                return true;
            }
            probability++;

            return false;

        }

        public void RunFight()
        {


            Enemy enemy = new();
            Fight_Team team = new();

            var _key = Console.ReadKey();
            team.init();
            int boucle = 1;
            while (team.Lifeteam() != 0 && enemy.GetLife() != 0)
            {

                if (true)
                {
                    Console.Clear();
                    enemy.Draw();
                    Console.Write("Life hero: " + team.returnStatLifePerso("hero") + " Mana hero: " + team.returnStatManaPerso("hero") + "\n\n");
                    Console.Write("Life mage: " + team.returnStatLifePerso("mage") + " Mana mage: " + team.returnStatManaPerso("mage") + "\n\n");
                    Console.Write("Life healer: " + team.returnStatLifePerso("healer") + " Mana healer: " + team.returnStatManaPerso("healer") + "\n\n");
                }

                //choix de la team chaque perso atk ou autre 

                if (boucle == 1) enemy.enemySubitDps(team.choix("hero"));
                if (boucle == 2) enemy.enemySubitDps(team.choix("mage"));
                if (boucle == 3) enemy.enemySubitDps(team.choix("healer"));
                if (boucle == 4)
                {
                    //tour de l'enemie
                    bool choice = true;
                    while (choice)
                    {
                        string choix = enemy.ChoixJoueur();
                        if (choix == "hero" && team.returnStatLifePerso("hero") != 0)
                        {
                            team.ModifieStat("Life", -enemy.GetDps(), "hero");
                            choice = false;
                        }
                        if (choix == "mage" && team.returnStatLifePerso("mage") != 0)
                        {
                            team.ModifieStat("Life", -enemy.GetDps(), "mage");
                            choice = false;
                        }
                        if (choix == "healer" && team.returnStatLifePerso("healer") != 0)
                        {
                            team.ModifieStat("Life", -enemy.GetDps(), "healer");
                            choice = false;
                        }
                    }



                    boucle = 0;
                }
                boucle++;
                //adversaire prend des dégat if vie != 0 alors {
                //adversaire choisi qui attaquer -> return perso + degat    ou  return degat et perso choisi aléatoirement }

                /*enemy.choix();*/





                /*while (choix)
                {
                    if (ecriture)
                    {
                        Console.Write(tabChoix[0] + "Atack \n");
                        Console.Write(tabChoix[1] + "Abilities \n");
                        Console.Write(tabChoix[2] + "DEF \n");
                    }
                    if (_key != Console.ReadKey())
                    {
                        if (_key.Key == ConsoleKey.UpArrow)
                        {
                            if (choix_action != 0)
                            {
                                tabChoix[choix_action] = ' ';
                                choix_action -= 1;
                                tabChoix[choix_action] = '>';
                            }

                        }
                        if (_key.Key == ConsoleKey.UpArrow)
                        {
                            if (choix_action != 2)
                            {
                                tabChoix[choix_action] = ' ';
                                choix_action += 1;
                                tabChoix[choix_action] = '>';
                            }
                            if (_key.Key == ConsoleKey.Enter)
                            {
                                choix = true;
                            }
                        }
                    }


                }*/






                //ensuite slime/dragon

                // Enemy -> fait des degat, s'octroit des buffs ou inflige des debuffs;





                // if (ennemy == dead) alors => ( gain XP, amélioration de stats et objets peuvent etre trouver)

                /*                else if (team.persojouerlife == 0) { 

                                if (team.testallperso==0){
                                    return Game Over;
                                }



                */
            }
            team.SerializeAllPerso();
        }

        internal void DeserializePerso()
        {
            Fight_Team team = new();
            team.Deserialize();

        }
        internal void SaveSerializePerso()
        {
            Fight_Team team = new();
            team.Save();
        }
        internal void SerializePerso()
        {
            Fight_Team team = new();
            team.initAllPerso();
        }

        internal int teamLife()
        {
            Fight_Team team = new();
            team.init();
            return team.Lifeteam();
        }
    }
}