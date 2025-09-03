namespace _13.while5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int contarpares = 0;
            int rango = 0;

            Console.WriteLine("ingrese el rango de numeros a evaluar");
            rango = int.Parse(Console.ReadLine());


            while (contador <= rango)
            {

                if (contador % 2 == 0)
                {
                    contarpares++;

                }
                contador++;
            }
            Console.WriteLine($"la cantidad de numeros pares del 1 hasta {rango}, es : {contarpares}");












        }
    }
}
