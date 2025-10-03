namespace _27.matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            int positivos = 0, negativos = 0, ceros = 0;

            Console.WriteLine("Ingrese los elementos de la matriz:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());

                    if (matriz[i, j] > 0)
                        positivos++;
                    else if (matriz[i, j] < 0)
                        negativos++;
                    else
                        ceros++;
                }
            }

            Console.WriteLine($"\nTotal positivos: {positivos}");
            Console.WriteLine($"Total negativos: {negativos}");
            Console.WriteLine($"Total ceros: {ceros}");
        }
    }
}
