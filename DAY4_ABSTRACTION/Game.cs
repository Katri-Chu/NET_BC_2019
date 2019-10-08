using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        private int CurrentNumber;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;        public void StartNewGame()
        {
            CurrentNumber = new Random().Next(1, 501);
            PlayerOne = new User();
            PlayerTwo = new Robot();

        }

        public void Loop()
        {
            while (true)
            {
                Console.WriteLine("Player one turn: ");
                if(PlayerTurn(PlayerOne))
                {
                    break;
                }
                Console.WriteLine("Player two turn: ");
                if (PlayerTurn(PlayerTwo))
                {
                    break;
                }
                /* bool IsNumberGuessed = false;
                 * while (!IsNumberGuessed)
                 * if (PlayerOne.GuessNumber() == CurrentNumber)
                 {
                     Console.WriteLine("Player one wins!");
                     break;
                 }

                 if (PlayerTwo.GuessNumber() == CurrentNumber)
                 {
                     Console.WriteLine("Player two wins!");
                     break;
                 }(mans variants, arī pareizs)*/
                // while(true)
                //{
                //PlayerTurn(PlayerOne); 
                //if(Playerone.IsnumberGuessed(CurrentNumber))
                //{Console.WriteLine("Player one wins!");
                //break;
                //PlayerTurn(PlayerTwo);
                //}(sākotnējais variants, pirms izmaiņām)
            }
        }

         private bool PlayerTurn(IPlayer player)
        {
            player.GuessNumber();
            bool isGuessed = player.IsNumberGuessed(CurrentNumber);

            if(isGuessed)
            {
                Console.WriteLine("Player {0} wins!", player.GetName());
            }
            return isGuessed;

        }
    }
}
