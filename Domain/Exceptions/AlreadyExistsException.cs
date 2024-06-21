using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        private const string _message = "This data already existed";
        public AlreadyExistsException()
            : base(_message) { }
        public AlreadyExistsException(string message)
            : base(message) { }
    }
}
