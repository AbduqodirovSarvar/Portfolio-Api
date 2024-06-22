using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.ViewModels
{
    public class LoginViewModel(UserViewModel user, string accessToken)
    {
        public UserViewModel? User { get; set; } = user;
        public string? AccessToken { get; set; } = accessToken;
    }
}
