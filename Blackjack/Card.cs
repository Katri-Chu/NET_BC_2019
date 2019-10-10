using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Card
    {
        string Rank { get; set; }

        string Suit { get; set; }

        public Card(string rank, string suit)
            {
            Rank = rank;
            Suit = suit;
        }
        public string GetTitle()
        {
            return Suit + Rank;
        }
        

        public int GetPoints()
        {
            switch(Rank)
                {
                case "J":
                case "Q":
                case "K":
                    return 10;
                case "A":
                    return 11;
                default:
                    return int.Parse(Rank);
                    
            }
        }

    }
}
