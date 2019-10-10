using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Deck
    {
        string[] suits = new[] { "C", "S", "D", "H" };
        string[] ranks = new[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();
            foreach(string suit in suits)
            {
                foreach(string rank in ranks)
                {
                    Cards.Add(new Card(rank, suit));
                }
            }
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            Cards = Cards.OrderBy(c => rnd.Next()).ToList();
        }

        public Card GetCard()
        {
            Card card = Cards.Last();
            Cards.Remove(card);

            return card;
            
        }
    }
}
