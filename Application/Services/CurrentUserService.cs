﻿using Application.Abstractions;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public Guid UserId { get; set; }

        public CurrentUserService(IHttpContextAccessor _contextAccessor)
        {
            var httpContext = _contextAccessor.HttpContext;
            var userClaims = httpContext?.User.Claims;
            var idClaim = userClaims?.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
            if (idClaim != null && Guid.TryParse(idClaim.Value, out Guid value))
            {
                UserId = value;
            }
        }
    }
}
