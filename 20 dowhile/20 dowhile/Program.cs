using System.ComponentModel.Design;

namespace _20_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalpartidos = 0;
            int ganados, perdidos, empatados;

            do
            {
                Console.WriteLine("ingrese partidos ganados");
                ganados = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese partidos perdidos");
                perdidos = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese partidos empatados");
                empatados = int.Parse(Console.ReadLine());

                if(ganados + perdidos + empatados != totalpartidos)

                {
                    Console.WriteLine("error, la suma de los partidos no es igual a 30");
                }
 

            } while (ganados + perdidos + empatados == totalpartidos);

            double ptjeganados = (ganados / (double)totalpartidos);
            double ptjeperdidos = (perdidos / (double)totalpartidos);
            double ptjeempatados = (empatados / (double)totalpartidos);

            Console.WriteLine($"ganados {ganados} ({ptjeganados:F2}%)");
            Console.WriteLine($"ganados {perdidos} ({ptjeperdidos:F2}%)");
            Console.WriteLine($"empatados {empatados} ({ptjeempatados:F2}%)");




        }

    }

}








