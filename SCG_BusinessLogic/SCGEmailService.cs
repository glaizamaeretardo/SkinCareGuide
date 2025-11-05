using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace SCG_BusinessLogic
{
    public class SCGEmailService
    {
        private readonly IConfiguration _configuration;

        public SCGEmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendUserSkinTypeEmail(string userName, string skinType)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(
                _configuration["SCGEmailSettings:FromName"],
                _configuration["SCGEmailSettings:FromEmail"]
            ));

            message.To.Add(new MailboxAddress("User Notification", _configuration["SCGEmailSettings:ToEmail"]));
            message.Subject = "Skin Care Guide - User Details Notification";

            message.Body = new TextPart("plain")
            {
                Text = $"Hi! This is your details:\n\n" +
                       $"Name: {userName}\n" +
                       $"Skin Type: {skinType}\n\n" +
                       $"A new entry has been successfully added to the Skin Care Guide system."
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect(
                        _configuration["SCGEmailSettings:SmtpHost"],
                        int.Parse(_configuration["SCGEmailSettings:SmtpPort"]),
                        SecureSocketOptions.StartTls
                    );

                    client.Authenticate(
                        _configuration["SCGEmailSettings:Username"],
                        _configuration["SCGEmailSettings:Password"]
                    );

                    client.Send(message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[Error] Failed to send email: {ex.Message}");
                }
                finally
                {
                    client.Disconnect(true);
                }
            }
        }
    }
}