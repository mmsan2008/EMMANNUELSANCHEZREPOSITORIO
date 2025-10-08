using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace parcial_numero_3_fp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Gestión de ocupación y facturación en un hotel
            Se desea desarrollar un programa para gestionar la ocupación y facturación anual de un hotel.
            El hotel tiene 6 pisos y en cada piso hay 4 habitaciones.Se requiere registrar cuántas noches ha sido ocupada cada habitación durante el año, así como el monto total facturado por cada habitación.
            Requisitos del programa:
            Estructura de datos:
            Utilizar dos matrices bidimensionales de 6 filas por 4 columnas:
            Una matriz ocupacion para almacenar la cantidad de noches ocupadas por habitación.
            Una matriz facturacion para almacenar el total facturado en pesos por habitación.
            Cada fila representa un piso del hotel(Piso 1 a Piso 6).
            Cada columna representa una habitación en ese piso(Habitación A a D).
            Ingreso de datos:
            Para cada habitación(por piso y letra), se debe solicitar al usuario:
            La cantidad de noches ocupada en el año(valor entero entre 0 y 365).
            El monto total facturado por esa habitación(valor positivo decimal).
            Validar ambos valores:
            Las noches deben estar entre 0 y 365.
            El monto debe ser mayor o igual a 0.
            Visualización de la información:
            Mostrar ambas matrices(ocupacion y facturacion) en formato tabulado con encabezados(Pisos y Habitaciones A, B, C, D).
            Los valores deben presentarse con claridad y formato numérico adecuado.
            Cálculos requeridos:
            a) Total de noches ocupadas por piso:
            Calcular y mostrar cuántas noches en total se ocuparon en cada piso del hotel.
            b) Ingreso total por habitación:
            Calcular y mostrar cuánto dinero facturó cada habitación en el año.
            c) Habitación más rentable:
            Determinar cuál fue la habitación que más dinero facturó en el año. Mostrar:
             Piso
             Letra de habitación
            Monto facturado
            d) Porcentaje de ocupación del hotel:
            Calcular el total de noches ocupadas en todo el hotel.
            Calcular el porcentaje de ocupación de cada habitación con respecto al total posible.
            e) Habitaciones sin ocupación:
            Mostrar cuántas habitaciones no fueron ocupadas en todo el año(0 noches).*/





            const int pisos = 6;
            const int habitaciones = 4;
            string[] letras = { "A", "B", "C", "D" };

            int[,] ocupacion = new int[pisos, habitaciones];
            double[,] facturacion = new double[pisos, habitaciones];


            for (int i = 0; i < pisos; i++)
            {

                Console.WriteLine($"piso {i + 1}");


                for (int j = 0; j < habitaciones; j++)
                {



                    int noches;
                    do
                    {
                        Console.Write($"noches ocupadas habitacion {letras[j]}: ");
                    } while (!int.TryParse(Console.ReadLine(), out noches) || noches < 0 || noches > 365);
                    ocupacion[i, j] = noches;

                    double monto;
                    do
                    {
                        Console.Write($"monto total facturado en pesos habitacion {letras[j]}: ");
                    } while (!double.TryParse(Console.ReadLine(), out monto) || monto < 0);



                    facturacion[i, j] = monto;

                }
            }

            Console.Clear();


            Console.WriteLine("matriz de ocupacion (noches):");
            MostrarMatriz(ocupacion, letras);
            Console.WriteLine();

            Console.WriteLine("matriz de facturacion en pesos:");
            MostrarMatriz(facturacion, letras);


            Console.WriteLine();
            Console.WriteLine("total de noches por piso:");

            for (int i = 0; i < pisos; i++)
            {
                int suma = 0;

                for (int j = 0; j < habitaciones; j++)
                    suma += ocupacion[i, j];

                Console.WriteLine($"piso {i + 1}: {suma}");

            }


            double mayor = 0;

            int pisoMax = 0, habMax = 0;
            for (int i = 0; i < pisos; i++)
            {
                for (int j = 0; j < habitaciones; j++)
                {
                    if (facturacion[i, j] > mayor)
                    {
                        mayor = facturacion[i, j];
                        pisoMax = i;
                        habMax = j;
                    }
                }
            }


            Console.WriteLine();
            Console.WriteLine("ingresos por habitacion:");
            for (int i = 0; i < pisos; i++)
            {
                for (int j = 0; j < habitaciones; j++)
                {



                    Console.WriteLine($"piso {i + 1}, habitacion {letras[j]}: ${facturacion[i, j]:N2}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("habitacion con mayor rentabilidad:");

            Console.WriteLine($"piso: {pisoMax + 1}");
            Console.WriteLine($"habitacion: {letras[habMax]}");
            Console.WriteLine($"monto: ${mayor:N2}");





            int totalNoches = 0;

            foreach (int n in ocupacion) totalNoches += n;

            int totalPosible = pisos * habitaciones * 365;

            double porcentaje = (double)totalNoches / totalPosible * 100;

            Console.WriteLine();

            Console.WriteLine("porcentaje de ocupacion del hotel:");
            Console.WriteLine($"noches ocupadas: {totalNoches}");
            Console.WriteLine($"ocupacion total: {porcentaje:F2}%");


            int sinOcupar = 0;

            for (int i = 0; i < pisos; i++)

                for (int j = 0; j < habitaciones; j++)
                    if (ocupacion[i, j] == 0)
                        sinOcupar++;

            Console.WriteLine();

            Console.WriteLine($"habitaciones sin ocupacion: {sinOcupar}");

        }

        static void MostrarMatriz(int[,] matriz, string[] letras)
        {
            Console.Write("\t");

            foreach (var letra in letras)

                Console.Write($"hab {letra}\t");
            Console.WriteLine();


            for (int i = 0; i < matriz.GetLength(0); i++)
            {



                Console.Write($"piso {i + 1}\t");

                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"{matriz[i, j]}\t");

                Console.WriteLine();


            }
        }

        static void MostrarMatriz(double[,] matriz, string[] letras)
        {
            Console.Write("\t");
            foreach (var letra in letras)

                Console.Write($"hab {letra}\t");
            Console.WriteLine();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.Write($"piso {i + 1}\t");
                for (int j = 0; j < matriz.GetLength(1); j++)
                    Console.Write($"{matriz[i, j]:N2}\t");
                Console.WriteLine();
            }
        }
    }

}