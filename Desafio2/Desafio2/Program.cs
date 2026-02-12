/*
 * Crea un programa que muestre exactamente esta salida:
 * FICHA PERSONAL
   ═══════════════════════════════
   Nombre:             Sofía Ramírez
   Edad:               24 años
   Estatura:           1.65 m
   Ciudad:             Córdoba
   Es estudiante:      Sí
   País:               España
   Fecha de registro:  12/02/2026
   ═══════════════════════════════
 */
 
 using System;
 
 class Program
 {
     static void Main(string[] args)
     {
         string nombre = "Sofía Ramírez";
         int edad = 24;
         double estaturaMetros = 1.65;
         string ciudad = "Córdoba";
         bool esEstudiante = true;
         const string PAIS = "España";
         const string FECHA_REGISTRO = "12/02/2026";

         Console.WriteLine("FICHA PERSONAL");
         Console.WriteLine("==============================");
         Console.WriteLine($"Nombre:\t\t{nombre}");
         Console.WriteLine($"Edad:\t\t{edad} años");
         Console.WriteLine($"Estatura:\t{estaturaMetros} m");
         Console.WriteLine($"Ciudad:\t\t{ciudad}");
         Console.WriteLine($"Es estudiante:\t{(esEstudiante ? "Sí" : "No")}");
         Console.WriteLine($"País:\t\t{PAIS}");
         Console.WriteLine($"Fecha de registro:\t{FECHA_REGISTRO}");
         Console.WriteLine("==============================");
     }
 }