using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Game
    {
        private IBlackjackPlayer PlayerOne;
        private IBlackjackPlayer PlayerTwo;
        private Deck Deck;

        public void StartNewGame()
        {
            PlayerOne = new Player();
            PlayerTwo = new Dealer();
            Deck = new Deck();
            Deck.Shuffle();

            PlayerOne.GiveCard(Deck.GetCard());
            PlayerOne.GiveCard(Deck.GetCard());

            PlayerTwo.GiveCard(Deck.GetCard());
            PlayerTwo.GiveCard(Deck.GetCard());
        }
        public void Loop()
        {
            while(!PlayerOne.IsGameCompleted() && PlayerOne.WantCard())
            {
                PlayerOne.GiveCard(Deck.GetCard());
            }
            if(PlayerOne.CountPoints() > 21)
            {
                Console.WriteLine("You lose!");
            }
            else if(PlayerOne.CountPoints() == 21)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Dealer's turn:");
                while (!PlayerTwo.IsGameCompleted() && PlayerTwo.WantCard())
                {
                    PlayerTwo.GiveCard(Deck.GetCard());
                }
                int playerPoints = PlayerOne.CountPoints();
                int dealerPoints = PlayerTwo.CountPoints();
                Console.WriteLine("Your points: {0}", playerPoints);
                Console.WriteLine("Dealer's points: {0}", dealerPoints);
                //if (dealerPoints > 21 || playerPoints > dealerPoints)
                //{
                //    Console.WriteLine("You win!");
                //}
                //else
                //{
                //    Console.WriteLine("You lose!");
                //}
                Console.WriteLine(dealerPoints > 21 || playerPoints > dealerPoints ? "You win!" : "You lose!");
            }
        }
            
    }
}
