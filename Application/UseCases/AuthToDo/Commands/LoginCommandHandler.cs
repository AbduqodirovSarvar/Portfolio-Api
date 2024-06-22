using Application.Abstractions;
using Application.Exceptions;
using Application.Models.ViewModels;
using AutoMapper;
using Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.AuthToDo.Commands
{
    public class LoginCommandHandler(
        IAppDbContext appDbContext,
        IMapper mapper,
        ILogger<LoginCommandHandler> logger,
        IHashService hashService,
        ITokenService tokenService
        ) : IRequestHandler<LoginCommand, LoginViewModel>
    {
        private readonly IAppDbContext _context = appDbContext;
        private readonly IMapper _mapper = mapper;
        private readonly ILogger<LoginCommandHandler> _logger = logger;
        private readonly IHashService _hashService = hashService;
        private readonly ITokenService _tokenService = tokenService;

        public async Task<LoginViewModel> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                                .Include(x => x.Languages).ThenInclude(l => l.Language)
                                .Include(x => x.Languages).ThenInclude(l => l.Level)
                                .Include(x => x.Projects)
                                .Include(x => x.Skills).ThenInclude(x => x.Skill)
                                .Include(x => x.Certificates)
                                .Include(x => x.Educations).ThenInclude(x => x.Education)
                                .Include(x => x.Experiences).ThenInclude(x => x.Company)
                                .Include(x => x.Experiences).ThenInclude(x => x.Position)
                                .Include(x => x.Experiences).ThenInclude(x => x.WorkType)
                                .FirstOrDefaultAsync(x => x.Email == request.Email, cancellationToken: cancellationToken)
                                ?? throw new NotFoundException("User not found");

            _logger.LogInformation(message: "User found with identifier {userId}", user.Id);

            if(!_hashService.VerifyHash(request.Password, user.PasswordHash))
            {
                throw new LoginException();
            }

            var claims = new List<Claim>
                {
                    new(ClaimTypes.NameIdentifier, user.Id.ToString()),
                };

            _logger.LogInformation("Gave access token for identifier Id: {Identifier}", user.Id);

            return new LoginViewModel(_mapper.Map<UserViewModel>(user), _tokenService.GetAccessToken([.. claims]));
        }
    }
}
