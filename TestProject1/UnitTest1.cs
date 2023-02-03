using Qu�te_de_Dragon;
using static System.Net.Mime.MediaTypeNames;

namespace Projet7_Battle
{
    public class Tests
    {
        Map map;

        List<string> ennemySkills = new List<string>();
        List<int> ennemySkillCost = new List<int>();
        List<int> ennemySkillPower = new List<int>();

        public int Attack(int playerAtt, int ennemyDef, int ennemyLife)
        {
            bool criticalHit = Critical();
            int damage;

            if (criticalHit == false)
            {
                damage = (playerAtt / 2) - (ennemyDef / 4);
            }
            else
            {
                damage = (playerAtt / 2);
            }

            map.writeText("Vous infligez " + damage + " d�g�ts !");

            return Damages(damage, ennemyLife);
        }


        public int Spell(int playerMagAtt, int playerMP, int spellDamage, int spellCost, int ennemyDef, int ennemyLife)
        {
            if (playerMP < spellCost)
            {
                return 0;
            }

            playerMP -= spellCost;
            bool criticalHit = Critical();
            int damage;

            if (criticalHit == false)
            {
                damage = ((spellDamage * playerMagAtt) / 200) - (ennemyDef / 4);
            }
            else
            {
                damage = ((spellDamage * playerMagAtt) / 200);
            }

            map.writeText("Vous infligez " + damage + " d�g�ts !");

            return Damages(damage, ennemyLife);
        }


        public int Skill(int playerAtt, int playerMP, int skillDamage, int skillCost, int ennemyDef, int ennemyLife)
        {
            if (playerMP < skillCost)
            {
                return 0;
            }

            playerMP -= skillCost;
            bool criticalHit = Critical();
            int damage;

            if (criticalHit == false)
            {
                damage = ((skillDamage * playerAtt) / 200) - (ennemyDef / 4);
            }
            else
            {
                damage = ((skillDamage * playerAtt) / 200);
            }

            map.writeText("Vous infligez " + damage + " d�g�ts !");

            return Damages(damage, ennemyLife);
        }

        public int EnnemySkill(int ennemyAtt, int ennemyMP, int skillDamage, int skillCost, int playerDef, int playerLife)
        {
            if (ennemyMP < skillCost)
            {
                return 0;
            }

            ennemyMP -= skillCost;
            bool criticalHit = Critical();
            int damage;

            if (criticalHit == false)
            {
                damage = ((skillDamage * ennemyAtt) / 200) - (playerDef / 4);
            }
            else
            {
                damage = ((skillDamage * ennemyAtt) / 200);
            }

            map.writeText("L'ennemi vous inflige " + damage + " d�g�ts !");

            return Damages(damage, playerLife);
        }

        

        public int Damages(int damage, int entityLife)
        {
            entityLife = Math.Max(0, entityLife - damage);

            return entityLife;
        }


        public void Info(string ennemyInfo)
        {
            map.writeText(ennemyInfo);
        }


        public bool Run(int ennemyChanceToEscape)
        {
            bool canEscape = false;
            Random randomNumber = new Random();

            if (randomNumber.Next(100) <= ennemyChanceToEscape)
            {
                return canEscape = true;
                map.writeText("Vous parvenez � vous �chapper !");
            }
            else
            {
                return canEscape = false;
                map.writeText("...Mais l'ennemi vous bloque le chemin.");
            }

        }


        

        public void isPlayerDead(int characterLife, int damage)
        {
            if (characterLife - damage <= 0)
            {
                playerDeath();
            }
            else
            {
            }
        }

        public void playerDeath()
        {

        }

        public void isMonsterDead(int monsterLife, int damage)
        {
            if (monsterLife - damage <= 0)
            {
                playerVictory();
            }
            else
            {
            }
        }

        public void playerVictory()
        {

        }


        

    }
}