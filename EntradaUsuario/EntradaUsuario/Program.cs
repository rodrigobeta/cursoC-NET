using System;

class Program
{
    static void Main()
    {
        // 1. Mensaje para guiar al usuario (muy importante)
        Console.Write("¿Cómo te llamas? ");
        //               ↑ sin salto de línea para que escriba al lado

        // 2. Esperamos que el usuario escriba y pulse Enter
        string nombre = Console.ReadLine();

        // 3. Saludamos usando lo que nos dijo
        Console.WriteLine($"¡Hola, {nombre}! Bienvenid@.");

        // ──────────────────────────────────────────────

        Console.Write("¿Cuántos años tienes? ");
        string edadTexto = Console.ReadLine();

        // 4. Convertimos el texto a número (recordatorio del tema anterior)
        // Versión insegura (puede fallar si no es número)
        // int edad = int.Parse(edadTexto);

        // Versión segura (recomendada siempre que sea entrada de usuario)
        if (int.TryParse(edadTexto, out int edad))
        {
            Console.WriteLine($"Entonces tienes {edad} años.");
            
            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
        }
        else
        {
            Console.WriteLine("Eso no parece un número válido…");
        }

        // ──────────────────────────────────────────────

        // 5. Ejemplo con decimal (precios, medidas, etc.)
        Console.Write("¿Cuánto mide tu estatura en metros? (ej: 1.75) ");
        string estaturaTexto = Console.ReadLine();

        if (double.TryParse(estaturaTexto, out double estatura))
        {
            Console.WriteLine($"Perfecto, mides {estatura:F2} metros.");
        }
        else
        {
            Console.WriteLine("Formato no reconocido. Usa punto o coma según tu configuración.");
        }

        Console.WriteLine("\n¡Gracias por participar!");
    }
}