namespace _16dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 101); 
            int intento = 0;

            Console.WriteLine("Adivina el número (entre 1 y 100):");

            while (intento != numeroSecreto)
            {
                Console.Write("Ingresa tu intento: ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroSecreto)
                {
                    Console.WriteLine("Demasiado bajo, intenta otra vez.");
                }
                else if (intento > numeroSecreto)
                {
                    Console.WriteLine("Demasiado alto, intenta otra vez.");
                }
                else
                {
                    Console.WriteLine("Correcto Adivinaste el número.");
                }
            }
        }
    }
}