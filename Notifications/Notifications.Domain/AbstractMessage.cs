namespace Notifications.Domain
{
    /// <summary>
    /// Clase base abstracta para definir tipos de mensajes.
    /// </summary>
    public abstract class AbstractMessage
    {
        /// <summary>
        /// Implementación del envío de mensajes.
        /// </summary>
        protected IMessageSender _messageSender;

        /// <summary>
        /// Constructor requerido para inicializar el remitente del mensaje.
        /// </summary>
        /// <param name="messageSender">Implementación del remitente.</param>
        protected AbstractMessage(IMessageSender messageSender)
        {
            _messageSender = messageSender ?? throw new ArgumentNullException(nameof(messageSender));
        }

        /// <summary>
        /// Envía un mensaje utilizando la implementación configurada.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        public abstract string SendMessage(string Message);
    }
}