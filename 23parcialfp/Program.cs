namespace _23parcialfp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Don Alcides, un tendero, realiza la venta de 10 productos y necesita calcular el valor total de la venta aplicando el IVA correspondiente 
             * a cada uno de ellos según las siguientes condiciones:
             Si el valor del producto es mayor a 10.000, se aplica un 15 % de IVA.
            Si el valor del producto es menor o igual a 5.000, se aplica un 19 % de IVA.
            El programa debe realizar lo siguiente:
           Solicitar por teclado el valor de cada uno de los 10 productos.
           Calcular el subtotal de cada producto, teniendo en cuenta el valor ingresado más el IVA correspondiente.
            Sumar los subtotales de los 10 productos.
           Mostrar en pantalla el valor total de la venta.*/

            int cantproductos = 10;
            double valorproducto;
            double subtotal;
            double totalventa = 0;
            double iva = 0;



            Console.WriteLine("don arecides desea calcular el valor total de la venta");

            for (int i = 1; i <= cantproductos; i++)
            {
                Console.WriteLine("ingrese el valor del producto " + i);
                valorproducto = double.Parse(Console.ReadLine());

                

                if (valorproducto > 10000)
                {
                    iva = valorproducto * 0.15;
                }
                else if (valorproducto <= 5000)
                {
                    iva = valorproducto * 0.19;
                }

                subtotal = valorproducto + iva;
                totalventa += subtotal;

                Console.WriteLine("el subtotal del producto " + i + " es: " + subtotal);

                
            }
            Console.WriteLine("el valor total de la venta es: " + totalventa);





        }
    }
}
