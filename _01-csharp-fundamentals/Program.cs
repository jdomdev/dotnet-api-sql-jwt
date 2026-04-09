using System.Globalization;
using csbases.Fundamentals;
using csbases.Fundamentals._05AdapterPattern;
using csbases.Fundamentals._06DependencyInyection;
using csbases.Fundamentals._07AsyncMethods;
using csbases.Fundamentals._08Attributes;
using static System.Console;

class Program {
    static async Task Main() {
        // Configurar cultura al inicio
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("es-ES");

        WriteLine("-------------INHERITANCE-----------------");
        var laptop = new Product(1, "Laptop", 1200m, true, DateTime.Now, Guid.NewGuid());
        WriteLine(laptop.GetDescription());
        var soporte = new ServiceProduct(2, "Soporte Técnico", 200m, 30);
        WriteLine(soporte.GetDescription());
        WriteLine("-------------ADAPTER-----------------");
        var product = new Product(3, "Mouse Gamer", 300m, true, DateTime.Now, Guid.NewGuid());
        var productDto = ProductAdapter.ConvertToDto(product);
        WriteLine($"{productDto.Name} - Price: {productDto.Price:C} - Code: {productDto.Code}");
        WriteLine("-------------DEPENDENCY INYECTION-----------------");
        ILabelService labelService = new LabelService();
        var manager = new ProductManager(labelService);
        var monitor = new Product(4, "Monitor", 100m, true, DateTime.Now, Guid.NewGuid());
        var installation = new ServiceProduct(5, "Instalación", 100m, 15);
        manager.PrintLabel(monitor);
        manager.PrintLabel(installation);
        WriteLine("-------------ASYNC METHODS-----------------");
        var firstProduct = await new ProductRepository().GetProductById(1);
        WriteLine("Obteniendo producto...");
        WriteLine($"Producto obtenido: {firstProduct.Name} - Precio: {firstProduct.Price:C}");
        WriteLine("-------------ATTRIBUTES-----------------");
        firstProduct.Description = "Descripción del producto";
        WriteLine($"Descripción original: {firstProduct.Description}");
        AttributeProcessor.ApplyUpperCase(firstProduct);
        WriteLine("Obteniendo producto con atributos modificados a mayúsculas...");
        WriteLine($"Producto obtenido: {firstProduct.Name} - Precio: {firstProduct.Price:C}");
        WriteLine($"Descripción después de aplicar UpperCase: {firstProduct.Description}");
    }
}


