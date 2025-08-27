namespace Product.API.DataAccess
{
    using Product.API.Models;

    /// <summary>
    /// The IProductRepository interface
    /// </summary>
    public interface IProductRepository
    {
        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public Task<List<Product>> GetAllProducts();
    }
}