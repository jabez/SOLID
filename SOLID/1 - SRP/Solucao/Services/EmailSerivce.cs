using System.Net.Mail;
using SOLID.SRP.Solucao.Interfaces.Services;

namespace SOLID.SRP.Solucao.Services
{
    public class EmailSerivce : IEmailService
    {
        public void Send(string from, string to, string subject, string body)
        {
            var mailMessage = new MailMessage(from, to);
            var smtpClient = new SmtpClient()
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mailMessage.Subject = subject;
            mailMessage.Body = body;
            smtpClient.Send(mailMessage);
        }
    }
}