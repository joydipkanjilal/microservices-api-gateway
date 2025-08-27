namespace Customer.API.DataAccess
{
    using Bogus;
    using Customer.API.Models;

    /// <summary>
    /// The CustomerRepository class
    /// </summary>
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// Generates fake customer data using Faker.
        /// </summary>
        /// <returns></returns>
        private async Task<List<Customer>> GenerateCustomerData()
        {
            var customer = new Faker<Customer>()
                .RuleFor(c => c.Id, _ => Guid.NewGuid())
                .RuleFor(c => c.FirstName, f => f.Name.FirstName())
                .RuleFor(c => c.LastName, f => f.Name.LastName())
                .RuleFor(c => c.Address, f => f.Address.Country())
                .RuleFor(c => c.Phone, f => f.Phone.PhoneNumberFormat());

            var customers = customer.Generate(100); //Generates a list of fake customer records
            return await Task.FromResult(customers);
        }

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await Task.FromResult(await GenerateCustomerData()); //Calls the GenerateCustomerData asynchronously
                                                                        //and returns the results
        }
    }
}