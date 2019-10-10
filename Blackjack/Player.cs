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
        string GetName()
        {
            return ConsoleInput.GetText("Enter your name: ");
        }
        bool WantCard()
        {
           //string want = Console.WriteLine("Do you want another card?(y/n");
            Console.ReadLine();
            while(want == "y")
            {

            }


        }

    }
}
