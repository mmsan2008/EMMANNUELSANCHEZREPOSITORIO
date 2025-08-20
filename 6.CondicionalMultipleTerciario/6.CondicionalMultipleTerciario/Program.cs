using System.Diagnostics.Tracing;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float Valorcompra = 0;
            float descuento = 0;
            char dia = ' ';

            Console.WriteLine("ingrese el valor de la compra:");
            Valorcompra = Single.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el dia de la semana l: lunes, m: martes, x:miercoles, j:jueves, v:viernes, s: sabado, d:domingo" );
            dia = Convert.ToChar(Console.ReadLine());

            switch (dia)
            {
                case 'l':
                    descuento = Valorcompra * 0.1f;
                    Console.WriteLine($"hoy es lunes, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;

                case 'm':
                    descuento = Valorcompra * 0.15f;
                    Console.WriteLine($"hoy es martes, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;

                case 'x':
                    descuento = Valorcompra * 0.1f;
                    Console.WriteLine($"hoy es miercoles, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;
                case 'j':
                    descuento = Valorcompra * 0.15f;
                    Console.WriteLine($"hoy es jueves, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;
                case 'v':
                    descuento = Valorcompra * 0.2f;
                    Console.WriteLine($"hoy es viernes, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;
                case 's':
                    descuento = Valorcompra * 0.2f;
                    Console.WriteLine($"hoy es sabado, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;
                case 'd':
                    descuento = Valorcompra * 0f;
                    Console.WriteLine($"hoy es domingo, descuento:{descuento},valor a pagar:{Valorcompra - descuento}");
                    break;
                default:
                    Console.WriteLine("debe ingresar un valor valido");
                    break;









            }


        }
    }
}
