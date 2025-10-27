namespace Notifications.Domain
{
    /// <summary>
    /// Implementación del envío de mensajes mediante correo electrónico.
    /// </summary>
    public class EmailMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía un mensaje utilizando correo electrónico.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "'   : This Message has been sent using Email";
        }
    }
}