using System;

namespace csbases.Fundamentals._06DependencyInyection;

public class LabelService : ILabelService
{
    public string GenerateLabel(Product product)
    {
        return $"{product.Name} - {product.Price:C} - Código: {product.GetType().Name} - {product.GetHashCode()}";
    }
}
