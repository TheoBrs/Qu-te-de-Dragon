using Quête_de_Dragon;
using static System.Net.Mime.MediaTypeNames;

namespace Projet7_Battle
{
    public class Tests
    {
        Map map;
        TeamBuild team;

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

            map.writeText("Vous infligez " + damage + " dégâts !");

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

            map.writeText("L'ennemi vous inflige " + damage + " dégâts !");

            return Damages(damage, playerLife);
        }

        

        [Test]
        [TestCase(10, 30, ExpectedResult = 20)]
        public int Damages(int damage, int entityLife)
        {
            entityLife = Math.Max(0, entityLife - damage);

            return entityLife;
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


        

        public void IsPlayerDead(int characterLife, int damage)
        {
            if (characterLife - damage <= 0)
            {
                map.writeText("Vous êtes vaincus...");

                //end game
            }
            else
            {
            }
        }

        public void IsMonsterDead(int monsterLife, int damage, int monsterXp)
        {
            if (monsterLife - damage <= 0)
            {
                map.writeText("Vous avec vaincu l'ennemi !");

                team.PlayerEarnsExp(monsterXp);
                team.LevelUp();

                //Reload map
            }
            else
            {
            }
        }


        public string EnemiIA(List<string> ennemySkills)
        {
            string skillChoosed;
            int numberOfSkills = ennemySkills.Count;
            Random randomNumber = new Random();

            skillChoosed = ennemySkills[randomNumber.Next(numberOfSkills)];

            return skillChoosed;
        }

        public string EnemiSmartIA(List<string> ennemySkills, List<int> ennemySkillCost, List<int> ennemySkillPower, int ennemyMp)
        {
            string skillChoosed = ennemySkills[0];

            for(int i = 1 ; i < ennemySkills.Count ; i++)
            {
                if (ennemySkillPower[i] > 100)
                {
                    if(ennemySkillCost[i] < ennemyMp)
                    {
                        skillChoosed = ennemySkills[i];
                    }
                }
            }

            return skillChoosed;
        }


    }
}