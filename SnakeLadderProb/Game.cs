using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProb
{
    internal class Game
    {
        int PlayerPosition = 0;
        public int  DieRoll()
        {
            Random random = new Random();
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
    }    
}
