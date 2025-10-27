namespace Notifications.Domain
{
    /// <summary>
    /// Clase para mensajes largos que delega el envío al remitente configurado.
    /// </summary>
    public class LongMessage: AbstractMessage
    {
        /// <summary>
        /// Constructor que inicializa el remitente del mensaje.
        /// </summary>
        /// <param name="messageSender">Implementación del remitente.</param>
        public LongMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        /// <summary>
        /// Envía un mensaje utilizando el remitente configurado.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        public override string SendMessage(string Message)
        {
           return _messageSender.SendMessage(Message);
        }
    }
}