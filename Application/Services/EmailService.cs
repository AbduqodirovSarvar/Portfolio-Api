﻿using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EmailService : IEmailService
    {
        private static readonly Dictionary<string, string> ConfirmationCodes = [];

        public bool CheckEmailConfirmationCode(string email, string confirmationCode)
        {
            if (ConfirmationCodes[email] == confirmationCode.ToString())
            {
                ConfirmationCodes.Remove(email);
                return true;
            }
            return false;
        }

        public async Task<bool> SendEmail(string email, string subject, string body)
        {
            var model = new
            {
                Name = "Test Email",
                Email = email,
                Message = body,
                Subject = subject,
            };

            body = $"<p>Email From: {model.Name} ({model.Email})</p><p>Message:</p><p>{model.Message}</p>";

            var message = new MailMessage();
            message.To.Add(new MailAddress(model.Email));
            message.From = new MailAddress("abduqodirovsarvar.2002@gmail.com");
            message.Subject = model.Subject;
            message.Body = body;
            message.IsBodyHtml = true;

            using var smtp = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("abduqodirovsarvar.2002@gmail.com", "hgjb mvzo nuji fcwb"),
                EnableSsl = true,
            };

            try
            {
                await smtp.SendMailAsync(message);
                Console.WriteLine("Message sent!");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error sending email: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> SendResetPasswordConfirmationCode(string email)
        {
            int confirmationCode = RandomNumberGenerator.GetInt32(10000, 99999);
            if (await SendEmail(email, "Confirmation Code for reset password", confirmationCode.ToString()))
            {
                ConfirmationCodes.Remove(email);
                ConfirmationCodes.Add(email, confirmationCode.ToString());
                return true;
            }
            return false;
        }

        public async Task<bool> SendEmailConfirmationCode(string email)
        {
            int confirmationCode = RandomNumberGenerator.GetInt32(10000, 99999);
            if (await SendEmail(email, "Confirmation Code for confirm your email", confirmationCode.ToString()))
            {
                ConfirmationCodes.Remove(email);
                ConfirmationCodes.Add(email, confirmationCode.ToString());
                return true;
            }
            return false;
        }

        public async Task SendCongratulationsMessage(string email)
        {
            await SendEmail(email, "Congratulations!", "You are succesfully registered from portfolio service.");
        }
    }
}
