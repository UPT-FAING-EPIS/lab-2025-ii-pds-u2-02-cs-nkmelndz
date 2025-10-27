namespace CustomerApp.Domain
{
    /// <summary>
    /// Representa un cliente con información básica.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Nombre del cliente.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Correo electrónico del cliente.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Número de teléfono móvil del cliente.
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Dirección del cliente.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Contraseña del cliente.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Crea una nueva instancia de un cliente.
        /// </summary>
        /// <param name="name">Nombre del cliente.</param>
        /// <param name="email">Correo electrónico del cliente.</param>
        /// <param name="mobileNumber">Número de teléfono móvil del cliente.</param>
        /// <param name="address">Dirección del cliente.</param>
        /// <param name="password">Contraseña del cliente.</param>
        /// <returns>Una nueva instancia de <see cref="Customer"/>.</returns>
        public static Customer Create(string name, string email, string mobileNumber, string address, string password)
        {
            return new Customer() {
                Name = name, Email = email, MobileNumber = mobileNumber, Address = address, Password = password
            };
        }
    }
}