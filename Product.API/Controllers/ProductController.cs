namespace Product.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Product.API.DataAccess;
    using Product.API.Models;

    /// <summary>
    /// The ProductController class
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        /// <summary>
        /// Initializes a new instance of the ProductController class.
        /// </summary>
        /// <param name="customerRepository">The customer repository.</param>
        public ProductController(IProductRepository customerRepository)
        {
            _productRepository = customerRepository; //Assigns the product repository instance
                                                     //created using dependency injection
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAllProducts()
        {
            return await _productRepository.GetAllProducts(); //Calls the GetAllProducts method of the product
                                                              //repository asynchronously and returns the results
        }
    }
}