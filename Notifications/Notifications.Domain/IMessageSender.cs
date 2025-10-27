namespace Notifications.Domain
{
    /// <summary>
    /// Interfaz para implementar el envío de mensajes.
    /// </summary>
    public interface IMessageSender
    {
        /// <summary>
        /// Envía un mensaje y devuelve una confirmación.
        /// </summary>
        /// <param name="Message">El mensaje a enviar.</param>
        /// <returns>Una cadena de confirmación del envío.</returns>
        string SendMessage(string Message);
    }
}