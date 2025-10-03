namespace _26.matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"matriz1[{i},{j}]: ");
                    matriz1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los elementos de la segunda matriz (2x3):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"matriz2[{i},{j}]: ");
                    matriz2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Sumar las matrices
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    suma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            Console.WriteLine("Matriz suma:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(suma[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
