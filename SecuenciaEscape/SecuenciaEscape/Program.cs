using System;

class Program
{
    static void Main()
    {
        // 1. Saltos de línea y tabuladores (lo más usado)
        Console.WriteLine("Línea 1\nLínea 2\nLínea 3");
        
        Console.WriteLine("Nombre\tEdad\tCiudad");
        Console.WriteLine("Ana\t28\tMadrid");
        Console.WriteLine("Luis\t34\tBarcelona");

        // 2. Comillas dentro de comillas
        string cita = "Ella dijo: \"¡Aprender C# es divertido!\"";
        Console.WriteLine(cita);

        // 3. Rutas de Windows (el error clásico)
        // Esto está MAL:
        // string rutaMal = "C:\Users\Alumno\Documents";  → error de compilación

        // Esto está correcto (dos formas):
        string ruta1 = "C:\\Users\\Alumno\\Documents";
        string ruta2 = @"C:\Users\Alumno\Documents";   // verbatim (más legible)

        Console.WriteLine("Ruta 1: " + ruta1);
        Console.WriteLine("Ruta 2: " + ruta2);

        // 4. Caracteres especiales / Unicode
        Console.WriteLine("Pi mayúscula: \u03A0");
        Console.WriteLine("Corazón: \u2764");
        Console.WriteLine("Emoji moderno: \U0001F60A");  // 😊

        // 5. Combinación frecuente en reportes / tickets
        string ticket = 
            "TICKET #12345\r\n" +
            "────────────────────\r\n" +
            "Cliente:\tJuan Pérez\r\n" +
            "Fecha:\t\t12-Feb-2026\r\n" +
            "────────────────────";

        Console.WriteLine(ticket);
    }
}