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
            if (probability > i )
            {
                probability=1;
                return true;
            }
            probability++;
            
            return false;

        }
        
        public void RunFight()
        {

            Slime ennemy = new();
            Fight_Team team = new();
            bool test = true;
            bool test2 = true;
            team.init();
            while(test2)
            {

                if (test)
                {
                    Console.Clear();
                    ennemy.DrawSlime();
                    test = false;
                    
                }

                //commencement par la team 

                //Fight team -> fait des degat, s'octroit des buffs ou inflige des debuffs;


                //ensuite slime/dragon


                // Enemy -> fait des degat, s'octroit des buffs ou inflige des debuffs;


                // if (ennemy == dead) alors => ( gain XP, amélioration de stats et objets peuvent etre trouver)

/*                else if (team.persojouerlife == 0) { 
                
                if (team.testallperso==0){
                    return Game Over;
                }



*/
            }
        }
    }
}