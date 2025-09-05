namespace _17.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*int contador = 0;
            int acomulador = 0;

            do
            {
                contador++;
                acomulador = acomulador + contador;

            } while (contador < 5);

            Console.WriteLine($"la suma de los 5 primeros numeroses:{acomulador}");*/



            //17. algoritmo que solicita un numero y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10
            //y asi sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar

            int numtabla = 0;
            int multiplicador = 1;
            string respuesta = " ";


            do
            {   
                Console.WriteLine("ingrese el numero de la tabla de multiplicar");
                numtabla = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numtabla} x {multiplicador} = {numtabla * multiplicador}");
                    multiplicador++;



                } while (multiplicador <= 10);
                multiplicador = 1;
                Console.WriteLine("desea generar otra tabla de multiplicar: s:si ,n=no");
                respuesta = Console.ReadLine().ToLower();
                

            } while (respuesta == "s");





        }
    }
}
