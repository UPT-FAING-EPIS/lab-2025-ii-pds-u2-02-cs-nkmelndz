namespace CustomerApp.Domain
{
    /// <summary>
    /// Clase para manejar el acceso a datos de clientes.
    /// </summary>
    public class DataAccessLayer
    {
        /// <summary>
        /// Lista de clientes almacenados.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Constructor que inicializa la lista de clientes.
        /// </summary>
        public DataAccessLayer()
        {
            Customers = new List<Customer>();
        }

        /// <summary>
        /// Guarda un cliente en la base de datos simulada.
        /// </summary>
        /// <param name="customer">El cliente a guardar.</param>
        /// <returns>True si el cliente fue guardado exitosamente.</returns>
        public bool SaveCustomer(Customer customer)
        {
            Customers.Add(customer);
            return true;
        }        
    }
}