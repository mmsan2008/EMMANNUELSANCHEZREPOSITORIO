namespace _12.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int i = 1;

            do
            {
                suma += i;
                i += 2; 
            } while (i <= 99);

            Console.WriteLine("La suma de los números impares hasta 99 es: " + suma);
        }
    }
}
