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
            bool test = true;
            bool test2 = true;
            while(test2)
            {

                if (test) {
                    Console.Clear();
                    ennemy.DrawSlime();
                    test = false;
                    test2 = false;
                }
            }
        }
    }
}