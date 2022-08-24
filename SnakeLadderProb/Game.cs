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
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2;
        Random random = new Random();
        public int  DieRoll()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
        public void Play()
        {
            int Option = random.Next(0, 3);
            switch (Option)
            {
                case NO_PLAY:
                    PlayerPosition += 0;
                    break;
                case LADDER:
                    PlayerPosition +=DieRoll();
                    break;
                case SNAKE:
                    PlayerPosition -=DieRoll();
                    break;
            }
            Console.WriteLine(PlayerPosition);
        }
    }    
}
