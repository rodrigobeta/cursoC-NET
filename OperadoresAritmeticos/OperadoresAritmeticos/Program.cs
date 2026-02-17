using System;

class Program
{
    static void Main()
    {
        int a = 17;
        int b = 5;

        // Operaciones básicas
        Console.WriteLine($"Suma:        {a} + {b} = {a + b}");      // 22
        Console.WriteLine($"Resta:       {a} - {b} = {a - b}");      // 12
        Console.WriteLine($"Multiplicar: {a} × {b} = {a * b}");      // 85
        Console.WriteLine($"Dividir:     {a} ÷ {b} = {a / b}");      // 3   ← división entera
        Console.WriteLine($"Resto:       {a} % {b} = {a % b}");      // 2

        // Con decimales (double o decimal)
        double precio = 19.99;
        double iva = 0.21;
        double precioConIva = precio * (1 + iva);
        Console.WriteLine($"\nPrecio con IVA: {precioConIva:F2} €");   // 24.19 €

        // Incremento y decremento
        int contador = 10;
        Console.WriteLine($"Contador inicial: {contador}");

        contador++;          // contador = contador + 1
        Console.WriteLine($"Después de ++:    {contador}");   // 11

        int vidas = 5;
        Console.WriteLine($"Vidas antes: {vidas--}");         // muestra 5, luego resta
        Console.WriteLine($"Vidas después: {vidas}");         // 4

        int puntos = 100;
        Console.WriteLine($"Puntos después de --: {--puntos}"); // resta primero, muestra 99

        // Combinar operaciones (precedencia)
        int resultado = 10 + 5 * 2;     // 20   (multiplicación antes que suma)
        int resultado2 = (10 + 5) * 2;  // 30   (paréntesis cambian el orden)
        Console.WriteLine($"\nSin paréntesis:  {resultado}");
        Console.WriteLine($"Con paréntesis:   {resultado2}");
    }
}