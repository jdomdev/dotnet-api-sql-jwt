using System;

namespace csbases.Fundamentals._06DependencyInyection;

public class ProductManager
{
    private ILabelService _labelService;

    public ProductManager(ILabelService labelService)
    {
        _labelService = labelService;
    }

    public void PrintLabel(Product product)
    {
        var label = _labelService.GenerateLabel(product);
        WriteLine(label);
    }
}
