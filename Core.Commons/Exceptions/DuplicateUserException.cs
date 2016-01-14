using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Commons.Exceptions
{    

    public class DuplicateUserException : BaseException
    {       
        public DuplicateUserException(string message)
            : base(message)
        {
        }
    }

}
