namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acomulador = 0;

            while (contador <= 5)
            {
                acomulador += contador;
                Console.WriteLine($"c:{contador} - A:{acomulador}");
                contador++;
            }

            Console.WriteLine($"la suma de los cinco primeros numeros enteros es: {acomulador}");









        }
    }
}
