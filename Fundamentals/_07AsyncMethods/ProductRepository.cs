using System;

namespace csbases.Fundamentals._07AsyncMethods;

public class ProductRepository
{
    //Síncrono:
    //public Product GetProductById(int id)
    //Asícrono:
    public async Task<Product> GetProductById(int id)
    {
        // Simular una operación.
        // La operación puede ser una llamada a una base de datos o a un servicio externo
        // como una consulta a una API REST o un acceso a un archivo.
        // Sync -> return new Product(id, $"Simulated Product {id}", 500m, true, DateTime.Now, Guid.NewGuid());
        WriteLine("Simulando una operación de obtención de producto...");
        await Task.Delay(2000); // Simula una operación que tarda 2 segundos
        return new Product(id, $"Simulated Product {id}", 500m, true, DateTime.Now, Guid.NewGuid());
    }
}
