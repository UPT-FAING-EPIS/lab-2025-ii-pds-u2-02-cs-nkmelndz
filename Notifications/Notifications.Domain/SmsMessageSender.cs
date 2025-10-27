namespace Notifications.Domain
{
    /// <summary>
    /// Implementación del envío de mensajes mediante SMS.
    /// </summary>
    public class SmsMessageSender : IMessageSender
    {
        /// <summary>
        /// Envía un mensaje utilizando SMS.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        public string SendMessage(string Message)
        {
            return "'" + Message + "' : This Message has been sent using SMS";
        }
    }
}