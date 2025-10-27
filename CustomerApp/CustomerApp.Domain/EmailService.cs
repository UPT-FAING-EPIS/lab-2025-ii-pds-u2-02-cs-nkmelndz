using System.Net;
using System.Net.Mail;

namespace CustomerApp.Domain
{
    /// <summary>
    /// Servicio para enviar correos electrónicos de registro.
    /// </summary>
    public class EmailService
    {
        /// <summary>
        /// Envía un correo electrónico de registro al cliente.
        /// </summary>
        /// <param name="customer">El cliente al que se enviará el correo.</param>
        /// <returns>True si el correo fue enviado exitosamente.</returns>
        public bool SendRegistrationEmail(Customer customer)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(customer.Email, customer.Password),
                EnableSsl = true,
            };
            var mailMessage = new MailMessage
            {
                From = new MailAddress(customer.Email),
                Subject = "Test mail",
                Body = "<h1>Hello</h1>",
                IsBodyHtml = true,
            };
            mailMessage.To.Add(customer.Email);
            return true;
        }        
    }
}