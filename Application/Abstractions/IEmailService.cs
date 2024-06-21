using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IEmailService
    {
        Task<bool> SendEmail(string email, string subject, string body);
        Task<bool> SendEmailConfirmationCode(string email);
        bool CheckEmailConfirmationCode(string email, string confirmationCode);
        Task SendCongratulationsMessage(string email);
        Task<bool> SendResetPasswordConfirmationCode(string email);
    }
}
