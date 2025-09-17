namespace _11dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int suma = 0;

            Console.WriteLine("ingrese numero positivo (negativo para terminar)");
            numero = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("ingrese numero positivo (negativo para terminar)");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                }

            } while (numero >= 0);

            Console.WriteLine($"la suma total es" + suma);

        }
    }
}
