using System;

namespace PRACTICA_S5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1: Descuento");
            EjercicioDescuento();

            Console.WriteLine("\nEjercicio 2: Clasificación de nota");
            EjercicioNota();
        }

        static void EjercicioDescuento()
        {

            Console.Write("Ingrese el precio del producto: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el código de descuento (1=Estudiante, 2=Empleado, 3=Cliente frecuente): ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            double descuento = 0;

            if (codigo == 1) descuento = 0.10;
            else if (codigo == 2) descuento = 0.15;
            else if (codigo == 3) descuento = 0.20;

            if (precio > 500) descuento += 0.05;

            double precioFinal = precio * (1 - descuento);
            Console.WriteLine($"Precio final: {precioFinal:F2}");

            Console.ReadKey();         
        }
        static void EjercicioNota()
        {
           
            Console.Write("Ingrese una nota (0–20): ");
            int nota = Convert.ToInt32(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error: nota fuera de rango.");
                return;
            }

            switch (nota)
            {
                case int n when (n <= 10):
                    Console.WriteLine("Desaprobado");
                    break;
                case int n when (n <= 13):
                    Console.WriteLine("Regular");
                    break;
                case int n when (n <= 17):
                    Console.WriteLine("Bueno");
                    break;
                default:
                    Console.WriteLine("Excelente");
                    break;
            }

            if (nota >= 14 && nota % 2 == 0)
                Console.WriteLine("Buen desempeño con nota par");
            if (nota < 11 || nota % 2 != 0)
                Console.WriteLine("Necesita reforzar");

            Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(nota):F1}");
            Console.WriteLine($"Potencia al cubo: {Math.Pow(nota, 3)}");

        }
    }
}
