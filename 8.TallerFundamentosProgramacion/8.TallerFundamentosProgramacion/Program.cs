using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace _8.TallerFundamentosProgramacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;
            int menor = 0;
            int medio = 0;



            Console.WriteLine("ingrese numero1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero3");
            num3 = Int32.Parse(Console.ReadLine());
            mayor = num1 > num2
               ? (num1 > num3 ? num1 : num3)
               : (num2 > num3 ? num2 : num3);


            Console.WriteLine($"El numero mayor es: {mayor}");


            if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                Console.WriteLine("Error: Debe ingresar nuevo numero");

            }
;
            if (num1 < num2 && num1 < num3)
            {
                menor = num1;
                if (num2 < num3)
                {
                    medio = num2;
                    mayor = num3;

                }
                else
                {
                    medio = num3;
                    mayor = num2;

                }


            }
            else if (num2 < num1 && num2 < num3)
            {
                menor = num2;
                if (num1 < num3)
                {
                    medio = num1;
                    mayor = num3;

                }
                else
                {
                    medio = num3;
                    mayor = num1;

                }


            }
            else if (num3 < num2 && num3 < num1)
            {
                menor = num3;
                if (num3 < num1)
                {
                    medio = num1;
                    mayor = num2;

                }
                else
                {
                    medio = num2;
                    mayor = num1;

                }




            }
            Console.WriteLine("Ordenados:" + menor + "-" + medio + "-" + mayor + "-");}(*/



            /*bool invisivle;
            int balas;




            Console.WriteLine("personaje esta invicible");

            invisivle = Console.ReadLine() != null;
            if (invisivle)
            {
                invisivle = true;
                Console.WriteLine("invisible on ");
                invisivle = Console.ReadLine() != null;
            }

            Console.WriteLine(value: $"tus balas son");
            Random rand = new Random();
            balas = rand.Next(1, 20);
            Console.WriteLine(balas);

            if (invisivle && balas >= 1 && balas <= 10)
            {
                Console.WriteLine("el personaje esta disparando");

            } */





            /*Console.WriteLine("ingrese componentes de p1");
            double x1 = int.Parse(Console.ReadLine());
            double y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese componentes de p2");
            double x2 = int.Parse(Console.ReadLine());
            double y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese componentes de p3");
            double x3 = int.Parse(Console.ReadLine());
            double y3 = int.Parse(Console.ReadLine());

            double d1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double d2 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            double d3 = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));

            Console.WriteLine($"la distancia entre p1 y p2 es :{d1}");
            Console.WriteLine($"la distancia entre p2 y p3 es :{d2}");
            Console.WriteLine($"la distancia entre p3 y p1 es :{d3}");
            int.Parse(Console.ReadLine());

            bool c1 = d1 + d2 > d3;
            bool c2 = d2 + d3 > d1;
            bool c3 = d3 + d1 > d2;

            if (c1 && c2 && c3)
            {
                Console.WriteLine("\nCon estas distancias se puede construir un triángulo.");
            }
            else
            {
                Console.WriteLine("\n No se puede construir un triángulo. Fallaron estas condiciones:");
                if (!c1) Console.WriteLine($" - d1 + d2 > d3 no se cumple ({d1} + {d2} <= {d3})");
                if (!c2) Console.WriteLine($" - d2 + d3 > d1 no se cumple ({d2} + {d3} <= {d1})");
                if (!c3) Console.WriteLine($" - d3 + d1 > d2 no se cumple ({d3} + {d1} <= {d2})");
            }

            Console.ReadLine();*/


            /*Console.WriteLine("Ingrese una tecla para mover al personaje (a = izquierda, d = derecha): ");
            char tecla = char.Parse(Console.ReadLine());

            if (tecla == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (tecla == 'a')
            {
                Console.WriteLine("El personaje se mueve hacia la izquierda");
            }
            else
            {
                Console.WriteLine("Error: No me puedo mover en otra dirección");
            }

            Console.ReadLine();*/


            Random rand = new Random();
            int vidas = rand.Next(0, 6); 

            Console.WriteLine($"El personaje tiene {vidas} vidas.");

            if (vidas > 0)
            {
                Console.WriteLine("Ingrese una acción (c, x, t, i): ");
                char accion = char.Parse(Console.ReadLine());

                switch (accion)
                {
                    case 'c':
                        Console.WriteLine("El personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje está hablando con la Rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es Invencible");
                        break;
                    default:
                        Console.WriteLine("Acción no válida");
                        break;
                }
            }
            else
            {
                Console.WriteLine(" El personaje no posee vidas, y no puede realizar ninguna acción");
            }

            Console.ReadLine();
        }
    }





}
    

