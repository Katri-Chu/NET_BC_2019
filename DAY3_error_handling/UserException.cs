using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY3_error_handling
{
    class UserException : Exception
    {
        public UserException(string message) : base(message)
        {

        }
    }
}
