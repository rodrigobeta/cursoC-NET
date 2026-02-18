using System;

class Program
{
    // Opción 1: Recomendada para la mayoría de programas de consola
    // Creamos UNA instancia estática y la reutilizamos siempre
    private static readonly Random rnd = new Random();

    static void Main()
    {
        // 1. Número entero aleatorio en un rango
        int dado = rnd.Next(1, 7);           // 1 ≤ n < 7  → 1 al 6
        Console.WriteLine($"Dado: {dado}");

        // 2. Entero entre 0 y un máximo (sin incluir el máximo)
        int numeroCorto = rnd.Next(100);     // 0 a 99
        Console.WriteLine($"Número corto: {numeroCorto}");

        // 3. Entero en rango cualquiera
        int temperatura = rnd.Next(-10, 41); // -10 a 40
        Console.WriteLine($"Temperatura aleatoria: {temperatura} °C");

        // 4. Número decimal entre 0.0 y 1.0
        double probabilidad = rnd.NextDouble();   // [0.0, 1.0)
        Console.WriteLine($"Probabilidad: {probabilidad:F4}");

        // 5. Decimal en rango personalizado (patrón muy usado)
        double precioRandom = 50 + rnd.NextDouble() * 150;   // 50.00 a 199.999...
        Console.WriteLine($"Precio aleatorio: {precioRandom:F2} €");

        // 6. Ejemplo práctico: simular moneda (cara o cruz)
        bool esCara = rnd.Next(2) == 0;   // 0 o 1
        Console.WriteLine($"Lanzamiento de moneda: {(esCara ? "Cara" : "Cruz")}");

        // 7. Elegir al azar de una lista (muy común)
        string[] opciones = { "piedra", "papel", "tijera" };
        string jugadaPC = opciones[rnd.Next(opciones.Length)];
        Console.WriteLine($"La máquina eligió: {jugadaPC}");
    }
}