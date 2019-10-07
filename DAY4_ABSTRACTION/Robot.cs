using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    class Robot : BasePlayer
    {
        public override string GetName()
        {
            return "ROBOT";
        }
        public override int GuessNumber()
        {
            
            CurrentGuess =  new Random().Next(1, 501);
            return CurrentGuess;
        }
    }
}
