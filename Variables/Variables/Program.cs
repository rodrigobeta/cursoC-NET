// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main()
    {
        // 1. Declaración + asignación en una sola línea (forma más común)
        string nombre = "Carlos";
        int edad = 27;
        double estatura = 1.78;         // metros
        bool esEstudiante = true;

        // 2. Declarar primero y asignar después (también válido)
        string ciudad;
        ciudad = "Sevilla";

        // 3. Mostrar los valores usando interpolación (lo que ya vimos)
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad} años");
        Console.WriteLine($"Estatura: {estatura} m");
        Console.WriteLine($"¿Es estudiante? {esEstudiante}");
        Console.WriteLine($"Vive en: {ciudad}");

        // 4. Cambiar el contenido de una variable (las cajas se pueden rellenar de nuevo)
        edad = 28;                      // ¡cumplió años!
        nombre = "Carlos Miguel";

        Console.WriteLine("\n--- Después de actualizar ---");
        Console.WriteLine($"Ahora se llama {nombre} y tiene {edad} años");

        // 5. Variables que nunca cambian → const (buena práctica cuando el valor es fijo)
        const double PI = 3.14159265359;
        const string PAIS = "España";

        Console.WriteLine($"País de origen: {PAIS}");
        Console.WriteLine($"Valor de PI: {PI}");

        // PI = 3.14;   ← Esto daría ERROR de compilación (no se puede modificar)
    }
}

