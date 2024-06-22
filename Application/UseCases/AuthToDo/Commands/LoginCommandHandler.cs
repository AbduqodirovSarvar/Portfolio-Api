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
                .Include(u => u.Position)
/*                .Include(u => u.Languages).ThenInclude(ul => ul.Language)
                .Include(u => u.Languages).ThenInclude(ul => ul.Level)
                .Include(u => u.Projects)
                .Include(u => u.Skills).ThenInclude(us => us.Skill)
                .Include(u => u.Certificates)
                .Include(u => u.Educations).ThenInclude(ue => ue.Education)
                .Include(u => u.Experiences).ThenInclude(ue => ue.Company)
                .Include(u => u.Experiences).ThenInclude(ue => ue.Position)
                .Include(u => u.Experiences).ThenInclude(ue => ue.WorkType)*/
                .FirstOrDefaultAsync(u => u.Email == request.Email, cancellationToken);

            if (user == null)
            {
                _logger.LogInformation("User with email {Email} not found", request.Email);
                throw new NotFoundException("User not found");
            }

            _logger.LogInformation("User found with identifier {UserId}", user.Id);

            if (!_hashService.VerifyHash(request.Password, user.PasswordHash))
            {
                _logger.LogWarning("Invalid password attempt for user {UserId}", user.Id);
                throw new LoginException();
            }

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id.ToString())
            };

            _logger.LogInformation("Access token issued for user {UserId}", user.Id);

            var loginViewModel = new LoginViewModel(_mapper.Map<UserViewModel>(user), _tokenService.GetAccessToken([.. claims]));

            return loginViewModel;
        }
    }
}
