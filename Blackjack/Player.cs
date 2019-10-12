using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player : BasePlayer
    {
        public override string GetName()
        {
            if (!String.IsNullOrEmpty(Name))
            {
                return Name;
            }
            return ConsoleInput.GetText("Enter your name: ");
        }

        public override bool WantCard()
        {
            return ConsoleInput.GetBool("Do you want another card?(y/n)");
            
        }

        public override void GiveCard(Card card)
        {
            base.GiveCard(card);

            Console.WriteLine("You received card: {0}", card.GetTitle());
            Console.WriteLine("Your points: {0}", CountPoints());
        }

        //bool WantCard()
        //{
        //string want = Console.WriteLine("Do you want another card?(y/n)");
        /*Console.WriteLine("Do you want another card?(y/n)");
        if(  = "y")
        {
            return true;
        }
        else
        {
            return false;
        }*/
        //if(want == "y")




        //}

    }
}
