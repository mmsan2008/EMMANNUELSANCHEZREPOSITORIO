using System.Diagnostics.CodeAnalysis;

namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1 Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona,
                 si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla 
                 con el nombre de la persona,
                 indicando que debe abonar impuestos.*/

            //condicional simple
            string nombre = "";
            int sueldo = 0;
            int edad = 0;
            int numero1 = 0;
            int numero2 = 0;
           

            /*Console.WriteLine("Ingrese el Nombre");
            nombre = Console.ReadLine();//todo lo que yo leo desde la consola llega como un string 


            Console.WriteLine(" Ingrese sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"la persona {nombre}, debe abonar impuestos");
            }
            else
            {
                Console.WriteLine($"la persona {nombre}, no abona impuestos");
            }

            /*Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18,
             * se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”.*/

            /*Console.WriteLine("ingrese la edad");
            edad = Int32.Parse(Console.ReadLine());


            if (edad > 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("la persona no cumple la edad requerida");
            }*/

            Console.WriteLine("ingrese el numero 1");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el numero 2");
            numero2 = Int32.Parse(Console.ReadLine());

            numero1 += numero2;
            numero1 -= numero2;
            numero1 /= numero2;
            numero1 *= numero2;



            if (numero1 > numero2)
            {
                Console.WriteLine($"suma:{numero1 += numero2},Resta:{numero1 -= numero2},");


            }
            else if (numero1 < numero2)
            {
                
                Console.WriteLine($"Producto:{numero1 *= numero2}");
                    Console.WriteLine($"Divicion: {numero1 /= numero2}");
            }

        }
    }
}