using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_ReRun_ICE_Task_2
{
    public abstract class AttackingUnit
    {
        private string name; // name variable

        public string propName //name property
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        private int hp; //hp variable

        public int propHp //hp property
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        private int atk;// attack variable

        public int propAtk// attack property
        {
            get
            {
                return atk;
            }

            set
            {
                atk = value;
            }
        }

        private int def; //defence variable

        public int propDef //defence property
        {
            get
            {
                return def;
            }

            set
            {
                def = value;
            }
        }

        private int dodge; //dodge variable

        public int propDodge //dodge property
        {
            get
            {
                return dodge;
            }

            set
            {
                dodge = value;
            }
        }

        private int crit; //critical chance variable

        public int propCrit //critical chance property
        {
            get
            {
                return crit;
            }

            set
            {
                crit = value;
            }
        }

        public Random rng; //Random object


        public AttackingUnit(int health, int attack, int defence, int doge, int critical)
        {
            propHp = health;
            propAtk = attack;
            propDef = defence;
            propDodge = doge;
            propCrit = critical;
            rng = new Random();
        }

        public bool dodgeMethod(int chanceDodge) //method for dodging
        {
            bool doesDodge;
            int dodgePerc = rng.Next(1, 101);
            
            if (chanceDodge > dodgePerc)
            {
                doesDodge = true;
            }

            else
            {
                doesDodge = false;
            }

            return doesDodge;
        }

        public bool criticalHit(int critical) //critical method
        {
            bool doesCrit;
            
            int critPerc = rng.Next(1, 101);

            if (critical > critPerc)
            {
                doesCrit = true;
                
            }
            else
            {
                doesCrit = false;
            }

            return doesCrit;
        }

        public int damage(int atckDamage, int targetDef, int targetHealth) // damage method
        {
            int damageDealt = atckDamage - targetDef;
            if (damageDealt < 0)
            {
                damageDealt = 0;
            }
            int newHealth = targetHealth - damageDealt;
            return newHealth;
        }

        public int attack(string attackName, string targetName,int targetDodge, int attackCrit, int attackDamage, int targetDef, int targetHealth)
        {
            int attackDam;
            Console.WriteLine(attackName + " attacks");
            if (dodgeMethod(targetDodge) == true)
            {
                attackDam = 0;
                Console.WriteLine(targetName + " dodged");
            }
            else
            {
                if(criticalHit(attackCrit) == true)
                {
                    attackDam = attackDamage * 3;
                    Console.WriteLine("Its a critical hit");
                }
                else
                {
                    attackDam = attackDamage;
                }
            }
            int damageDealt = attackDam - targetDef;
            if(damageDealt < 0)
            {
                damageDealt = 0;
            }
            Console.WriteLine(attackName + " does " + damageDealt + " to " + targetName);
            int targetNewHealth = damage(attackDam, targetDef, targetHealth);
            Console.WriteLine(targetName + " has " + targetNewHealth + " left");

            return targetNewHealth;
        }

        public bool isDead(int targetHealth)
        {
            bool ded;
            if(targetHealth <= 0)
            {
                ded = true;
            }
            else
            {
                ded = false;
            }
            return ded;
        }



    }
}
