using System;
class Program
{
    static void Main()
    {
        //Ejercicio 1
        Console.WriteLine("Ingrese su edad: ");
        int edad = int.Parse(Console.ReadLine());

        if (edad < 12)
        {
            Console.WriteLine("Niño");
        }
        else if (edad >= 12 && edad <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (edad >= 18 && edad <= 64)
        {
            Console.WriteLine("Adulto");
        }
        else
        {
            Console.WriteLine("Adulto mayor");
        }

        //Ejercicio 2
        Console.WriteLine("\nIngrese su calificación: ");
        int calificacion = int.Parse(Console.ReadLine());

        if (calificacion >= 0 && calificacion <= 59)
        {
            Console.WriteLine("Reprobado");
        }
        else if (calificacion >= 60 && calificacion <= 79)
        {
            Console.WriteLine("Aprobado");
        }
        else if (calificacion >= 80 && calificacion <= 89)
        {
            Console.WriteLine("Notable");
        }
        else if (calificacion >= 90 && calificacion <= 100)
        {
            Console.WriteLine("Excelente");
        }
        else
        {
            Console.WriteLine("Calificación no válida.");
        }

        //Ejercicio 3
        Console.WriteLine("\nSeleccione una categoría:");
        Console.WriteLine("1. Adulto");
        Console.WriteLine("2. Estudiante");
        Console.WriteLine("3. Adulto mayor");
        Console.WriteLine("4. Niño");
        Console.WriteLine("5. Salir");
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine("Tarifa normal.");
                break;
            case 2:
                Console.WriteLine("Tarifa con 50% de descuento.");
                break;
            case 3:
                Console.WriteLine("Tarifa con 30% de descuento.");
                break;
            case 4:
                Console.Write("Ingrese la edad del niño: ");
                int edadNiño = int.Parse(Console.ReadLine());
                if (edadNiño < 5)
                {
                    Console.WriteLine("Gratis");
                }
                else if (edadNiño >= 5 && edadNiño <= 12)
                {
                    Console.WriteLine("Tarifa con 50% de descuento");
                }
                else
                {
                    Console.WriteLine("Ya no cuenta en la categoría de niños");
                }
                break;
            case 5:
                Console.WriteLine("Salir");
                break;
            default:
                Console.WriteLine("Opción no válida, ingrese una opción del 1 al 5");
                break;
        }
    }
}
