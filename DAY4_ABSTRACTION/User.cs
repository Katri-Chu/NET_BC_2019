using ConsoleHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class User : BasePlayer
    {
        public override string GetName()
        {
            return ConsoleInput.GetText("Enter your name: ");
        }

        public override int GuessNumber()
        {
            return ConsoleInput.GetInt("Enter positive integer: ");
        }
    }
}
