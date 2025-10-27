using CustomerApp.Domain;

/// <summary>
/// Fachada para registrar clientes.
/// </summary>
public class CustomerRegistration
{
    /// <summary>
    /// Registra un cliente validando, guardando y enviando un correo de confirmación.
    /// </summary>
    /// <param name="customer">El cliente a registrar.</param>
    /// <returns>True si el registro fue exitoso.</returns>
    public bool RegisterCustomer(Customer customer)
    {
        Validator validator = new Validator();
        bool IsValid = validator.ValidateCustomer(customer);
        DataAccessLayer customerDataAccessLayer = new DataAccessLayer();
        bool IsSaved = customerDataAccessLayer.SaveCustomer(customer);
        EmailService email = new EmailService();
        email.SendRegistrationEmail(customer);
        return true;
    }
}