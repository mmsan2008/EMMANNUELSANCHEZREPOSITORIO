namespace _23.arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[100];

            // Asignar 10 a todas las posiciones
            for (int i = 0; i < 100; i++)
            {
                numeros[i] = 10;
            }

            // Mostrar todos los elementos
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Elemento {i}: {numeros[i]}");
            }
        }
    }
}
