using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_ReRun_ICE_Task_2
{
    public class Dragon : AttackingUnit
    {
        public Dragon() : base(1500, 120, 60, 0, 25)
        {
            int dragRoll = rng.Next(1, 5);

            switch(dragRoll)
            {
                case 1:
                    propName = "Fire Dragon";
                    break;
                case 2:
                    propName = "Ice Dragon";
                    break;
                case 3:
                    propName = "Wind Dragon";
                    break;
                case 4:
                    propName = "Earth Dragon";
                    break;
            }
        }
    }
}
