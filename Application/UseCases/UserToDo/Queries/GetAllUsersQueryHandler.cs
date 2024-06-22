using Application.Abstractions;
using Application.Models.ViewModels;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.UserToDo.Queries
{
    public class GetAllUsersQueryHandler(
        IAppDbContext appDbContext,
        IMapper mapper
        ) : IRequestHandler<GetAllUsersQuery, List<UserViewModel>>
    {
        private readonly IAppDbContext _context = appDbContext;
        private readonly IMapper _mapper = mapper;
        public async Task<List<UserViewModel>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _context.Users
                                .Include(u => u.Position)
                                .Include(u => u.Languages).ThenInclude(ul => ul.Language)
                                .Include(u => u.Languages).ThenInclude(ul => ul.Level)
                                .Include(u => u.Projects)
                                .Include(u => u.Skills).ThenInclude(us => us.Skill)
                                .Include(u => u.Certificates)
                                .Include(u => u.Educations).ThenInclude(ue => ue.Education).ThenInclude(ci => ci.City).ThenInclude(co => co.Country)
                                .Include(u => u.Experiences).ThenInclude(ue => ue.Company).ThenInclude(ci => ci.City).ThenInclude(co => co.Country)
                                .Include(u => u.Experiences).ThenInclude(ue => ue.Position)
                                .Include(u => u.Experiences).ThenInclude(ue => ue.WorkType)
                                .ToListAsync(cancellationToken);
            return _mapper.Map<List<UserViewModel>>(users);
        }
    }
}
