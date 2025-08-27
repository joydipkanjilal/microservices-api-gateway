namespace Product.API.DataAccess
{
    using Bogus;
    using Product.API.Models;

    /// <summary>
    /// The ProductRepository class
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Generates fake product data using Faker.
        /// </summary>
        /// <returns></returns>
        private async Task<List<Product>> GenerateProductData()
        {
            var product = new Faker<Product>()
                         .RuleFor(x => x.Id, f => Guid.NewGuid())
                         .RuleFor(x => x.Name, f => f.Commerce.ProductName())
                         .RuleFor(x => x.Description, f => f.Commerce.ProductDescription())
                         .RuleFor(x => x.Price, f => Math.Round(f.Random.Decimal(5000, 10000), 2));

            var products = product.Generate(100); //Generates a list of product records
            return await Task.FromResult(products);
        }

        /// <summary>
        /// Gets all products.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Product>> GetAllProducts()
        {
            return await Task.FromResult(await GenerateProductData());
        }
    }
}