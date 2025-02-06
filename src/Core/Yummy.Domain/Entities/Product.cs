namespace Yummy.Domain.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageURL { get; set; } = string.Empty;
        public int CategoryID { get; set; }
        public Category Category { get; set; } = new();
        public bool IsActive { get; set; } = true;
    }
}