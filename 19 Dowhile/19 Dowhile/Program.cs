namespace _19_Dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int hombres = 0;
            int mujeres = 0;
            int mayores = 0;
            int menores = 0;
            int contador = 1;

            do
            {
                Console.Write($"Ingrese el sexo del alumno {contador} (H/M): ");
                string sexo = Console.ReadLine().ToUpper();

                if (sexo == "H")
                {
                    hombres++;
                }
                else if (sexo == "M")
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Entrada no válida, se contará como mujer por defecto.");
                    mujeres++;
                }

                Console.Write($"Ingrese la edad del alumno {contador}: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }
                contador++;

            } while (contador <= 100);

            Console.WriteLine("\nCantidad de hombres: " + hombres);
            Console.WriteLine("Cantidad de mujeres: " + mujeres);
        }
    }











}
    

