using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        int CurrentNumber;
        IPlayer PlayerOne;
        IPlayer PlayerTwo;        public void StartNewGame()
        {
            Random random = new Random();
            CurrentNumber = random.Next(1, 501);
            PlayerOne = new User();
            PlayerTwo = new Robot();

        }

        public void Loop()
        {

        }
    }
}
