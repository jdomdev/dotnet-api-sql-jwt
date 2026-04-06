using System;

namespace csbases.fundamentals;

public class Product: IProduct
{
    public int Id { get; set; }
    public string? Name { get; set; }
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

