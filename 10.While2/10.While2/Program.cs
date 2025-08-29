namespace _10.While2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario.(5! =1*2*3*4*5)
            int num = 0;
            int contador = 1;
            int acomulador = 1;
            Console.WriteLine("ingrese un numero para calcular la factorial");
            num =int.Parse(Console.ReadLine());

            while (contador <=num)
            {
               
                acomulador = acomulador *contador;
                Console.WriteLine($"Contador:{contador}-Factorial:{acomulador}");
                contador++;

            }
            Console.WriteLine($"el factorial de {num}, es {acomulador}");

        }
    }
}
