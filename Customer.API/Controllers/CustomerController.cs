namespace Customer.API.Controllers
{
    using Customer.API.DataAccess;
    using Customer.API.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The CustomerController class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        /// <summary>
        /// Initializes a new instance of the CustomerController class.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository; //Assigns the customer repository instance
                                                      //created using dependency injection
        }

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAllCustomers()
        {
            return await _customerRepository.GetAllCustomers(); //Calls the GetAllCustomers method of the
                                                                //customer repository asynchronously and returns the results
        }
    }
}