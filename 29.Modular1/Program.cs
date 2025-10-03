namespace _29.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiposDe5 = new int[capturarFilas(),capturarColumnas()];
        }


        static int capturarFilas()
        {
           Console.Write("Ingrese el número de filas para la matriz");
            int filas = int.Parse(Console.ReadLine());
            return filas;
        }

        static int capturarColumnas()
        {
            Console.Write("Ingrese el número de columnas para la matriz");
            int columnas = int.Parse(Console.ReadLine());
           return columnas;
        }

        static int[,] llenarMatriz(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matriz;
        }


    }
}