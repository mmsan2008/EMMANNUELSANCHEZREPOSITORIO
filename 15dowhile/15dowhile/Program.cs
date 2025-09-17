namespace _15dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ahorroTotal = 0;
        int mes = 1;

        do
        {
            Console.Write($"Ingrese la cantidad a depositar en el mes {mes}: ");
            double deposito = double.Parse(Console.ReadLine());

            ahorroTotal += deposito;

            Console.WriteLine($"Ahorro acumulado después del mes {mes}: {ahorroTotal}");

            mes++;

        } while (mes <= 12);

        Console.WriteLine($"\nEl ahorro total en el año es: {ahorroTotal}");
        }
    }
}
