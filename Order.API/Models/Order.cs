namespace Order.API.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        //public Guid CustomerId { get; set; }
        //public Guid ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int OrderQuantity { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
