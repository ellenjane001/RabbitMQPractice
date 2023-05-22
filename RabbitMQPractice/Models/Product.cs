namespace RabbitMQPractice.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string ProductDescription { get; set; } = string.Empty;
        public string ProductPrice { get; set; } = string.Empty;
        public string ProductStock { get; set; } = string.Empty;
    }
}
