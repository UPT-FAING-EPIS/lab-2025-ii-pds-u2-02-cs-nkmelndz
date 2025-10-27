namespace Notifications.Domain
{
    /// <summary>
    /// Clase para mensajes cortos con validación de longitud.
    /// </summary>
    public class ShortMessage: AbstractMessage
    {
        /// <summary>
        /// Mensaje de error para mensajes demasiado largos.
        /// </summary>
        public const string LARGE_ERROR_MESSAGE = "Unable to send the message as length > 10 characters";

        /// <summary>
        /// Constructor que inicializa el remitente del mensaje.
        /// </summary>
        /// <param name="messageSender">Implementación del remitente.</param>
        public ShortMessage(IMessageSender messageSender) : base(messageSender)
        {
        }

        /// <summary>
        /// Envía un mensaje si cumple con la longitud permitida.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        /// <exception cref="ArgumentException">Si el mensaje excede la longitud permitida.</exception>
        public override string SendMessage(string Message)
        {
            if (Message.Length <= 25)
                return _messageSender.SendMessage(Message);
            else
                throw new ArgumentException(LARGE_ERROR_MESSAGE);
        }
    }
}