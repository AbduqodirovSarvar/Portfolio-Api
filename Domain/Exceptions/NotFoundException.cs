using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class NotFoundException : Exception
    {
        private const string _message = "This data not found";
        public NotFoundException() 
            : base(_message) { }
        public NotFoundException(string message) 
            : base(message) { }
    }
}
