using System;

class Program
{
    static void Main()
    {
        string texto = "  Hola, soy María López - Desarrolladora  ";

        // Limpieza básica
        string limpio = texto.Trim();
        Console.WriteLine($"Original: '{texto}'");
        Console.WriteLine($"Limpio:   '{limpio}'");           // "Hola, soy María López - Desarrolladora"

        // Mayúsculas / minúsculas
        Console.WriteLine($"Mayúsculas: {limpio.ToUpper()}");
        Console.WriteLine($"Minúsculas: {limpio.ToLower()}");

        // Búsquedas
        Console.WriteLine($"\n¿Contiene 'María'? {limpio.Contains("María")}");          // true
        Console.WriteLine($"¿Contiene 'maria'?  {limpio.Contains("maria")}");          // false  ← sensible a mayúsculas
        Console.WriteLine($"¿Empieza con 'Hola'? {limpio.StartsWith("Hola")}");        // true
        Console.WriteLine($"Posición de 'López': {limpio.IndexOf("López")}");          // 15

        // Reemplazos
        string mejorado = limpio.Replace("Desarrolladora", "Programadora C#");
        Console.WriteLine($"Reemplazo: {mejorado}");

        // División (split)
        string[] palabras = limpio.Split(new[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("\nPalabras encontradas:");
        foreach (string palabra in palabras)
        {
            Console.WriteLine($"- {palabra}");
        }

        // Extracción
        string nombreParte = limpio.Substring(6, 11); // desde posición 6, 11 caracteres
        Console.WriteLine($"\nExtraído: {nombreParte}");  // "soy María "

        // Comprobaciones útiles
        string entrada = "   ";
        Console.WriteLine($"\n¿Es vacío o espacios? {string.IsNullOrWhiteSpace(entrada)}"); // true
    }
}