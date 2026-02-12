using System;

class Program
{
    // 1. Constantes a nivel de clase (las más comunes)
    // Se escriben en MAYÚSCULAS por convención
    private const double PI = 3.141592653589793;
    private const int DIAS_POR_SEMANA = 7;
    private const string CODIGO_PAIS_ESPANA = "ES";
    private const decimal IVA_21 = 0.21m;

    static void Main()
    {
        // 2. Constantes locales (dentro de un método)
        const double GRAVEDAD_TIERRA = 9.80665;
        const string NOMBRE_APLICACION = "MiPrimeraApp";

        // 3. Uso normal (lectura)
        Console.WriteLine($"Valor de PI: {PI}");
        Console.WriteLine($"Días en una semana: {DIAS_POR_SEMANA}");
        Console.WriteLine($"IVA actual (21%): {IVA_21:P0}");   // :P0 → formato porcentaje

        double radio = 5.0;
        double areaCirculo = PI * radio * radio;
        Console.WriteLine($"Área de círculo (r={radio}): {areaCirculo:F2}");

        // 4. Esto NO compila (intento de modificación)
        // PI = 3.14;                  ← Error de compilación
        // DIAS_POR_SEMANA = 8;        ← Error de compilación
        // GRAVEDAD_TIERRA += 0.001;   ← Error de compilación

        Console.WriteLine($"\nNombre de esta aplicación: {NOMBRE_APLICACION}");
    }
}