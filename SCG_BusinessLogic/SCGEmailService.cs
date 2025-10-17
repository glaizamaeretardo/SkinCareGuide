using System.Net;
using System.Net.Mail;

namespace SCG_BusinessLogic
{
    public class SCGEmailService
    {
        private readonly string smtpHost = "sandbox.smtp.mailtrap.io";
        private readonly int smtpPort = 2525;
        private readonly string smtpUser = "8c529fdf2e8324";
        private readonly string smtpPass = "16ba0eddf26fc6";
        private readonly string fromEmail = "noreply@skincareguide.com";

        public void SendUserSkinTypeEmail(string userName, string skinType)
        {
            try
            {
                using (var client = new SmtpClient(smtpHost, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUser, smtpPass);
                    client.EnableSsl = true;

                    var mail = new MailMessage();
                    mail.From = new MailAddress(fromEmail, "Skin Care Guide");
                    mail.To.Add("user@example.com");
                    mail.Subject = "Skin Care Guide - Your Skin Type Details";
                    mail.Body = $"This is your details:\n\nName: {userName}\nSkin Type: {skinType}";

                    client.Send(mail);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nFailed to send email!");
            }
        }
    }
}
