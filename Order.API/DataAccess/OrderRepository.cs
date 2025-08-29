using Bogus;
using Order.API.Models;

namespace Order.API.DataAccess
{
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// Generates fake order data using Faker.
        /// </summary>
        /// <returns></returns>
        private async Task<List<Order.API.Models.Order>> GenerateOrderData()
        {
            var order = new Faker<Order.API.Models.Order>()
                         .RuleFor(x => x.Id, f => Guid.NewGuid())
                         .RuleFor(x => x.UnitPrice, f => Math.Round(f.Random.Decimal(5000, 10000), 2));

            var products = order.Generate(100); //Generates a list of order records
            return await Task.FromResult(products);
        }

        /// <summary>
        /// Gets all orders.
        /// </summary>
        /// <returns></returns>
        public async Task<List<Order.API.Models.Order>> GetAllOrders()
        {
            return await Task.FromResult(await GenerateOrderData());
        }
    }
}
