using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_ReRun_ICE_Task_2
{
    public class GameEngine
    {
        public AttackingUnit[] fighter = new AttackingUnit[2];

        public GameEngine()
        {
            
            fighter[0] = new Knight();
            fighter[1] = new Dragon();
           
        }

        public void playGame(AttackingUnit fighter0, AttackingUnit fighter1)
        {
            Random turnRoll = new Random();

            Console.WriteLine("Let The Battle Begin");
            int roundNum = 1;
            while(fighter0.propHp > 0 && fighter1.propHp > 0) //where the combat happens
            {
                Console.WriteLine("Round " + roundNum);

                int turn = turnRoll.Next(1, 3);
                if (turn == 1)
                {
                    Console.WriteLine(fighter0.propName + " Goes First");
                    fighter1.propHp = fighter0.attack(fighter0.propName, fighter1.propName, fighter1.propDodge, fighter0.propCrit, fighter0.propAtk, fighter1.propDef, fighter1.propHp);
                    if(fighter1.propHp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Now " + fighter1.propName + " Attacks");
                    fighter0.propHp = fighter1.attack(fighter1.propName, fighter0.propName, fighter0.propDodge, fighter1.propCrit, fighter1.propAtk, fighter0.propDef, fighter0.propHp);
                }
                else
                {
                    Console.WriteLine(fighter1.propName + " Goes First");
                    fighter0.propHp = fighter1.attack(fighter1.propName, fighter0.propName, fighter0.propDodge, fighter1.propCrit, fighter1.propAtk, fighter0.propDef, fighter0.propHp);
                    if(fighter0.propHp <= 0)
                    {
                        break;
                    }
                    Console.WriteLine("Now " + fighter0.propName + " Attacks");
                    fighter1.propHp = fighter0.attack(fighter0.propName, fighter1.propName, fighter1.propDodge, fighter0.propCrit, fighter0.propAtk, fighter1.propDef, fighter1.propHp);

                }

                roundNum++;

            }

            if (fighter0.propHp > fighter1.propHp)
            {
                Console.WriteLine(fighter0.propName + " is Victorious!!!");
            }
            else
            {
                Console.WriteLine(fighter1.propName + " is Victorious!!!");
            }
        }
    }
}
