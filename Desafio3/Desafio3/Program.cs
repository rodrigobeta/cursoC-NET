/*
 * Crea un programa que simule un mini cuestionario o ficha de inscripción muy sencilla. Debe:
 * 1) Mostrar un título con líneas decorativas (usa constantes para los caracteres de línea si quieres)\
 * 2) Preguntar al menos 5 datos diferentes al usuario:
 * Nombre (string)
 * Edad (int)
 * Estatura en metros (double o decimal)
 * Ciudad donde vive (string)
 * ¿Tiene experiencia previa en programación? (sí/no → puedes guardarlo como string o intentar bool)
 * 3) Usar Console.Write(…) + Console.ReadLine() para cada pregunta
 * 4) Usar TryParse al menos en dos campos numéricos
 * 5) Al final mostrar un resumen bonito de toda la información ingresada (con alineación usando \t o espacios)
 *
 * Ejemplo de salida final deseada (puedes variar el formato):
 *
 * FICHA DE INSCRIPCIÓN
   ═══════════════════════════════════════
   Nombre:               Juan Pérez
   Edad:                 27 años
   Estatura:             1.82 m
   Ciudad:               Málaga
   ¿Experiencia previa?  Sí
   ───────────────────────────────────────
   ¡Registro completado con éxito!
   Gracias por participar.
   ═══════════════════════════════════════
 */
 
using System;

class Program
{
  static void Main()
  {
    Console.Write("Escribe tu nombre: ");
    string nombre = Console.ReadLine()?.Trim() ?? "Sin nombre";

    Console.Write("Escribe tu edad: ");
    if (!int.TryParse(Console.ReadLine(), out int edad))
    {
      Console.WriteLine("Edad no válida → se usará 0");
      edad = 0;
    }

    Console.Write("Escribe tu estatura (ej: 1.75): ");
    double.TryParse(Console.ReadLine(), out double estatura);  // si falla → 0.0

    Console.Write("Escribe tu ciudad: ");
    string ciudad = Console.ReadLine()?.Trim() ?? "";

    Console.Write("¿Experiencia previa en programación? (si/no): ");
    string experiencia = Console.ReadLine()?.Trim().ToLower() ?? "no";

    // ──────────────────────────────────────────────
    Console.WriteLine("\n═══════════════════════════════════════");
    Console.WriteLine("      FICHA DE INSCRIPCIÓN");
    Console.WriteLine("═══════════════════════════════════════");

    const int ANCHO = 18;
    Console.WriteLine($"{"Nombre:",-ANCHO}{nombre}");
    Console.WriteLine($"{"Edad:",-ANCHO}{edad} años");
    Console.WriteLine($"{"Estatura:",-ANCHO}{estatura:F2} m");
    Console.WriteLine($"{"Ciudad:",-ANCHO}{ciudad}");
    Console.WriteLine($"{"Experiencia previa:",-ANCHO}{(experiencia == "si" || experiencia == "sí" ? "Sí" : "No")}");

    Console.WriteLine("═══════════════════════════════════════");
    Console.WriteLine("Registro completado con éxito!");
    Console.WriteLine("Gracias por participar.\n");

    Console.WriteLine("Presiona ENTER para salir...");
    Console.ReadLine();
  }
}