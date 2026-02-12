// 1. Declaramos los "espacios de nombres" que vamos a usar
// System contiene Console, que es la clase para escribir en consola
using System;

// 2. Definimos un "namespace" (como una carpeta lógica para organizar código)
namespace MiPrimerPrograma
{
    // 3. Creamos una clase. En C# todo el código debe estar dentro de una clase
    class Program
    {
        // 4. El método "Main" es el punto de entrada del programa
        // static = se puede llamar sin crear un objeto
        // void = no devuelve ningún valor
        // string[] args = parámetros que puede recibir el programa desde la línea de comandos
        static void Main(string[] args)
        {
            // 5. Usamos Console.WriteLine para imprimir texto en la consola
            // y saltar de línea automáticamente
            Console.WriteLine("Hello, World!");
            
            // Opcional: Console.ReadKey() para que la consola no se cierre inmediatamente
            // Console.ReadKey();
            
            
            // Versión moderna (C# 10+ / .NET 6+) - "Top-level statements"
            // ¡Ya no necesitas using, namespace, class ni Main!
            Console.WriteLine("Hello, World!");
        }
    }
}