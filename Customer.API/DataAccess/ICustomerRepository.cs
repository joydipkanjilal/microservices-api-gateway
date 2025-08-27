namespace Customer.API.DataAccess
{
    using Customer.API.Models;

    /// <summary>
    /// The ICustomerRepository interface
    /// </summary>
    public interface ICustomerRepository
    {
        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        public Task<List<Customer>> GetAllCustomers();
    }
}