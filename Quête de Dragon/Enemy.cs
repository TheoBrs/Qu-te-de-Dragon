using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace Quête_de_Dragon
{
    public class Enemy
    {
        internal object choix;
        Slime _slime = new Slime();
        GreenDragon _dragon= new GreenDragon();
        string monstre = "slime";


        private string name = "slime";
        private int LifeEnemy = 30;
        private int ManaEnemy = 50;
        private int DpsEnemy = 10;


        public int GetLife() { return LifeEnemy; }
        public int GetMana() { return ManaEnemy; }
        public int GetDps() { return DpsEnemy; }

        public void enemySubitDps(int Dps)
        {
            LifeEnemy = Math.Max(LifeEnemy - Dps, 0 );
        }
        public string enemiIA(List<string> ennemySkills)
        {
            string skillChoosed;
            int numberOfSkills = ennemySkills.Count;
            Random randomNumber = new Random();

            skillChoosed = ennemySkills[randomNumber.Next(numberOfSkills)];

            return skillChoosed;
        }

        public string enemiSmartIA(List<string> ennemySkills, List<int> ennemySkillCost, List<int> ennemySkillPower, int ennemyMp)
        {
            string skillChoosed = ennemySkills[0];

            for (int i = 1; i < ennemySkills.Count; i++)
            {
                if (ennemySkillPower[i] > 100)
                {
                    if (ennemySkillCost[i] < ennemyMp)
                    {
                        skillChoosed = ennemySkills[i];
                    }
                }
            }

            return skillChoosed;
        }

        public bool Critical()
        {
            bool criticalHit = false;
            Random randomNumber = new Random();

            if (randomNumber.Next(100) <= 9)
            {
                criticalHit = true;
            }

            return criticalHit;
        }
        public string ChoixJoueur()
        {
            Random nbr = new Random();
            int joueur = nbr.Next(0,3);
            Console.Write(joueur);
            if (joueur == 0) return "hero";
            if (joueur == 1) return "mage";
            else return "healer";
        }
        public int EnemyAttack(int ennemyAtt, int playerDef, int playerLife)
        {
            bool criticalHit = Critical();
            int damage;

            if (criticalHit == false)
            {
                damage = (ennemyAtt / 2) - (playerDef / 4);
            }
            else
            {
                damage = (ennemyAtt / 2);
            }

            Console.Write("Vous prenez " + damage + " dégâts !");

            return damage;

        }

        internal void Draw()
        {
            if (monstre == "slime") _slime.DrawSlime();
            else _dragon.DrawDragon();
        }
    }
}