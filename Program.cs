using System.Globalization;
using csbases.fundamentals;
using csbases.fundamentals._05PatronAdaptador;
using static System.Console;

class Program {
    static void Main() {
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
        // TODO: v12 Dependency Injection (pendiente de reimplementar)
        // WriteLine("-------------DEPENDENCY INYECTION-----------------");
        // ILabelService labelService = new LabelService();
        // var manager = new ProductManager(labelService);
        // var monitor = new Product(4, "Monitor", 100m, true, DateTime.Now, Guid.NewGuid());
        // var installation = new ServiceProduct(5, "Instalación", 100m, 15);
        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);
    }
}


