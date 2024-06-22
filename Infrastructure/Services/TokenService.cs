using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class TokenService : ITokenService
    {
        public string GetAccessToken(Claim[] claims)
        {
            throw new NotImplementedException();
        }
    }
}
