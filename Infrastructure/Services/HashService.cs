using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class HashService : IHashService
    {
        public string GetHash(string password)
        {
            throw new NotImplementedException();
        }

        public bool VerifyHash(string password, string paswordHash)
        {
            throw new NotImplementedException();
        }
    }
}
