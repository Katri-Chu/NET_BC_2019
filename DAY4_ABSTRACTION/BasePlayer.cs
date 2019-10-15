using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    /// <summary>
    /// Abstract class of all methods that need to be realised 
    /// </summary>
    public abstract class BasePlayer : IPlayer
    {
        protected string Name;
        protected int CurrentGuess;
        protected int NextGuess;

        /// <summary>
        /// Constructor of players
        /// </summary>
        public BasePlayer()
        {
            Name = GetName();
        }
        public abstract string GetName();

        public abstract int GuessNumber();
        
        public virtual bool IsNumberGuessed(int number)
        {
            if(number > CurrentGuess)
            {
                Console.WriteLine("{0} is less than the number!", CurrentGuess);
                NextGuess = 1;
            }
            else if(number < CurrentGuess)
            {
                Console.WriteLine("{0} is greater than the number!", CurrentGuess);
                NextGuess = -1;
            }
            return (number == CurrentGuess);
        }

    }
}
