using csbases.Fundamentals._08Attributes;

namespace csbases.Fundamentals
{
    public class Product: IProduct
    {
        public int Id { get; set; }
        [UpperCase]
        public string? Name { get; set; }
        [UpperCase]
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UniqueCode { get; set; }
        public Product(int id, string? name, decimal price, bool isAvailable, DateTime createdAt, Guid uniqueCode)
        {
            Name = name;
            Price = price;
            IsAvailable = isAvailable;
            CreatedAt = DateTime.Now;
            UniqueCode = Guid.NewGuid();
        }
        public void ApplyDiscount(decimal percentage)
        {
            if (percentage < 0 || percentage > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage), "Percentage must be between 0 and 100.");
            }
            var discountAmount = Price * (percentage / 100);
            Price -= discountAmount;
        }
        public virtual string GetDescription()
        {
            return $"Product: {Name}, Price: {Price:C}, Available: {IsAvailable}, Created At: {CreatedAt}, Unique Code: {UniqueCode}";
        }
    }

    class ServiceProduct: Product
    {
        public int DurationInDays { get; set; }
        public ServiceProduct(int id, string? name, decimal price, int duration) : base(id, name, price, true, DateTime.Now, Guid.NewGuid())
        {
            DurationInDays = duration;
        }
        public override string GetDescription()
        {
            return $"{base.GetDescription()}, Duration: {DurationInDays} days";
        }
    }


    



}
