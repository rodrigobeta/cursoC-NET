using System;

class Program
{
    static void Main()
    {
        // 1. Conversión implícita (automática – sin riesgo)
        int numeroEntero = 42;
        double numeroDouble = numeroEntero;         // int → double (implícita)
        decimal numeroDecimal = numeroEntero;       // int → decimal (implícita)

        Console.WriteLine($"int → double: {numeroDouble}");     // 42.0
        Console.WriteLine($"int → decimal: {numeroDecimal}");   // 42


        // 2. Conversión explícita (casting) – con posible pérdida
        double temperatura = 36.78;
        int temperaturaEntera = (int)temperatura;           // casting directo → trunca

        Console.WriteLine($"36.78 → int: {temperaturaEntera}");   // 36 (se pierde 0.78)


        // 3. string → número (la conversión más común y peligrosa)
        string entradaUsuario = "123";
        int edad = int.Parse(entradaUsuario);               // puede fallar
        Console.WriteLine($"Edad parseada: {edad + 1}");    // 124


        // 4. La forma SEGURA (la que casi siempre deberías usar)
        string entradaDudosa = "veinticinco";
        if (int.TryParse(entradaDudosa, out int resultado))
        {
            Console.WriteLine($"Éxito: {resultado}");
        }
        else
        {
            Console.WriteLine("No es un número válido");
        }


        // 5. decimal (dinero) – nunca uses double para dinero
        string precioTexto = "19.95";
        if (decimal.TryParse(precioTexto, out decimal precio))
        {
            decimal precioConIva = precio * 1.21m;
            Console.WriteLine($"Precio con IVA: {precioConIva:F2} €");
        }


        // 6. bool desde string (útil en configuraciones)
        string config = "True";
        bool activado = bool.Parse(config);
        Console.WriteLine($"Activado? {activado}");


        // 7. Número → string (casi siempre implícito o con ToString)
        int codigo = 404;
        string mensaje = "Error " + codigo;                 // implícito
        string mensaje2 = $"Error {codigo:D4}";             // :D4 = 4 dígitos
        Console.WriteLine(mensaje2);                        // Error 0404
    }
}