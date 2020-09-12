using System.Net.Mail;

namespace Core.Smtp
{
    /// <summary>
    /// A generic abstraction of an SMTP client
    /// </summary>
    public interface ISmtpClient
    {
        /// <summary>
        /// Sends an email according to the properties set in the MailMessage object
        /// </summary>
        /// <param name="mailMessage">The email to send</param>
        void Send(MailMessage mailMessage);
    }
}
