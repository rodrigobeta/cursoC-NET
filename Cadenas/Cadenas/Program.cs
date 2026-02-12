using System;

namespace CadenasBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declaración básica de cadenas
            string saludo = "Hola";
            string nombre = "María";

            // 2. Concatenación clásica (no la más recomendada hoy)
            string mensaje1 = saludo + ", " + nombre + "!";
            Console.WriteLine(mensaje1);   // Hola, María!

            // 3. Forma moderna y más legible (recomendada) → Interpolación
            string mensaje2 = $"{saludo}, {nombre}! ¿Cómo estás?";
            Console.WriteLine(mensaje2);

            // 4. Cadena verbatim (muy útil con rutas de archivos o JSON)
            // El @ permite usar \ sin duplicarlos y escribir en varias líneas
            string ruta = @"C:\Users\Maria\Documents\archivo.txt";
            string jsonEjemplo = @"
            {
                ""nombre"": ""María"",
                ""edad"": 28
            }";

            Console.WriteLine("Ruta: " + ruta);

            // 5. Algunas propiedades y métodos útiles
            Console.WriteLine($"Longitud del nombre: {nombre.Length}");     // 5
            Console.WriteLine($"Mayúsculas: {nombre.ToUpper()}");           // MARÍA
            Console.WriteLine($"Minúsculas: {nombre.ToLower()}");           // maría
            Console.WriteLine($"¿Empieza con 'Ma'? {nombre.StartsWith("Ma")}"); // True
            Console.WriteLine($"¿Contiene 'rí'? {nombre.Contains("rí")}");     // True

            // 6. Cadena vacía vs null (importante diferencia)
            string vacia = "";                  // cadena vacía (longitud 0)
            string nula = null;                 // no apunta a ninguna cadena

            Console.WriteLine($"¿Es vacía? {string.IsNullOrEmpty(vacia)}");   // True
            Console.WriteLine($"¿Es nula o vacía? {string.IsNullOrEmpty(nula)}"); // True
        }
    }
}