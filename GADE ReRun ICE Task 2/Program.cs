using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_ReRun_ICE_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngine newGame = new GameEngine();
            newGame.playGame(newGame.fighter[0], newGame.fighter[1] ); 
        }
    }
}
