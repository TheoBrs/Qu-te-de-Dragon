using Quête_de_Dragon;
using static System.Net.Mime.MediaTypeNames;

namespace Projet7_Battle
{
    public class Tests
    {
        Map map;

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

            map.writeText("Vous infligez " + damage + " dégâts !");

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

            map.writeText("Vous infligez " + damage + " dégâts !");

            return Damages(damage, ennemyLife);
        }


        public int Skill(int playerAtt, int playerMP, int skillDamage, int skillCost, int ennemyDef, int ennemyLife)
        {
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

            map.writeText("Vous infligez " + damage + " dégâts !");

            return Damages(damage, ennemyLife);
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
                map.writeText("Vous parvenez à vous échapper !");
            }
            else
            {
                return canEscape = false;
                map.writeText("...Mais l'ennemi vous bloque le chemin.");
            }

        }


        public int EnnemyAttack(int ennemyAtt, int playerDef, int playerLife)
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

            map.writeText("Vous prenez " + damage + " dégâts !");

            return Damages(damage, playerLife);

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

    //Juste pour push
}