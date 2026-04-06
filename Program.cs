// See https://aka.ms/new-console-template for more information
class Program {
    static void Main() {
        //Console.WriteLine("Hello, World!");
        //WriteLine("Hello, World!");

        //Vídeo 8. Tipos básicos
        //Declaración explicita
        int  quantity = 5;
        string message = "Hello, World!";
        decimal price = 19.99m;
        WriteLine($"Quantity: {quantity}, Message: {message}, Price: {price:C}");
        //Declaración con var
        var gretting = "Hola";
        var porcentage = 20.00m;
        WriteLine($"Greting: {gretting}, Porcentage: {porcentage:P}");
        //Vídeo 9. Clases e Interfaces
    }
}