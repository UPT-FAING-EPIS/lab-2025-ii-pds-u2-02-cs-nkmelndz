namespace CustomerApp.Domain
{
    /// <summary>
    /// Clase para validar objetos de tipo Customer.
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// Valida un objeto Customer.
        /// </summary>
        /// <param name="customer">El cliente a validar.</param>
        /// <returns>True si el cliente es válido; de lo contrario, lanza una excepción.</returns>
        /// <exception cref="ArgumentException">Si alguna propiedad del cliente es nula o vacía.</exception>
        public bool ValidateCustomer(Customer customer)
        {
            if (string.IsNullOrEmpty(customer.Name)) throw new ArgumentException("Name can't be null or empty");
            if (string.IsNullOrEmpty(customer.Email)) throw new ArgumentException("Email can't be null or empty");
            if (string.IsNullOrEmpty(customer.MobileNumber)) throw new ArgumentException("MobileNumber can't be null or empty");
            if (string.IsNullOrEmpty(customer.Address)) throw new ArgumentException("Address can't be null or empty");
            return true;
        }
    }
}