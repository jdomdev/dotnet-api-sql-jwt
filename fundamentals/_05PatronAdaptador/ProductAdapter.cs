using System;

namespace csbases.fundamentals._05PatronAdaptador;

public class ProductAdapter
{
    public static ProductDto ConvertToDto(Product product)
    {
        return new ProductDto
        {
            Name = product.Name ?? "Sin nombre",
            Price = product.Price,
            Code = $"PRD-{product.Id}-{product.UniqueCode.ToString().Substring(0, 8)}"
        };
    }
}
