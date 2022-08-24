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
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        Random random = new Random();
        public int  DieRoll()
        {
            int dieCount = random.Next(1, 7);
            return dieCount;
        }
        public void Play()
        {
            while (PlayerPosition < 100)
            {
                int Option = random.Next(0, 3);
                switch (Option)
                {
                    case NO_PLAY:
                        PlayerPosition += 0;
                        break;
                    case LADDER:
                        int die = DieRoll();
                        PlayerPosition += die;
                        if(PlayerPosition > 100)
                        {
                            PlayerPosition -= die;
                        }
                        break;
                    case SNAKE:
                        PlayerPosition -= DieRoll();
                        if (PlayerPosition < 0)
                        {
                            PlayerPosition = 0;
                        }
                        break;
                }
            }
            if (PlayerPosition == WINNING_POSITION)
            {
                Console.WriteLine(PlayerPosition);
            } 
        }
    }    
}
