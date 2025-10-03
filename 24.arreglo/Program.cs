namespace _24.arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese el número #{i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            double promedio = (double)suma / 10;
            Console.WriteLine($"El promedio es: {promedio}");
        }
    }
}

